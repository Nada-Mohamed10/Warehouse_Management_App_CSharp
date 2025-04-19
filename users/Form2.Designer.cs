namespace users
{
    partial class Form2
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
            txt_newName = new TextBox();
            txt_newPassword = new TextBox();
            txt_confirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Register = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_newName
            // 
            txt_newName.Location = new Point(511, 117);
            txt_newName.Name = "txt_newName";
            txt_newName.Size = new Size(237, 27);
            txt_newName.TabIndex = 0;
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(511, 176);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(237, 27);
            txt_newPassword.TabIndex = 1;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(511, 232);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(237, 27);
            txt_confirmPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(360, 113);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(349, 179);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(318, 232);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // Register
            // 
            Register.BackColor = Color.Teal;
            Register.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(511, 286);
            Register.Name = "Register";
            Register.Size = new Size(231, 43);
            Register.TabIndex = 6;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Image = Properties.Resources._4957412_Mobile_login_Cristina;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 359);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 400);
            Controls.Add(pictureBox1);
            Controls.Add(Register);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_newPassword);
            Controls.Add(txt_newName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_newName;
        private TextBox txt_newPassword;
        private TextBox txt_confirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Register;
        private PictureBox pictureBox1;
    }
}