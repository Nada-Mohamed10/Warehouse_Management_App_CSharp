namespace users
{
    partial class Warehouse
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
            txt_name = new TextBox();
            txt_mang = new TextBox();
            txt_add = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_Display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            txt_search = new TextBox();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(212, 126);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(270, 27);
            txt_name.TabIndex = 0;
            // 
            // txt_mang
            // 
            txt_mang.Location = new Point(212, 228);
            txt_mang.Name = "txt_mang";
            txt_mang.Size = new Size(270, 27);
            txt_mang.TabIndex = 1;
            // 
            // txt_add
            // 
            txt_add.Location = new Point(212, 177);
            txt_add.Name = "txt_add";
            txt_add.Size = new Size(270, 27);
            txt_add.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 3;
            label1.Text = "Warehouses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 4;
            label2.Text = "Name Warehouse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(8, 173);
            label3.Name = "label3";
            label3.Size = new Size(198, 28);
            label3.TabIndex = 5;
            label3.Text = "Address Warwhouse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(8, 226);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 6;
            label4.Text = "Manger Warehouse";
            // 
            // btn_Display
            // 
            btn_Display.BackColor = Color.Teal;
            btn_Display.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Display.ForeColor = Color.White;
            btn_Display.Location = new Point(212, 294);
            btn_Display.Name = "btn_Display";
            btn_Display.Size = new Size(132, 52);
            btn_Display.TabIndex = 7;
            btn_Display.Text = "Display";
            btn_Display.UseVisualStyleBackColor = false;
            btn_Display.Click += btn_Display_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(350, 294);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(132, 52);
            btn_add.TabIndex = 8;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(212, 367);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(132, 52);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(350, 367);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(132, 52);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(572, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 338);
            dataGridView1.TabIndex = 11;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.warehouse__1_3;
            pictureBox1.Location = new Point(8, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.left_arrow1;
            pictureBox2.Location = new Point(12, 407);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 467);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 14;
            label5.Text = "Go to Main Home";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(592, 81);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(342, 27);
            txt_search.TabIndex = 16;
            // 
            // search
            // 
            search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = Color.Teal;
            search.Location = new Point(959, 70);
            search.Name = "search";
            search.Size = new Size(115, 43);
            search.TabIndex = 17;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1138, 496);
            Controls.Add(search);
            Controls.Add(txt_search);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_Display);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_add);
            Controls.Add(txt_mang);
            Controls.Add(txt_name);
            Name = "Warehouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_mang;
        private TextBox txt_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txt_search;
        private Button search;
    }
}