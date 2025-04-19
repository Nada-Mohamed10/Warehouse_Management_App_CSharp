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
    public partial class Form7 : Form
    {
        ITIProjectContext db;
        public Form7()
        {

            InitializeComponent();
            db = new ITIProjectContext();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {

            var supplierList = db.Suppliers
          .Select(c => new
          {

              Name = c.NameSupplier,
              Mobile = c.MobileSupplier,
              Phone = c.PhoneSupplier,
              Fax = c.FaxSupplier,
              Email = c.EmailSupplier,
              Website = c.WebsiteSupplierr
          })
          .ToList();

            dataGridView1.DataSource = supplierList;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_mobile.Text) || string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(txt_fax.Text) || string.IsNullOrEmpty(txt_website.Text) || string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            var existingCustomer = db.Suppliers.FirstOrDefault(c => c.MobileSupplier == txt_mobile.Text);
            if (existingCustomer != null)
            {
                MessageBox.Show("Customer already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newsupplier = new models.Supplier
            {
                NameSupplier = txt_name.Text,
                MobileSupplier = txt_mobile.Text,
                PhoneSupplier = txt_phone.Text,
                FaxSupplier = txt_fax.Text,
                EmailSupplier = txt_email.Text,
                WebsiteSupplierr = txt_website.Text
            };

            db.Suppliers.Add(newsupplier);
            db.SaveChanges();
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            emptyFields();
            btn_display_Click(null, null);
        }

        public void emptyFields()
        {
            txt_name.Text = "";
            txt_mobile.Text = "";
            txt_phone.Text = "";
            txt_fax.Text = "";
            txt_email.Text = "";
            txt_website.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_mobile.Text) ||
               string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(txt_fax.Text) ||
              string.IsNullOrEmpty(txt_website.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                var existingSupplier = db.Suppliers.FirstOrDefault(c => c.MobileSupplier == txt_mobile.Text || c.EmailSupplier == txt_email.Text);

                if (existingSupplier == null)
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                existingSupplier.NameSupplier = txt_name.Text;
                existingSupplier.MobileSupplier = txt_phone.Text;
                existingSupplier.FaxSupplier = txt_fax.Text;
                existingSupplier.EmailSupplier = txt_email.Text;
                existingSupplier.WebsiteSupplierr = txt_website.Text;

                db.SaveChanges();

                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_fax.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_website.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mobile.Text))
            {
                MessageBox.Show("Please enter mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var existingSupplier = db.Suppliers.FirstOrDefault(c => c.MobileSupplier == txt_mobile.Text);
                if (existingSupplier == null)
                {
                    MessageBox.Show("Supplier not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Suppliers.Remove(existingSupplier);
                db.SaveChanges();
                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyFields();
                btn_display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            var searchResult = txt_search.Text.Trim();

            if (string.IsNullOrEmpty(searchResult))
            {
                MessageBox.Show("Please enter a search term!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var searchResults = db.Suppliers
                    .Where(c => c.NameSupplier.Contains(searchResult) ||
                                c.MobileSupplier.Contains(searchResult) ||
                                c.PhoneSupplier.Contains(searchResult) ||
                                c.EmailSupplier.Contains(searchResult))


                    .Select(c => new
                    {

                        Name = c.NameSupplier,
                        Mobile = c.MobileSupplier,
                        Phone = c.PhoneSupplier,
                        Fax = c.FaxSupplier,
                        Email = c.EmailSupplier,
                        Website = c.WebsiteSupplierr
                    })
                    .ToList();

                if (searchResults.Any())
                {
                    dataGridView1.DataSource = searchResults;
                    txt_search.Text = " ";
                }
                else
                {
                    MessageBox.Show("No matching customers found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
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

        private void openForm()
        {
            Application.Run(new Form3());
        }

        
    }
}
