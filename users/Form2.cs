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
    public partial class Form2 : Form
    {
        ITIProjectContext db;
        public Form2()
        {
            InitializeComponent();
            db= new ITIProjectContext();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_newPassword.UseSystemPasswordChar = true;
            txt_confirmPassword.UseSystemPasswordChar = true;
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_newName.Text) || string.IsNullOrEmpty(txt_newPassword.Text) || string.IsNullOrEmpty(txt_confirmPassword.Text) )
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var user = new User()
                {
                    name = txt_newName.Text,
                    password = txt_newPassword.Text,
                    confirmPassword= txt_confirmPassword.Text

                };
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            
            this.Close();
            Thread thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
            
        }

         public void openForm()
        {
            Application.Run(new Form3());
        }


    }

}
