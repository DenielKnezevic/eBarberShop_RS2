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
            frmUposlenik frmProizvod = new frmUposlenik();
            frmProizvod.Show();
        }
    }
}