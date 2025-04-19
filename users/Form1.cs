using users.models;

namespace users
{
    public partial class Form1 : Form
    {
        ITIProjectContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ITIProjectContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
           txt_name.TabStop=false;
        }

        private void SignIn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userExist = db.Users.FirstOrDefault(n => n.name == txt_name.Text);

            if (userExist == null)
            {
                MessageBox.Show("User not found you should sign up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (userExist.password == txt_password.Text)
                {
                    var userName = txt_name.Text;
                    MessageBox.Show("Welcome " + txt_name.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emptyTextBox();
                    this.Close();
                    Thread thread = new Thread(openForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void openForm()
        {
            Application.Run(new Form3());
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_password.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void signUP_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }


        public void emptyTextBox()
        {
            txt_name.Text = txt_password.Text = " ";
        }

       
       
    }
}
