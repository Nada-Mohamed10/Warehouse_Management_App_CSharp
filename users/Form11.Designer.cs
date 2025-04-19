namespace users
{
    partial class Form11
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
            combo_warehouse = new ComboBox();
            dataGridView1 = new DataGridView();
            dateTime_start = new DateTimePicker();
            dateTime_end = new DateTimePicker();
            select = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 0;
            label1.Text = "Warehouse";
            // 
            // combo_warehouse
            // 
            combo_warehouse.FormattingEnabled = true;
            combo_warehouse.Location = new Point(132, 132);
            combo_warehouse.Name = "combo_warehouse";
            combo_warehouse.Size = new Size(281, 28);
            combo_warehouse.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(510, 401);
            dataGridView1.TabIndex = 2;
            // 
            // dateTime_start
            // 
            dateTime_start.Location = new Point(132, 194);
            dateTime_start.Name = "dateTime_start";
            dateTime_start.Size = new Size(281, 27);
            dateTime_start.TabIndex = 3;
            // 
            // dateTime_end
            // 
            dateTime_end.Location = new Point(132, 252);
            dateTime_end.Name = "dateTime_end";
            dateTime_end.Size = new Size(281, 27);
            dateTime_end.TabIndex = 4;
            // 
            // select
            // 
            select.BackColor = Color.Teal;
            select.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            select.ForeColor = Color.White;
            select.Location = new Point(165, 310);
            select.Name = "select";
            select.Size = new Size(130, 53);
            select.TabIndex = 5;
            select.Text = "Display";
            select.UseVisualStyleBackColor = false;
            select.Click += select_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 194);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 6;
            label2.Text = "StartDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 7;
            label3.Text = "EndDate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow2;
            pictureBox1.Location = new Point(12, 370);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 428);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 15;
            label5.Text = "Go to Main Home";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 28);
            label4.Name = "label4";
            label4.Size = new Size(285, 41);
            label4.TabIndex = 16;
            label4.Text = "Report Warehouses";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.supplier1;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(select);
            Controls.Add(dateTime_end);
            Controls.Add(dateTime_start);
            Controls.Add(dataGridView1);
            Controls.Add(combo_warehouse);
            Controls.Add(label1);
            ForeColor = Color.Teal;
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox combo_warehouse;
        private DataGridView dataGridView1;
        private DateTimePicker dateTime_start;
        private DateTimePicker dateTime_end;
        private Button select;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
    }
}