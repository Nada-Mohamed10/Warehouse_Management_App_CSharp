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
    public partial class Form12 : Form
    {
        ITIProjectContext db;
        public Form12()
        {
            InitializeComponent();
            db = new ITIProjectContext();
        }

        private void Form12_Load(object sender, EventArgs e)
        {



            combo_product.DataSource = db.Products.ToList();
            combo_product.DisplayMember = "nameProduct";
            combo_product.ValueMember = "IdProduct";
            combo_product.SelectedIndex = -1;

            checkedList_warehouse.Items.Clear();
            var warehouses = db.Warehouses.ToList();

            foreach (var warehouse in warehouses)
            {
                checkedList_warehouse.Items.Add(warehouse.NameWarehouse, false);
            }

        }

        private void Display_Click(object sender, EventArgs e)

        {

            if (!db.WarehouseProducts.Any())
            {
                MessageBox.Show("No data found in WarehouseProducts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combo_product.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startDate = dateTime_start.Value;
            DateTime endDate = dateTime_end.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Start Date should not be greater than End Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedProductId = (int)combo_product.SelectedValue;

         
            List<string> selectedWarehouseNames = checkedList_warehouse.CheckedItems.Cast<string>().ToList();

           
            List<int> selectedWarehouseIds = db.Warehouses
                .Where(w => selectedWarehouseNames.Contains(w.NameWarehouse))
                .Select(w => w.IdWarehouse)
                .ToList();

            var query = db.WarehouseProducts
                .Where(wp => wp.IdProduct == selectedProductId &&
                  wp.TransactionDate >= startDate &&
                    wp.TransactionDate <= endDate);

            if (selectedWarehouseIds.Any())
            {
                query = query.Where(wp => selectedWarehouseIds.Contains(wp.IdWarehouse));
            }

            var reportData = query
                .Include(wp => wp.Warehouse)
                .Include(wp => wp.Products)
                .Select(wp => new
                {
                    Warehouse = wp.Warehouse.NameWarehouse,
                    ProductName = wp.Products.nameProduct,
                    Quantity = wp.Quantity,
                    // TransactionDate = wp.TransactionDate
                })
                .ToList();

            dataGridView1.DataSource = reportData;
            dataGridView1.Refresh();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnExpiredProducts_Click(object sender, EventArgs e)
        {
            int months = (int)numericUpDown1.Value;
            DateTime thresholdDate = DateTime.Now.AddMonths(-months);
            using (var db = new ITIProjectContext())
            {
                var expiredItems = db.WarehouseProducts
                    .Where(wp => wp.TransactionDate <= thresholdDate)
                    .Include(wp => wp.Warehouse)
                    .Include(wp => wp.Products)
                    .Select(wp => new
                    {
                        Warehouse = wp.Warehouse.NameWarehouse,
                        ProductName = wp.Products.nameProduct,
                        Quantity = wp.Quantity,
                        StoredDate = wp.TransactionDate
                    })
                    .ToList();

                dataGridView1.DataSource = expiredItems;
            }
        }

        private void nearExpiryProduct_Click(object sender, EventArgs e)
        {
            int months = (int)numericUpDown1.Value; 
            DateTime expiryThreshold = DateTime.Now.AddMonths(months); 

            using (var db = new ITIProjectContext())
            {
                var nearExpiryItems = db.WarehouseProducts
                    .Join(db.SupplyOrderItems,
                        wp => wp.IdProduct,
                        soi => soi.IdProduct,
                        (wp, soi) => new { wp, soi })
                    .Join(db.SupplyOrders,
                        joined => joined.soi.SupplyOrderId,
                        so => so.Id,
                        (joined, so) => new { joined.wp, joined.soi, so })
                    .Where(joined => joined.so.ExpiryDate <= expiryThreshold) 
                    .Select(joined => new
                    {
                        Warehouse = joined.wp.Warehouse.NameWarehouse,
                        ProductName = joined.wp.Products.nameProduct,
                        Quantity = joined.wp.Quantity,
                        ExpiryDate = joined.so.ExpiryDate
                    })
                    .ToList();

                dataGridView1.DataSource = nearExpiryItems;
            }
        }
    }
}


