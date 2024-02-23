namespace LoginFormado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "admin@123")
            {
                this.Hide();
                new Selection().ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter valid Userid and Password");
            }
        }

    }
}