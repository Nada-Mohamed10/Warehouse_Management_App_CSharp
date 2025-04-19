using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace users
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Warehouse);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void btn_Product_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Product);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Customer);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void btn_supplier_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Supplier);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openForm_Warehouse()
        {
            Application.Run(new Warehouse());
        }
        private void openForm_Product()
        {
            Application.Run(new Form5());
        }

        private void openForm_Customer()
        {
            Application.Run(new Form6());
        }
        private void openForm_Supplier()
        {
            Application.Run(new Form7());
        }
        private void openForm_Login()
        {
            Application.Run(new Form1());
        }
        private void openForm_Register()
        {
            Application.Run(new Form2());
        }
        private void openForm_Permission()
        {
            Application.Run(new Form8());
        }
        private void openForm_Permission2()
        {
            Application.Run(new Form9());
        }
        private void opeenForm_Transformation()
        {
            Application.Run(new Form10());
        }
        private void openForm_Report()
        {
            Application.Run(new Form11());
        }
        private void openForm_Report2()
        {
            Application.Run(new Form12());
        }
        private void Login_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Login);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Register);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Permission);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Permission2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(opeenForm_Transformation);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Report);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openForm_Report2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_warehouse_Click(null, null);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Product_Click(null, null);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(null, null);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_supplier_Click(null, null);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5_Click(null, null);
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button6_Click(null, null);
        }

        private void warehouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(null, null);
        }
    }



}
