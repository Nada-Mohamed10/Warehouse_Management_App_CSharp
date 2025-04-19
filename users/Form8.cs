using Microsoft.EntityFrameworkCore;
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
    public partial class Form8 : Form
    {
        ITIProjectContext db;
        private List<SupplyOrderItem> tempItems;
        public Form8()
        {
            InitializeComponent();
            db = new ITIProjectContext();
            tempItems = new List<SupplyOrderItem>();

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
            ClearForm();
        }

        public void loadComboBoxes()
        {
            combo_warehouse.SelectedIndex = -1;
            combo_supplier.SelectedIndex = -1;
            combo_product.SelectedIndex = -1;

            combo_warehouse.DataSource = db.Warehouses.ToList();
            combo_warehouse.DisplayMember = "NameWarehouse";
            combo_warehouse.ValueMember = "IdWarehouse";

            combo_product.DataSource = db.Products.ToList();
            combo_product.DisplayMember = "NameProduct";
            combo_product.ValueMember = "IdProduct";

            combo_supplier.DataSource = db.Suppliers.ToList();
            combo_supplier.DisplayMember = "NameSupplier";
            combo_supplier.ValueMember = "IdSupplier";
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            var supplyOrders = db.SupplyOrders
                .Select(so => new
                {
                    so.PermissionNumber,
                    so.PermissionDate,
                    WarehouseName = so.Warehouse.NameWarehouse,
                    SupplierName = so.Supplier.NameSupplier,
                    so.ProductionDate,
                    so.ExpiryDate,
                    ItemCount = so.Items.Count
                }).ToList();

            dataGridView1.DataSource = supplyOrders;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_number.Text) || string.IsNullOrEmpty(dateTime_Date.Text) ||
            string.IsNullOrEmpty(dateTime_production.Text) || string.IsNullOrEmpty(dateTime_Expiry.Text) ||
            string.IsNullOrEmpty(combo_warehouse.Text) || string.IsNullOrEmpty(combo_supplier.Text))
            {
                MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tempItems.Count == 0)
            {
                MessageBox.Show("Please add at least one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingSupplyOrder = db.SupplyOrders.FirstOrDefault(so => so.PermissionNumber == txt_number.Text);
            if (existingSupplyOrder != null)
            {
                MessageBox.Show("Supply Order already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSupplyOrder = new SupplyOrder
            {
                PermissionNumber = txt_number.Text,
                PermissionDate = dateTime_Date.Value,
                ProductionDate = dateTime_production.Value,
                ExpiryDate = dateTime_Expiry.Value,
                WarehouseId = (int)combo_warehouse.SelectedValue,
                SupplierId = (int)combo_supplier.SelectedValue,
                Items = tempItems
            };

            try
            {
                db.SupplyOrders.Add(newSupplyOrder);
                db.SaveChanges();
                MessageBox.Show("Supply Order added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                btn_display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Supply Order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string permissionNumber = dataGridView1.Rows[e.RowIndex].Cells["PermissionNumber"].Value.ToString();
                var supplyOrder = db.SupplyOrders
            .Include(so => so.Items)
            .ThenInclude(i => i.Product)
            .FirstOrDefault(so => so.PermissionNumber == permissionNumber);

                if (supplyOrder != null)
                {
                    txt_number.Text = supplyOrder.PermissionNumber;
                    dateTime_Date.Value = supplyOrder.PermissionDate;
                    dateTime_production.Value = supplyOrder.ProductionDate;
                    dateTime_Expiry.Value = supplyOrder.ExpiryDate;
                    combo_warehouse.SelectedValue = supplyOrder.WarehouseId;
                    combo_supplier.SelectedValue = supplyOrder.SupplierId;


                    tempItems = supplyOrder.Items.ToList();

                    UpdateItemsGrid();
                    combo_product.SelectedIndex = -1;
                    // txt_quantity.Clear();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_number.Text) || string.IsNullOrEmpty(dateTime_Date.Text) ||
        string.IsNullOrEmpty(dateTime_production.Text) || string.IsNullOrEmpty(dateTime_Expiry.Text) ||
        string.IsNullOrEmpty(combo_warehouse.Text) || string.IsNullOrEmpty(combo_supplier.Text))
            {
                MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tempItems.Count == 0)
            {
                MessageBox.Show("Please add at least one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingSupplyOrder = db.SupplyOrders
                .Include(so => so.Items)
                .FirstOrDefault(so => so.PermissionNumber == txt_number.Text);

            if (existingSupplyOrder == null)
            {
                MessageBox.Show("Supply Order does not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            existingSupplyOrder.PermissionDate = dateTime_Date.Value;
            existingSupplyOrder.ProductionDate = dateTime_production.Value;
            existingSupplyOrder.ExpiryDate = dateTime_Expiry.Value;
            existingSupplyOrder.WarehouseId = (int)combo_warehouse.SelectedValue;
            existingSupplyOrder.SupplierId = (int)combo_supplier.SelectedValue;

            existingSupplyOrder.Items.Clear();
            foreach (var item in tempItems)
            {
                existingSupplyOrder.Items.Add(new SupplyOrderItem
                {
                    IdProduct = item.IdProduct,
                   // Quantity = item.Quantity,
                    Product = item.Product
                });
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Supply Order updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                btn_display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Supply Order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateItemsGrid()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = tempItems.Select(i => new
            {
                NameProduct = i.Product.nameProduct,
               // Quantity = i.Quantity
            }).ToList();

            if (dgvItems.Columns.Count > 0)
            {
                dgvItems.Columns["NameProduct"].HeaderText = "Product Name";
               // dgvItems.Columns["Quantity"].HeaderText = "Quantity";
            }
        }


        private void ClearForm()
        {
            txt_number.Clear();
            dateTime_Date.Value = DateTime.Now;
            dateTime_production.Value = DateTime.Now;
            dateTime_Expiry.Value = DateTime.Now;
            combo_warehouse.SelectedIndex = -1;
            combo_supplier.SelectedIndex = -1;
            combo_product.SelectedIndex = -1;
            //  txt_quantity.Clear();
            tempItems.Clear();
            UpdateItemsGrid();

        }

        private void additem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combo_product.Text))
            {
                MessageBox.Show("Please select a product and enter a quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!decimal.TryParse(txt_quantity.Text, out decimal quantity) || quantity <= 0)
            //{
            //    MessageBox.Show("Quantity must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            var newItem = new SupplyOrderItem
            {
                IdProduct = (int)combo_product.SelectedValue,
                //Quantity = quantity,
                Product = db.Products.Find((int)combo_product.SelectedValue)
            };

            tempItems.Add(newItem);

            UpdateItemsGrid();
            //txt_quantity.Clear();
            combo_product.SelectedIndex = -1;
        }

        private void dgvItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tempItems.Count)
            {
                var selectedItem = tempItems[e.RowIndex];
                combo_product.SelectedValue = selectedItem.IdProduct;
                //txt_quantity.Text = selectedItem.Quantity.ToString();

            }
        }

        private void btn_updateitem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvItems.SelectedRows[0].Index;
                if (string.IsNullOrEmpty(combo_product.Text))
                {
                    MessageBox.Show("Please select a product and enter a quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //if (!decimal.TryParse(txt_quantity.Text, out decimal quantity) || quantity <= 0)
                //{
                //    MessageBox.Show("Quantity must be a positive number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}


                tempItems[selectedIndex].IdProduct = (int)combo_product.SelectedValue;
                //tempItems[selectedIndex].Quantity = quantity;
                tempItems[selectedIndex].Product = db.Products.Find((int)combo_product.SelectedValue);

                UpdateItemsGrid();
                //  txt_quantity.Clear();
                combo_product.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select an item to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dgvItems.SelectedRows[0].Index;
                    tempItems.RemoveAt(selectedIndex);
                    UpdateItemsGrid();
                    //  txt_quantity.Clear();
                    combo_product.SelectedIndex = -1;
                    MessageBox.Show("Item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                var result = MessageBox.Show("Are you sure you want to delete this supply order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    string permissionNumber = dataGridView1.Rows[selectedIndex].Cells["PermissionNumber"].Value.ToString();


                    var supplyOrder = db.SupplyOrders
                        .Include(so => so.Items)
                        .FirstOrDefault(so => so.PermissionNumber == permissionNumber);

                    if (supplyOrder != null)
                    {
                        try
                        {

                            db.SupplyOrders.Remove(supplyOrder);

                            db.SaveChanges();

                            MessageBox.Show("Supply Order deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearForm();

                            btn_display_Click(null, null);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Error deleting Supply Order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Supply Order not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

                MessageBox.Show("Please select a supply order to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Permission);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void openForm_Permission()
        {
            Application.Run(new Form3());
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


