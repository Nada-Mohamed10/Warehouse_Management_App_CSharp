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
    public partial class Form6 : Form
    {
        ITIProjectContext db;
        public Form6()
        {
            InitializeComponent();
            db = new ITIProjectContext();
        }

        private void txt_display_Click(object sender, EventArgs e)
        {

            var customerList = db.Customers
           .Select(c => new
           {
               
               Name = c.NameCustomer,
               Mobile = c.MobileCustomer,
               Phone = c.PhoneCustomer,
               Fax = c.FaxCustomer,
               Email = c.EmailCustomer,
               Website = c.WebsiteCustomer
           })
           .ToList();

            dataGridView1.DataSource = customerList;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_mobile.Text) || string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(txt_fax.Text) || string.IsNullOrEmpty(txt_website.Text) || string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            var existingCustomer = db.Customers.FirstOrDefault(c => c.MobileCustomer == txt_mobile.Text);
            if (existingCustomer != null)
            {
                MessageBox.Show("Customer already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newCustomer = new models.Customer
            {
                NameCustomer = txt_name.Text,
                MobileCustomer = txt_mobile.Text,
                PhoneCustomer = txt_phone.Text,
                FaxCustomer = txt_fax.Text,
                EmailCustomer = txt_email.Text,
                WebsiteCustomer = txt_website.Text
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            emptyFields();
            txt_display_Click(null, null);
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

                var existingCustomer = db.Customers.FirstOrDefault(c => c.MobileCustomer == txt_mobile.Text);

                if (existingCustomer == null)
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                existingCustomer.NameCustomer = txt_name.Text;
                existingCustomer.MobileCustomer = txt_phone.Text;
                existingCustomer.FaxCustomer = txt_fax.Text;
                existingCustomer.WebsiteCustomer = txt_website.Text;

                db.SaveChanges();

                MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                emptyFields();
                txt_display_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                var existingCustomer = db.Customers.FirstOrDefault(c => c.MobileCustomer == txt_mobile.Text);
                if (existingCustomer == null)
                {
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Customers.Remove(existingCustomer);
                db.SaveChanges();
                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyFields();
                txt_display_Click(null, null);
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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_fax.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_website.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var searchResult=txt_search.Text.Trim();

            if (string.IsNullOrEmpty(searchResult))
            {
                MessageBox.Show("Please enter a search term!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var searchResults = db.Customers
                    .Where(c => c.NameCustomer.Contains(searchResult) ||
                                c.MobileCustomer.Contains(searchResult) ||
                                c.PhoneCustomer.Contains(searchResult)||
                                c.EmailCustomer.Contains(searchResult)) 


                    .Select(c => new
                    {
                       
                        Name = c.NameCustomer,
                        Mobile = c.MobileCustomer,
                        Phone = c.PhoneCustomer,
                        Fax = c.FaxCustomer,
                        Email = c.EmailCustomer,
                        Website = c.WebsiteCustomer
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
    }
}
 