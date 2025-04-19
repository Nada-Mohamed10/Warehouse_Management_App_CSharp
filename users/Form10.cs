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
    public partial class Form10 : Form
    {
        ITIProjectContext db;
        private List<TransferProduct> transferItems;


        public Form10()
        {

            InitializeComponent();
            db = new ITIProjectContext();
            transferItems = new List<TransferProduct>();




        }



        private void Form10_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btn_transfar_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new ITIProjectContext())
                {
                    int fromWarehouseId = (int)combo_source_warehouse.SelectedValue;
                    int toWarehouseId = (int)combo_destination_warehouse.SelectedValue;
                    int productId = (int)combo_product.SelectedValue;
                    int quantity = int.Parse(text_quantity.Text);


                    if (combo_supplier.SelectedValue == null)
                    {
                        MessageBox.Show(" Please select a supplier!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int supplierId = (int)combo_supplier.SelectedValue;


                    var sourceStock = db.WarehouseProducts
                                        .FirstOrDefault(wp => wp.IdWarehouse == fromWarehouseId && wp.IdProduct == productId);

                    if (sourceStock == null || sourceStock.Quantity < quantity)
                    {
                        MessageBox.Show("Not enough quantity in the source warehouse!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    sourceStock.Quantity -= quantity;


                    var destinationStock = db.WarehouseProducts
                                            .FirstOrDefault(wp => wp.IdWarehouse == toWarehouseId && wp.IdProduct == productId);

                    if (destinationStock == null)
                    {
                        db.WarehouseProducts.Add(new WarehouseProduct
                        {
                            IdWarehouse = toWarehouseId,
                            IdProduct = productId,
                            Quantity = quantity
                        });
                    }
                    else
                    {
                        destinationStock.Quantity += quantity;
                    }


                    var transferProduct = new TransferProduct
                    {
                        FromWarehouseId = fromWarehouseId,
                        ToWarehouseId = toWarehouseId,
                        ProductId = productId,
                        SupplierId = supplierId,
                        Quantity = quantity,
                        ProductionDate = dateTime_production.Value,
                        ExpiryDate = dateTime_expiry.Value,
                        TransferDate = DateTime.Now
                    };

                    db.transferProducts.Add(transferProduct);
                    db.SaveChanges();

                    MessageBox.Show("Item transferred and stock updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during transfer:\n{ex.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadData()
        {
            using (var db = new ITIProjectContext())
            {
                combo_source_warehouse.DataSource = db.Warehouses.ToList();
                combo_source_warehouse.DisplayMember = "NameWarehouse";
                combo_source_warehouse.ValueMember = "IdWarehouse";
                combo_source_warehouse.SelectedIndex = -1;

                combo_destination_warehouse.DataSource = db.Warehouses.ToList();
                combo_destination_warehouse.DisplayMember = "NameWarehouse";
                combo_destination_warehouse.ValueMember = "IdWarehouse";
                combo_destination_warehouse.SelectedIndex = -1;

                combo_product.DataSource = db.Products.ToList();
                combo_product.DisplayMember = "nameProduct";
                combo_product.ValueMember = "IdProduct";
                combo_product.SelectedIndex = -1;

                combo_supplier.DataSource = db.Suppliers.ToList();
                combo_supplier.DisplayMember = "NameSupplier";
                combo_supplier.ValueMember = "IdSupplier";
                combo_supplier.SelectedIndex = -1;
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

        private void btn_report_Click(object sender, EventArgs e)
        {

            var reportData = (from tp in db.transferProducts
                             join p in db.Products on tp.ProductId equals p.IdProduct
                             join s in db.Suppliers on tp.SupplierId equals s.IdSupplier
                             select new
                             {
                                 From_Warehouse = tp.FromWarehouse.NameWarehouse,
                                 To_Warehouse = tp.ToWarehouse.NameWarehouse,
                                 Product_Name = p.nameProduct,       
                                 Supplier_Name = s.NameSupplier,    
                                 tp.Quantity,
                                 tp.ProductionDate,
                                 tp.ExpiryDate,
                                 tp.TransferDate
                             }).ToList();

            dataGridView1.DataSource = reportData;

        }
    }
}
