namespace users
{
    partial class Form10
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            combo_source_warehouse = new ComboBox();
            combo_destination_warehouse = new ComboBox();
            combo_product = new ComboBox();
            combo_supplier = new ComboBox();
            text_quantity = new TextBox();
            dateTime_expiry = new DateTimePicker();
            dateTime_production = new DateTimePicker();
            btn_transfar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            btn_report = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(228, 41);
            label1.TabIndex = 0;
            label1.Text = "Transformation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 1;
            label2.Text = "Source Warehouse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(18, 144);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 2;
            label3.Text = "Destination Warehouse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(50, 178);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 3;
            label4.Text = "Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(50, 212);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(53, 249);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 5;
            label6.Text = "Supplier";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(40, 314);
            label7.Name = "label7";
            label7.Size = new Size(160, 28);
            label7.TabIndex = 6;
            label7.Text = "Production Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(40, 283);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 7;
            label8.Text = "Expiry Date";
            // 
            // combo_source_warehouse
            // 
            combo_source_warehouse.FormattingEnabled = true;
            combo_source_warehouse.Location = new Point(261, 114);
            combo_source_warehouse.Name = "combo_source_warehouse";
            combo_source_warehouse.Size = new Size(311, 28);
            combo_source_warehouse.TabIndex = 8;
            // 
            // combo_destination_warehouse
            // 
            combo_destination_warehouse.FormattingEnabled = true;
            combo_destination_warehouse.Location = new Point(261, 148);
            combo_destination_warehouse.Name = "combo_destination_warehouse";
            combo_destination_warehouse.Size = new Size(311, 28);
            combo_destination_warehouse.TabIndex = 9;
            // 
            // combo_product
            // 
            combo_product.FormattingEnabled = true;
            combo_product.Location = new Point(261, 182);
            combo_product.Name = "combo_product";
            combo_product.Size = new Size(311, 28);
            combo_product.TabIndex = 10;
            // 
            // combo_supplier
            // 
            combo_supplier.FormattingEnabled = true;
            combo_supplier.Location = new Point(261, 249);
            combo_supplier.Name = "combo_supplier";
            combo_supplier.Size = new Size(311, 28);
            combo_supplier.TabIndex = 11;
            // 
            // text_quantity
            // 
            text_quantity.Location = new Point(261, 216);
            text_quantity.Name = "text_quantity";
            text_quantity.Size = new Size(311, 27);
            text_quantity.TabIndex = 12;
            // 
            // dateTime_expiry
            // 
            dateTime_expiry.Location = new Point(261, 283);
            dateTime_expiry.Name = "dateTime_expiry";
            dateTime_expiry.Size = new Size(311, 27);
            dateTime_expiry.TabIndex = 13;
            // 
            // dateTime_production
            // 
            dateTime_production.Location = new Point(261, 316);
            dateTime_production.Name = "dateTime_production";
            dateTime_production.Size = new Size(311, 27);
            dateTime_production.TabIndex = 14;
            // 
            // btn_transfar
            // 
            btn_transfar.BackColor = Color.Teal;
            btn_transfar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_transfar.ForeColor = Color.White;
            btn_transfar.Location = new Point(342, 369);
            btn_transfar.Name = "btn_transfar";
            btn_transfar.Size = new Size(105, 41);
            btn_transfar.TabIndex = 20;
            btn_transfar.Text = "Transfar";
            btn_transfar.UseVisualStyleBackColor = false;
            btn_transfar.Click += btn_transfar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.data_transformation;
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.left_arrow1;
            pictureBox2.Location = new Point(18, 369);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(595, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 227);
            dataGridView1.TabIndex = 27;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.Teal;
            btn_report.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_report.ForeColor = Color.White;
            btn_report.Location = new Point(847, 369);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(214, 48);
            btn_report.TabIndex = 29;
            btn_report.Text = "Display Report";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 450);
            Controls.Add(btn_report);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_transfar);
            Controls.Add(dateTime_production);
            Controls.Add(dateTime_expiry);
            Controls.Add(text_quantity);
            Controls.Add(combo_supplier);
            Controls.Add(combo_product);
            Controls.Add(combo_destination_warehouse);
            Controls.Add(combo_source_warehouse);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox combo_source_warehouse;
        private ComboBox combo_destination_warehouse;
        private ComboBox combo_product;
        private ComboBox combo_supplier;
        private TextBox text_quantity;
        private DateTimePicker dateTime_expiry;
        private DateTimePicker dateTime_production;
        private Button btn_transfar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button btn_report;
    }
}