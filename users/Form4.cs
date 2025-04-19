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

    public partial class Warehouse : Form
    {
        ITIProjectContext db;
        public Warehouse()
        {
            InitializeComponent();
            db = new ITIProjectContext();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Warehouses.Select(w => new
            {
                 w.NameWarehouse,
                 w.AddressWarehouse,
                 w.MangerWarehouse
            }
            ).ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_add.Text) || string.IsNullOrEmpty(txt_mang.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            models.Warehouse warehouse = new models.Warehouse();
            warehouse.NameWarehouse = txt_name.Text;
            warehouse.AddressWarehouse = txt_add.Text;
            warehouse.MangerWarehouse = txt_mang.Text;
            db.Warehouses.Add(warehouse);
            db.SaveChanges();
            MessageBox.Show("Warehouse added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            emptyTextBox();
            btn_Display_Click(null, null);
        }

        public void emptyTextBox()
        {
            txt_name.Text = txt_add.Text = txt_mang.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_add.Text) || string.IsNullOrEmpty(txt_mang.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            models.Warehouse warehouse = db.Warehouses.Where(w => w.IdWarehouse == selectedId).FirstOrDefault();

            if (warehouse != null)
            {
                warehouse.NameWarehouse = txt_name.Text;
                warehouse.AddressWarehouse = txt_add.Text;
                warehouse.MangerWarehouse = txt_mang.Text;
                db.SaveChanges();
                MessageBox.Show("Warehouse updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyTextBox();
                btn_Display_Click(null, null);
            }
            else
            {
                MessageBox.Show("Warehouse not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_add.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_mang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_add.Text) || string.IsNullOrEmpty(txt_mang.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            models.Warehouse warehouse = db.Warehouses.Where(w => w.IdWarehouse == selectedId).FirstOrDefault();
            if (warehouse != null)
            {
                db.Warehouses.Remove(warehouse);
                db.SaveChanges();
                MessageBox.Show("Warehouse deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyTextBox();
                btn_Display_Click(null, null);
            }
            else
            {
                MessageBox.Show("Warehouse not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void openForm()
        {
            Application.Run(new Form3());
        }

        private void search_Click(object sender, EventArgs e)
        {

            string searchText = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
            var searchResult = db.Warehouses.Where(w => w.NameWarehouse.Contains(searchText) 
                                    || w.AddressWarehouse.Contains(searchText)
                                    || w.MangerWarehouse.Contains(searchText)).Select(w => new
                                    {
                                      
                                        w.NameWarehouse,
                                        w.AddressWarehouse,
                                        w.MangerWarehouse
                                    }).ToList();

            dataGridView1.DataSource = searchResult;
            txt_search.Text = "";



        }
    }
}
