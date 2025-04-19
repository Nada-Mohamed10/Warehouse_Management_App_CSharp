namespace users
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_name = new TextBox();
            SignIn = new Button();
            txt_password = new TextBox();
            signUP = new Button();
            pictureBox1 = new PictureBox();
            checkBox_password = new CheckBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(413, 99);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(413, 164);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(427, 333);
            label3.Name = "label3";
            label3.Size = new Size(254, 23);
            label3.TabIndex = 3;
            label3.Text = "Don't have an account sign up?";
            // 
            // txt_name
            // 
            txt_name.HideSelection = false;
            txt_name.Location = new Point(517, 103);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(261, 27);
            txt_name.TabIndex = 4;
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.Teal;
            SignIn.Cursor = Cursors.Hand;
            SignIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignIn.ForeColor = Color.White;
            SignIn.Location = new Point(517, 242);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(261, 39);
            SignIn.TabIndex = 5;
            SignIn.Text = "LOGIN";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += SignIn_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(517, 164);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(261, 27);
            txt_password.TabIndex = 6;
           
            // 
            // signUP
            // 
            signUP.BackColor = Color.Teal;
            signUP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signUP.ForeColor = Color.White;
            signUP.Location = new Point(687, 321);
            signUP.Name = "signUP";
            signUP.Size = new Size(91, 42);
            signUP.TabIndex = 7;
            signUP.Text = "Sign UP";
            signUP.UseVisualStyleBackColor = false;
            signUP.Click += signUP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4957412_Mobile_login_Cristina;
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // checkBox_password
            // 
            checkBox_password.AutoSize = true;
            checkBox_password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox_password.Location = new Point(646, 197);
            checkBox_password.Name = "checkBox_password";
            checkBox_password.Size = new Size(136, 24);
            checkBox_password.TabIndex = 9;
            checkBox_password.Text = "Show Password";
            checkBox_password.UseVisualStyleBackColor = true;
            checkBox_password.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(517, 22);
            label4.Name = "label4";
            label4.Size = new Size(216, 41);
            label4.TabIndex = 10;
            label4.Text = "Login Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 426);
            Controls.Add(label4);
            Controls.Add(checkBox_password);
            Controls.Add(pictureBox1);
            Controls.Add(signUP);
            Controls.Add(txt_password);
            Controls.Add(SignIn);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_name;
        private Button SignIn;
        private TextBox txt_password;
        private Button signUP;
        private PictureBox pictureBox1;
        private CheckBox checkBox_password;
        private Label label4;
    }
}
