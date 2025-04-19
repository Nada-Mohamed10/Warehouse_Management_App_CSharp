namespace users
{
    partial class Form7
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
            txt_name = new TextBox();
            txt_mobile = new TextBox();
            txt_fax = new TextBox();
            txt_phone = new TextBox();
            txt_website = new TextBox();
            dataGridView1 = new DataGridView();
            btn_display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            pictureBox1 = new PictureBox();
            txt_email = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            txt_search = new TextBox();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(96, 24);
            label1.Name = "label1";
            label1.Size = new Size(131, 41);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "Mobile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(19, 187);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 3;
            label4.Text = "Fax   ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(13, 307);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 5;
            label6.Text = "Website";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(104, 106);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(254, 27);
            txt_name.TabIndex = 7;
            // 
            // txt_mobile
            // 
            txt_mobile.Location = new Point(104, 146);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.Size = new Size(254, 27);
            txt_mobile.TabIndex = 8;
            // 
            // txt_fax
            // 
            txt_fax.Location = new Point(104, 187);
            txt_fax.Name = "txt_fax";
            txt_fax.Size = new Size(254, 27);
            txt_fax.TabIndex = 9;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(104, 233);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(254, 27);
            txt_phone.TabIndex = 10;
            // 
            // txt_website
            // 
            txt_website.Location = new Point(104, 307);
            txt_website.Name = "txt_website";
            txt_website.Size = new Size(254, 27);
            txt_website.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(426, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(620, 366);
            dataGridView1.TabIndex = 12;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // btn_display
            // 
            btn_display.BackColor = Color.Teal;
            btn_display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_display.ForeColor = Color.White;
            btn_display.Location = new Point(116, 352);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(118, 40);
            btn_display.TabIndex = 13;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = false;
            btn_display.Click += btn_display_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Teal;
            btn_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(240, 352);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(118, 40);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Teal;
            btn_update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(116, 400);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(118, 40);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Teal;
            btn_delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(240, 398);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(118, 40);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supplier;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(104, 273);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(254, 27);
            txt_email.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(21, 272);
            label7.Name = "label7";
            label7.Size = new Size(60, 28);
            label7.TabIndex = 19;
            label7.Text = "Email";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.left_arrow3;
            pictureBox2.Location = new Point(13, 408);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 455);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 21;
            label8.Text = "Go to Main Home";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(496, 69);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(381, 27);
            txt_search.TabIndex = 22;
            // 
            // search
            // 
            search.BackColor = Color.Teal;
            search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = Color.White;
            search.Location = new Point(883, 59);
            search.Name = "search";
            search.Size = new Size(133, 41);
            search.TabIndex = 23;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 484);
            Controls.Add(search);
            Controls.Add(txt_search);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(txt_email);
            Controls.Add(pictureBox1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(dataGridView1);
            Controls.Add(txt_website);
            Controls.Add(txt_phone);
            Controls.Add(txt_fax);
            Controls.Add(txt_mobile);
            Controls.Add(txt_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label6;
        private TextBox txt_name;
        private TextBox txt_mobile;
        private TextBox txt_fax;
        private TextBox txt_phone;
        private TextBox txt_website;
        private DataGridView dataGridView1;
        private Button btn_display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private PictureBox pictureBox1;
        private TextBox txt_email;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label8;
        private TextBox txt_search;
        private Button search;
    }
}