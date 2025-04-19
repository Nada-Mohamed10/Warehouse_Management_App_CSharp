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
    public partial class Form5 : Form
    {
        ITIProjectContext db;
        public Form5()
        {
            InitializeComponent();
            db = new ITIProjectContext();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {

            var productList = db.WarehouseProducts
          .Select(wp => new
          {
              ProductCode = wp.Products.CodeProduct,
              ProductName = wp.Products.nameProduct,
              MeasurementUnit = wp.Products.MeasurementUnit,
              
              WarehouseName = wp.Warehouse.NameWarehouse
          })
          .ToList();

            dataGridView1.DataSource = productList;

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            combo_unit.SelectedIndex = -1;
            combo_unit.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_unit.Items.AddRange(new string[] { "Kg", "Liter", "Piece" });


            combo_warehouse.SelectedIndex = -1;
            combo_warehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_warehouse.Items.AddRange(db.Warehouses.Select(w => w.NameWarehouse).ToArray());

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_code.Text) 
                || string.IsNullOrEmpty(combo_unit.Text) ||
                string.IsNullOrEmpty(combo_warehouse.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                var existingProduct = db.Products.FirstOrDefault(p => p.CodeProduct == txt_code.Text);

                if (existingProduct == null)
                {
                    existingProduct = new models.Product
                    {
                        CodeProduct = txt_code.Text,
                        nameProduct = txt_name.Text,
                        MeasurementUnit = combo_unit.Text,
                      
                        
                    };
                    db.Products.Add(existingProduct);
                    db.SaveChanges();
                }


                var existingWarehouse = db.Warehouses.FirstOrDefault(w => w.NameWarehouse == combo_warehouse.Text);

                if (existingWarehouse == null)
                {
                    existingWarehouse = new models.Warehouse
                    {
                        NameWarehouse = combo_warehouse.Text
                    };
                    db.Warehouses.Add(existingWarehouse);
                    db.SaveChanges();
                }


                var warehouseProduct = new models.WarehouseProduct
                {
                    IdProduct = existingProduct.IdProduct,
                    IdWarehouse = existingWarehouse.IdWarehouse,
                    TransactionDate = DateTime.Now,
                    Quantity= int.TryParse(txt_quntity.Text, out int quantity) ? quantity : 0

                };

                db.WarehouseProducts.Add(warehouseProduct);
                db.SaveChanges();

                MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyFields();

                btn_display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void emptyFields()
        {
            txt_code.Text = "";
            txt_name.Text = "";
           
            combo_unit.SelectedIndex = -1;
            combo_warehouse.SelectedIndex = -1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_code.Text) || 
                string.IsNullOrEmpty(combo_unit.Text) || string.IsNullOrEmpty(combo_warehouse.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            try
            {
                var existingProduct = db.Products.FirstOrDefault(p => p.CodeProduct == txt_code.Text);
                if (existingProduct == null)
                {
                    MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existingWarehouse = db.Warehouses.FirstOrDefault(w => w.NameWarehouse == combo_warehouse.Text);
                if (existingWarehouse == null)
                {
                    MessageBox.Show("Warehouse not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var warehouseProduct = db.WarehouseProducts.FirstOrDefault(wp => wp.IdProduct == existingProduct.IdProduct && wp.IdWarehouse == existingWarehouse.IdWarehouse);
                if (warehouseProduct == null)
                {
                    MessageBox.Show("Product not found in warehouse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                existingProduct.nameProduct = txt_name.Text;
                existingProduct.MeasurementUnit = combo_unit.Text;
               

                db.SaveChanges();

                MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyFields();
                btn_display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txt_code.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                combo_unit.Text = dataGridView1.Rows[e.RowIndex].Cells["MeasurementUnit"].Value.ToString();
               
                combo_warehouse.Text = dataGridView1.Rows[e.RowIndex].Cells["WarehouseName"].Value.ToString();

                txt_code.Enabled = false;
                combo_warehouse.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_code.Text) || string.IsNullOrEmpty(combo_warehouse.Text))
            {
                MessageBox.Show("Please select a product and warehouse to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                var existingProduct = db.Products.FirstOrDefault(p => p.CodeProduct == txt_code.Text);
                if (existingProduct == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var existingWarehouse = db.Warehouses.FirstOrDefault(w => w.NameWarehouse == combo_warehouse.Text);
                if (existingWarehouse == null)
                {
                    MessageBox.Show("Warehouse not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var warehouseProduct = db.WarehouseProducts.FirstOrDefault(wp => wp.IdProduct == existingProduct.IdProduct && wp.IdWarehouse == existingWarehouse.IdWarehouse);
                if (warehouseProduct == null)
                {
                    MessageBox.Show("Product not found in the selected warehouse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                db.WarehouseProducts.Remove(warehouseProduct);
                db.SaveChanges();


                bool isProductStillUsed = db.WarehouseProducts.Any(wp => wp.IdProduct == existingProduct.IdProduct);
                if (!isProductStillUsed)
                {
                    db.Products.Remove(existingProduct);
                    db.SaveChanges();
                }

                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                btn_display_Click(null, null);
                emptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Search_Click(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();

            var searchResults = db.WarehouseProducts
                .Where(wp => wp.Products.CodeProduct.Contains(searchText) ||
                             wp.Products.nameProduct.Contains(searchText) ||
                             wp.Warehouse.NameWarehouse.Contains(searchText))
                .Select(wp => new
                {
                    ProductCode = wp.Products.CodeProduct,
                    ProductName = wp.Products.nameProduct,
                    
                    WarehouseName = wp.Warehouse.NameWarehouse
                })
                .ToList();

            dataGridView1.DataSource = searchResults;
            txt_search.Text = "";   
        }
    }

}
   

