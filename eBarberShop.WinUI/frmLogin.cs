namespace eBarberShop.WinUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmProizvod frmProizvod = new frmProizvod();
            frmProizvod.Show();
        }
    }
}