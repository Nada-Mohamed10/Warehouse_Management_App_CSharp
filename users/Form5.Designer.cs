namespace users
{
    partial class Form5
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
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txt_code = new TextBox();
            txt_name = new TextBox();
            combo_unit = new ComboBox();
            combo_warehouse = new ComboBox();
            btn_display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            txt_search = new TextBox();
            Search = new Button();
            txt_quntity = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(93, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 1;
            label2.Text = "Code Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 2;
            label3.Text = "Name Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 3;
            label4.Text = "Measurement Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(34, 307);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 5;
            label6.Text = "Warehouse";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__1_2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txt_code
            // 
            txt_code.Location = new Point(204, 125);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(233, 27);
            txt_code.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(204, 168);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(233, 27);
            txt_name.TabIndex = 8;
            // 
            // combo_unit
            // 
            combo_unit.FormattingEnabled = true;
            combo_unit.Location = new Point(204, 213);
            combo_unit.Name = "combo_unit";
            combo_unit.Size = new Size(233, 28);
            combo_unit.TabIndex = 10;
            // 
            // combo_warehouse
            // 
            combo_warehouse.FormattingEnabled = true;
            combo_warehouse.Location = new Point(204, 307);
            combo_warehouse.Name = "combo_warehouse";
            combo_warehouse.Size = new Size(233, 28);
            combo_warehouse.TabIndex = 11;
            // 
            // btn_display
            // 
            btn_display.BackColor = Color.Teal;
            btn_display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_display.ForeColor = Color.White;
            btn_display.Location = new Point(204, 348);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(113, 44);
            btn_display.TabIndex = 12;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = false;
            btn_display.Click += btn_display_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(324, 348);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(113, 44);
            btn_add.TabIndex = 13;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(204, 398);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(113, 44);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(324, 398);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(113, 44);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(565, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(558, 351);
            dataGridView1.TabIndex = 16;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.left_arrow1;
            pictureBox2.Location = new Point(12, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 422);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 18;
            label7.Text = "Go to Main Home";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(565, 50);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(394, 27);
            txt_search.TabIndex = 19;
            // 
            // Search
            // 
            Search.BackColor = Color.Teal;
            Search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.ForeColor = Color.White;
            Search.Location = new Point(975, 46);
            Search.Name = "Search";
            Search.Size = new Size(127, 36);
            Search.TabIndex = 21;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // txt_quntity
            // 
            txt_quntity.Location = new Point(204, 262);
            txt_quntity.Name = "txt_quntity";
            txt_quntity.Size = new Size(233, 27);
            txt_quntity.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(47, 262);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 23;
            label5.Text = "Quantity";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1238, 450);
            Controls.Add(label5);
            Controls.Add(txt_quntity);
            Controls.Add(Search);
            Controls.Add(txt_search);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(combo_warehouse);
            Controls.Add(combo_unit);
            Controls.Add(txt_name);
            Controls.Add(txt_code);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
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
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox txt_code;
        private TextBox txt_name;
        private ComboBox combo_unit;
        private ComboBox combo_warehouse;
        private Button btn_display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox txt_search;
        private Button Search;
        private TextBox txt_quntity;
        private Label label5;
    }
}