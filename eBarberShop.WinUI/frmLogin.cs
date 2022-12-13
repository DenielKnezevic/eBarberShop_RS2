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

                APIService.Korisnik = await service.Authenticate();

                if(APIService.Korisnik != null && (APIService.Korisnik.Uloge.ToLower().Contains("administrator") ||
                    (APIService.Korisnik.Uloge.ToLower().Contains("uposlenik"))))
                {
                    mdiMain mdiMain = new mdiMain();
                    mdiMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nemate permisije za pristup aplikaciji");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}