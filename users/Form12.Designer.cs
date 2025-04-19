namespace users
{
    partial class Form12
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
            combo_product = new ComboBox();
            Product = new Label();
            checkedList_warehouse = new CheckedListBox();
            label2 = new Label();
            dateTime_start = new DateTimePicker();
            dateTime_end = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            Display = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            btnExpiredProducts = new Button();
            numericUpDown1 = new NumericUpDown();
            nearExpiryProduct = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // combo_product
            // 
            combo_product.FormattingEnabled = true;
            combo_product.Location = new Point(152, 123);
            combo_product.Name = "combo_product";
            combo_product.Size = new Size(263, 28);
            combo_product.TabIndex = 0;
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product.ForeColor = Color.Teal;
            Product.Location = new Point(35, 123);
            Product.Name = "Product";
            Product.Size = new Size(83, 28);
            Product.TabIndex = 1;
            Product.Text = "Product";
            // 
            // checkedList_warehouse
            // 
            checkedList_warehouse.FormattingEnabled = true;
            checkedList_warehouse.Location = new Point(152, 167);
            checkedList_warehouse.Name = "checkedList_warehouse";
            checkedList_warehouse.Size = new Size(263, 70);
            checkedList_warehouse.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 3;
            label2.Text = "Warehouse";
            label2.Click += label2_Click;
            // 
            // dateTime_start
            // 
            dateTime_start.Location = new Point(152, 247);
            dateTime_start.Name = "dateTime_start";
            dateTime_start.Size = new Size(263, 27);
            dateTime_start.TabIndex = 4;
            // 
            // dateTime_end
            // 
            dateTime_end.Location = new Point(152, 296);
            dateTime_end.Name = "dateTime_end";
            dateTime_end.Size = new Size(263, 27);
            dateTime_end.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(30, 245);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 6;
            label3.Text = "StartDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(30, 294);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 7;
            label4.Text = "EndDate";
            // 
            // Display
            // 
            Display.BackColor = Color.Teal;
            Display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Display.ForeColor = Color.White;
            Display.Location = new Point(189, 349);
            Display.Name = "Display";
            Display.Size = new Size(129, 43);
            Display.TabIndex = 8;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = false;
            Display.Click += Display_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(443, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(352, 347);
            dataGridView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow2;
            pictureBox1.Location = new Point(12, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 430);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 15;
            label5.Text = "Go to Main Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(101, 25);
            label1.Name = "label1";
            label1.Size = new Size(227, 41);
            label1.TabIndex = 16;
            label1.Text = "Report Product";
            // 
            // btnExpiredProducts
            // 
            btnExpiredProducts.BackColor = Color.Teal;
            btnExpiredProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpiredProducts.ForeColor = Color.White;
            btnExpiredProducts.Location = new Point(829, 154);
            btnExpiredProducts.Name = "btnExpiredProducts";
            btnExpiredProducts.Size = new Size(211, 51);
            btnExpiredProducts.TabIndex = 17;
            btnExpiredProducts.Text = "Expired Product";
            btnExpiredProducts.UseVisualStyleBackColor = false;
            btnExpiredProducts.Click += btnExpiredProducts_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(829, 98);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(287, 27);
            numericUpDown1.TabIndex = 18;
            // 
            // nearExpiryProduct
            // 
            nearExpiryProduct.BackColor = Color.Teal;
            nearExpiryProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nearExpiryProduct.ForeColor = Color.White;
            nearExpiryProduct.Location = new Point(829, 222);
            nearExpiryProduct.Name = "nearExpiryProduct";
            nearExpiryProduct.Size = new Size(211, 52);
            nearExpiryProduct.TabIndex = 19;
            nearExpiryProduct.Text = "Near Expiry Products";
            nearExpiryProduct.UseVisualStyleBackColor = false;
            nearExpiryProduct.Click += nearExpiryProduct_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__3_;
            pictureBox2.Location = new Point(12, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 450);
            Controls.Add(pictureBox2);
            Controls.Add(nearExpiryProduct);
            Controls.Add(numericUpDown1);
            Controls.Add(btnExpiredProducts);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Display);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTime_end);
            Controls.Add(dateTime_start);
            Controls.Add(label2);
            Controls.Add(checkedList_warehouse);
            Controls.Add(Product);
            Controls.Add(combo_product);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_product;
        private Label Product;
        private CheckedListBox checkedList_warehouse;
        private Label label2;
        private DateTimePicker dateTime_start;
        private DateTimePicker dateTime_end;
        private Label label3;
        private Label label4;
        private Button Display;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label1;
        private Button btnExpiredProducts;
        private NumericUpDown numericUpDown1;
        private Button nearExpiryProduct;
        private PictureBox pictureBox2;
    }
}