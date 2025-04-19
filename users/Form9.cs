using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using users.models;

namespace users
{
    public partial class Form9 : Form
    {
        ITIProjectContext db;
        private int? selectedPermissionId = null;
        public Form9()
        {
            InitializeComponent();
            db = new ITIProjectContext();

            LoadWarehouses();
        }
        private void LoadWarehouses()
        {



            combo_warehouse.DataSource = db.Warehouses.ToList();
            combo_warehouse.DisplayMember = "NameWarehouse";
            combo_warehouse.ValueMember = "IdWarehouse";
            combo_warehouse.SelectedIndex = -1;

            combo_customer.DataSource = db.Customers.ToList();
            combo_customer.DisplayMember = "NameCustomer";
            combo_customer.ValueMember = "IdCustomer";
            combo_customer.SelectedIndex = -1;

            text_number.Text = string.Empty;

            dateTime_premission.CustomFormat = " ";
            dateTime_premission.Format = DateTimePickerFormat.Custom;



        }
        private void btn_display_Click(object sender, EventArgs e)
        {
            try
            {

                var permissions = db.Permissions
                    .Select(p => new
                    {
                        p.Id,
                        p.PermissionNumber,
                        p.PermissionDate,
                        WarehouseName = p.Warehouse.NameWarehouse,
                        CustomerName = p.Customer.NameCustomer,
                        ItemCount = p.Items.Count
                    })
                    .ToList();
                dataGridView1.DataSource = permissions;
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newPermission = new Permission
                {


                    WarehouseId = (int)combo_warehouse.SelectedValue,
                    CustomerId = (int)combo_customer.SelectedValue,
                    PermissionNumber = text_number.Text,
                    PermissionDate = dateTime_premission.Value,

                };


                db.Permissions.Add(newPermission);
                db.SaveChanges();

                MessageBox.Show("Permission added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_display_Click(sender, e);
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearForm()
        {

            text_number.Text = " ";
            combo_customer.Text = " ";
            combo_warehouse.Text = " ";
            dateTime_premission.CustomFormat = " ";
            dateTime_premission.Format = DateTimePickerFormat.Custom;
            selectedPermissionId = null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!selectedPermissionId.HasValue)
            {
                MessageBox.Show("Please select a permission to update by double-clicking a row", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var permission = db.Permissions.Find(selectedPermissionId.Value);
                if (permission == null)
                {
                    MessageBox.Show("Selected permission not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearForm();
                    return;
                }
                permission.WarehouseId = (int)combo_warehouse.SelectedValue;
                permission.CustomerId = (int)combo_customer.SelectedValue;
                permission.PermissionNumber = text_number.Text.Trim();
                permission.PermissionDate = dateTime_premission.Value;

                db.SaveChanges();

                MessageBox.Show("Permission updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_display_Click(sender, e);
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during updating permission");
            }
        }
        private bool ValidateInputs()
        {
            return combo_warehouse.SelectedIndex != -1 &&
                   combo_customer.SelectedIndex != -1 &&
                   !string.IsNullOrEmpty(text_number.Text) &&
                   dateTime_premission.Format != DateTimePickerFormat.Custom;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                try
                {
                    var selectedRow = dataGridView1.Rows[e.RowIndex];
                    selectedPermissionId = (int)selectedRow.Cells["Id"].Value;

                    var permission = db.Permissions.Find(selectedPermissionId.Value);
                    if (permission != null)
                    {
                        combo_warehouse.SelectedValue = permission.WarehouseId;
                        combo_customer.SelectedValue = permission.CustomerId;
                        text_number.Text = permission.PermissionNumber;
                        dateTime_premission.Value = permission.PermissionDate;
                        dateTime_premission.Format = DateTimePickerFormat.Short;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during loading permission details");
                    clearForm();
                }
            }
        }

        private void dateTime_premission_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime_premission.Format == DateTimePickerFormat.Custom)
            {
                dateTime_premission.Format = DateTimePickerFormat.Short;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!selectedPermissionId.HasValue)
            {
                MessageBox.Show("Please select a permission to delete by double-clicking a row", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var permission = db.Permissions.Find(selectedPermissionId.Value);
                if (permission == null)
                {
                    MessageBox.Show("The selected permission does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearForm();
                    return;
                }


                var result = MessageBox.Show($"Are you sure you want to delete permission number {permission.PermissionNumber}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                db.Permissions.Remove(permission);
                db.SaveChanges();

                MessageBox.Show("Permission deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_display_Click(sender, e);
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Permission);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openForm_Permission()
        {
            Application.Run(new Form3());
        }
    }
}

   

