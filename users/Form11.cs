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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

            using (var db = new ITIProjectContext())
            {
                
                combo_warehouse.DataSource = db.Warehouses.ToList();
                combo_warehouse.DisplayMember = "NameWarehouse"; 
                combo_warehouse.ValueMember = "IdWarehouse";     
                combo_warehouse.SelectedIndex = -1;              
            }

        }

        private void select_Click(object sender, EventArgs e)
        {
            if (combo_warehouse.SelectedIndex == -1)
            {
                MessageBox.Show("Should choose Warehouse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startDate = dateTime_start.Value;
            DateTime endDate = dateTime_end.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be before end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedWarehouseId = (int)combo_warehouse.SelectedValue;

            using (var db = new ITIProjectContext())
            {

                var reportData = db.SupplyOrders
                    .Where(so => so.WarehouseId == selectedWarehouseId &&
                                 so.PermissionDate >= startDate &&
                                 so.PermissionDate <= endDate)
                    .Include(so => so.Supplier)  
                    .Include(so => so.Items)     
                    .ThenInclude(item => item.Product)
                    .Select(so => new
                    {
                        so.PermissionNumber,
                        so.PermissionDate,
                        SupplierName = so.Supplier.NameSupplier,
                        Products = string.Join(", ", so.Items.Select(item => item.Product.nameProduct)), 
                    })
                    .ToList();


                dataGridView1.DataSource = reportData;
            }
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
    }
}
