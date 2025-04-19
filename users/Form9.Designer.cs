namespace users
{
    partial class Form9
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
            combo_warehouse = new ComboBox();
            combo_customer = new ComboBox();
            text_number = new TextBox();
            dateTime_premission = new DateTimePicker();
            btn_display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(86, 22);
            label1.Name = "label1";
            label1.Size = new Size(277, 35);
            label1.TabIndex = 0;
            label1.Text = "Withdrawal Permission";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 1;
            label2.Text = "Warehouse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(25, 133);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(3, 180);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 3;
            label4.Text = "Permission Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 238);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 4;
            label5.Text = "Permission Date";
            // 
            // combo_warehouse
            // 
            combo_warehouse.FormattingEnabled = true;
            combo_warehouse.Location = new Point(209, 85);
            combo_warehouse.Name = "combo_warehouse";
            combo_warehouse.Size = new Size(282, 28);
            combo_warehouse.TabIndex = 5;
            // 
            // combo_customer
            // 
            combo_customer.FormattingEnabled = true;
            combo_customer.Location = new Point(209, 133);
            combo_customer.Name = "combo_customer";
            combo_customer.Size = new Size(282, 28);
            combo_customer.TabIndex = 6;
            // 
            // text_number
            // 
            text_number.Location = new Point(209, 184);
            text_number.Name = "text_number";
            text_number.Size = new Size(282, 27);
            text_number.TabIndex = 8;
            // 
            // dateTime_premission
            // 
            dateTime_premission.Location = new Point(209, 240);
            dateTime_premission.Name = "dateTime_premission";
            dateTime_premission.Size = new Size(282, 27);
            dateTime_premission.TabIndex = 9;
            // 
            // btn_display
            // 
            btn_display.BackColor = Color.Teal;
            btn_display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_display.ForeColor = Color.White;
            btn_display.Location = new Point(209, 297);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(109, 46);
            btn_display.TabIndex = 10;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = false;
            btn_display.Click += btn_display_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(324, 298);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(109, 46);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(209, 353);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(109, 46);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(324, 353);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(109, 46);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow1;
            pictureBox1.Location = new Point(25, 369);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(538, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(465, 369);
            dataGridView1.TabIndex = 15;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 429);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 28;
            label10.Text = "Go to Main Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.partnership;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(dateTime_premission);
            Controls.Add(text_number);
            Controls.Add(combo_customer);
            Controls.Add(combo_warehouse);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox combo_warehouse;
        private ComboBox combo_customer;
        private TextBox text_number;
        private DateTimePicker dateTime_premission;
        private Button btn_display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label10;
        private PictureBox pictureBox2;
    }
}