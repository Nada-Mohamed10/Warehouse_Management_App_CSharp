namespace users
{
    partial class Form8
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
            label1 = new Label();
            label2 = new Label();
            txt_number = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTime_Date = new DateTimePicker();
            dateTime_production = new DateTimePicker();
            dateTime_Expiry = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            combo_warehouse = new ComboBox();
            combo_supplier = new ComboBox();
            combo_product = new ComboBox();
            label8 = new Label();
            btn_display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dataGridView1 = new DataGridView();
            dgvItems = new DataGridView();
            additem = new Button();
            btn_updateitem = new Button();
            btn_deleteitem = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(102, 21);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 0;
            label1.Text = "Supplier premession";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(10, 85);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 1;
            label2.Text = "PermissionNumber";
            // 
            // txt_number
            // 
            txt_number.Location = new Point(204, 89);
            txt_number.Name = "txt_number";
            txt_number.Size = new Size(287, 27);
            txt_number.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(13, 121);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 3;
            label3.Text = "PermissionDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(13, 165);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 4;
            label4.Text = "ProductionDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(13, 197);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 5;
            label5.Text = "ExpiryDate";
            // 
            // dateTime_Date
            // 
            dateTime_Date.Location = new Point(204, 122);
            dateTime_Date.Name = "dateTime_Date";
            dateTime_Date.Size = new Size(287, 27);
            dateTime_Date.TabIndex = 6;
            // 
            // dateTime_production
            // 
            dateTime_production.Location = new Point(203, 165);
            dateTime_production.Name = "dateTime_production";
            dateTime_production.Size = new Size(288, 27);
            dateTime_production.TabIndex = 7;
            // 
            // dateTime_Expiry
            // 
            dateTime_Expiry.Location = new Point(203, 198);
            dateTime_Expiry.Name = "dateTime_Expiry";
            dateTime_Expiry.Size = new Size(288, 27);
            dateTime_Expiry.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(13, 227);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 9;
            label6.Text = "Warehouse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(13, 261);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 10;
            label7.Text = "Supplier";
            // 
            // combo_warehouse
            // 
            combo_warehouse.FormattingEnabled = true;
            combo_warehouse.Location = new Point(203, 231);
            combo_warehouse.Name = "combo_warehouse";
            combo_warehouse.Size = new Size(288, 28);
            combo_warehouse.TabIndex = 11;
            // 
            // combo_supplier
            // 
            combo_supplier.FormattingEnabled = true;
            combo_supplier.Location = new Point(205, 265);
            combo_supplier.Name = "combo_supplier";
            combo_supplier.Size = new Size(288, 28);
            combo_supplier.TabIndex = 12;
            // 
            // combo_product
            // 
            combo_product.FormattingEnabled = true;
            combo_product.Location = new Point(205, 299);
            combo_product.Name = "combo_product";
            combo_product.Size = new Size(289, 28);
            combo_product.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(17, 295);
            label8.Name = "label8";
            label8.Size = new Size(83, 28);
            label8.TabIndex = 15;
            label8.Text = "Product";
            // 
            // btn_display
            // 
            btn_display.BackColor = Color.Teal;
            btn_display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_display.ForeColor = Color.White;
            btn_display.Location = new Point(226, 371);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(105, 41);
            btn_display.TabIndex = 17;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = false;
            btn_display.Click += btn_display_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(337, 371);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(105, 41);
            btn_add.TabIndex = 18;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(226, 418);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(105, 41);
            btn_update.TabIndex = 19;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(337, 418);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(105, 41);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(848, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(534, 364);
            dataGridView1.TabIndex = 21;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(567, 89);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(230, 246);
            dgvItems.TabIndex = 22;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            dgvItems.RowHeaderMouseDoubleClick += dgvItems_RowHeaderMouseDoubleClick;
            // 
            // additem
            // 
            additem.BackColor = Color.Teal;
            additem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            additem.ForeColor = Color.White;
            additem.Location = new Point(537, 341);
            additem.Name = "additem";
            additem.Size = new Size(141, 50);
            additem.TabIndex = 23;
            additem.Text = "Add Item";
            additem.UseVisualStyleBackColor = false;
            additem.Click += additem_Click;
            // 
            // btn_updateitem
            // 
            btn_updateitem.BackColor = Color.Teal;
            btn_updateitem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_updateitem.ForeColor = Color.White;
            btn_updateitem.Location = new Point(684, 341);
            btn_updateitem.Name = "btn_updateitem";
            btn_updateitem.Size = new Size(141, 50);
            btn_updateitem.TabIndex = 24;
            btn_updateitem.Text = "Update Item";
            btn_updateitem.UseVisualStyleBackColor = false;
            btn_updateitem.Click += btn_updateitem_Click;
            // 
            // btn_deleteitem
            // 
            btn_deleteitem.BackColor = Color.Teal;
            btn_deleteitem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_deleteitem.ForeColor = Color.White;
            btn_deleteitem.Location = new Point(607, 406);
            btn_deleteitem.Name = "btn_deleteitem";
            btn_deleteitem.Size = new Size(141, 53);
            btn_deleteitem.TabIndex = 25;
            btn_deleteitem.Text = "Delete Item";
            btn_deleteitem.UseVisualStyleBackColor = false;
            btn_deleteitem.Click += btn_deleteitem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow1;
            pictureBox1.Location = new Point(17, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 456);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 27;
            label10.Text = "Go to Main Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.inventory;
            pictureBox2.Location = new Point(17, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 485);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(btn_deleteitem);
            Controls.Add(btn_updateitem);
            Controls.Add(additem);
            Controls.Add(dgvItems);
            Controls.Add(dataGridView1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(label8);
            Controls.Add(combo_product);
            Controls.Add(combo_supplier);
            Controls.Add(combo_warehouse);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTime_Expiry);
            Controls.Add(dateTime_production);
            Controls.Add(dateTime_Date);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_number);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_number;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTime_Date;
        private DateTimePicker dateTime_production;
        private DateTimePicker dateTime_Expiry;
        private Label label6;
        private Label label7;
        private ComboBox combo_warehouse;
        private ComboBox combo_supplier;
        private ComboBox combo_product;
        private Label label8;
        private Button btn_display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dataGridView1;
        private DataGridView dgvItems;
        private Button additem;
        private Button btn_updateitem;
        private Button btn_deleteitem;
        private PictureBox pictureBox1;
        private Label label10;
        private PictureBox pictureBox2;
    }
}