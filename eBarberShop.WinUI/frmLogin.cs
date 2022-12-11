using eBarberShop.Models;

namespace eBarberShop.WinUI
{
    public partial class frmLogin : Form
    {

        public APIService service = new APIService("Korisnik");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                APIService.Korisnik = await service.Authenticate(APIService.Username,APIService.Password);

                if(APIService.Korisnik != null)
                {
                    mdiMain mdiMain = new mdiMain();
                    mdiMain.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}