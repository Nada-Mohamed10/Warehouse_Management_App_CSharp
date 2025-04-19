namespace users
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            Users = new ToolStripMenuItem();
            Login = new ToolStripMenuItem();
            Register = new ToolStripMenuItem();
            warehouseToolStripMenuItem = new ToolStripMenuItem();
            addNewWarehouseToolStripMenuItem = new ToolStripMenuItem();
            deleteWarehouseToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addNewProductToolStripMenuItem = new ToolStripMenuItem();
            manageProductToolStripMenuItem = new ToolStripMenuItem();
            displayProductToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            invoiceToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            warehouseToolStripMenuItem1 = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            btn_warehouse = new Button();
            btn_Product = new Button();
            button3 = new Button();
            btn_supplier = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Users, warehouseToolStripMenuItem, productsToolStripMenuItem, customerToolStripMenuItem, suppliersToolStripMenuItem, invoiceToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(943, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Users
            // 
            Users.DropDownItems.AddRange(new ToolStripItem[] { Login, Register });
            Users.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Users.Image = Properties.Resources.rating1;
            Users.Name = "Users";
            Users.Size = new Size(96, 32);
            Users.Text = "Users";
            // 
            // Login
            // 
            Login.Image = Properties.Resources.user__1_;
            Login.Name = "Login";
            Login.Size = new Size(171, 32);
            Login.Text = "Login ";
            Login.Click += Login_Click;
            // 
            // Register
            // 
            Register.Image = Properties.Resources.user;
            Register.Name = "Register";
            Register.Size = new Size(171, 32);
            Register.Text = "Register";
            Register.Click += Register_Click;
            // 
            // warehouseToolStripMenuItem
            // 
            warehouseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewWarehouseToolStripMenuItem, deleteWarehouseToolStripMenuItem });
            warehouseToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            warehouseToolStripMenuItem.Image = Properties.Resources.warehouse__1_;
            warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            warehouseToolStripMenuItem.Size = new Size(148, 32);
            warehouseToolStripMenuItem.Text = "Warehouse";
            warehouseToolStripMenuItem.Click += warehouseToolStripMenuItem_Click;
            // 
            // addNewWarehouseToolStripMenuItem
            // 
            addNewWarehouseToolStripMenuItem.Name = "addNewWarehouseToolStripMenuItem";
            addNewWarehouseToolStripMenuItem.Size = new Size(86, 26);
            // 
            // deleteWarehouseToolStripMenuItem
            // 
            deleteWarehouseToolStripMenuItem.Name = "deleteWarehouseToolStripMenuItem";
            deleteWarehouseToolStripMenuItem.Size = new Size(86, 26);
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewProductToolStripMenuItem, manageProductToolStripMenuItem, displayProductToolStripMenuItem });
            productsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsToolStripMenuItem.Image = Properties.Resources.download__1_;
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(126, 32);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // addNewProductToolStripMenuItem
            // 
            addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            addNewProductToolStripMenuItem.Size = new Size(86, 26);
            // 
            // manageProductToolStripMenuItem
            // 
            manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            manageProductToolStripMenuItem.Size = new Size(86, 26);
            // 
            // displayProductToolStripMenuItem
            // 
            displayProductToolStripMenuItem.Name = "displayProductToolStripMenuItem";
            displayProductToolStripMenuItem.Size = new Size(86, 26);
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerToolStripMenuItem.ForeColor = Color.Black;
            customerToolStripMenuItem.Image = Properties.Resources.service1;
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(143, 32);
            customerToolStripMenuItem.Text = "Customers";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suppliersToolStripMenuItem.Image = Properties.Resources.download__1_3;
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(130, 32);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // invoiceToolStripMenuItem
            // 
            invoiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplierToolStripMenuItem, customerToolStripMenuItem1 });
            invoiceToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceToolStripMenuItem.ForeColor = Color.Black;
            invoiceToolStripMenuItem.Image = Properties.Resources.inventory1;
            invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            invoiceToolStripMenuItem.Size = new Size(145, 32);
            invoiceToolStripMenuItem.Text = "Permission";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(186, 32);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem1
            // 
            customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            customerToolStripMenuItem1.Size = new Size(186, 32);
            customerToolStripMenuItem1.Text = "Customer";
            customerToolStripMenuItem1.Click += customerToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { warehouseToolStripMenuItem1, reportToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = Color.Black;
            toolStripMenuItem1.Image = Properties.Resources.download__2_;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(107, 32);
            toolStripMenuItem1.Text = "Report";
            // 
            // warehouseToolStripMenuItem1
            // 
            warehouseToolStripMenuItem1.Name = "warehouseToolStripMenuItem1";
            warehouseToolStripMenuItem1.Size = new Size(200, 32);
            warehouseToolStripMenuItem1.Text = "Warehouse";
            warehouseToolStripMenuItem1.Click += warehouseToolStripMenuItem1_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(200, 32);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // btn_warehouse
            // 
            btn_warehouse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_warehouse.ForeColor = Color.Teal;
            btn_warehouse.Location = new Point(550, 89);
            btn_warehouse.Name = "btn_warehouse";
            btn_warehouse.Size = new Size(154, 44);
            btn_warehouse.TabIndex = 1;
            btn_warehouse.Text = "Warehouse";
            btn_warehouse.UseVisualStyleBackColor = true;
            btn_warehouse.Click += btn_warehouse_Click;
            // 
            // btn_Product
            // 
            btn_Product.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Product.ForeColor = Color.Teal;
            btn_Product.Location = new Point(710, 89);
            btn_Product.Name = "btn_Product";
            btn_Product.Size = new Size(154, 44);
            btn_Product.TabIndex = 3;
            btn_Product.Text = "Product";
            btn_Product.UseVisualStyleBackColor = true;
            btn_Product.Click += btn_Product_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Teal;
            button3.Location = new Point(550, 139);
            button3.Name = "button3";
            button3.Size = new Size(154, 44);
            button3.TabIndex = 4;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_supplier
            // 
            btn_supplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_supplier.ForeColor = Color.Teal;
            btn_supplier.Location = new Point(710, 139);
            btn_supplier.Name = "btn_supplier";
            btn_supplier.Size = new Size(154, 44);
            btn_supplier.TabIndex = 5;
            btn_supplier.Text = "Suppliers";
            btn_supplier.UseVisualStyleBackColor = true;
            btn_supplier.Click += btn_supplier_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Teal;
            button5.Location = new Point(550, 189);
            button5.Name = "button5";
            button5.Size = new Size(154, 65);
            button5.TabIndex = 6;
            button5.Text = "Permission Supplier";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Teal;
            button6.Location = new Point(710, 189);
            button6.Name = "button6";
            button6.Size = new Size(154, 65);
            button6.TabIndex = 7;
            button6.Text = "Premission Withdrawal";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.warehouse_outside_concept_illustration_114360_15740;
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(550, 260);
            button1.Name = "button1";
            button1.Size = new Size(154, 66);
            button1.TabIndex = 8;
            button1.Text = "Transfer Warehouse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(710, 260);
            button2.Name = "button2";
            button2.Size = new Size(154, 66);
            button2.TabIndex = 9;
            button2.Text = "Report Warehouse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(632, 332);
            button4.Name = "button4";
            button4.Size = new Size(174, 51);
            button4.TabIndex = 10;
            button4.Text = "Report Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(943, 395);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btn_supplier);
            Controls.Add(button3);
            Controls.Add(btn_Product);
            Controls.Add(pictureBox1);
            Controls.Add(btn_warehouse);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Teal;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem Login;
        private ToolStripMenuItem warehouseToolStripMenuItem;
        private ToolStripMenuItem addNewWarehouseToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addNewProductToolStripMenuItem;
        private ToolStripMenuItem deleteWarehouseToolStripMenuItem;
        private ToolStripMenuItem manageProductToolStripMenuItem;
        private ToolStripMenuItem displayProductToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem invoiceToolStripMenuItem;
        private Button btn_warehouse;
        private Button btn_Product;
        private Button button3;
        private Button btn_supplier;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem Register;
        private Button button1;
        private Button button2;
        private Button button4;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem1;
        private ToolStripMenuItem warehouseToolStripMenuItem1;
        private ToolStripMenuItem reportToolStripMenuItem;
    }
}