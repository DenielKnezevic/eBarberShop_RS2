using eBarberShop.WinUI.Termin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBarberShop.WinUI
{
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;

        public mdiMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Uposlenici_Click(object sender, EventArgs e)
        {
            
        }

        private void Uposlenici_Click_1(object sender, EventArgs e)
        {

        }

        private void Proizvodi_Click(object sender, EventArgs e)
        {
            
        }

        private void Rezervacije_Click(object sender, EventArgs e)
        {

        }

        private void Novosti_Click(object sender, EventArgs e)
        {

        }

        private void Slike_Click(object sender, EventArgs e)
        {

        }

        private void Arhiva_Click(object sender, EventArgs e)
        {

        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            //konfigurisati visible za odredjenog korisnika
            if (APIService.Korisnik.Uloge.ToLower().Contains("administrator"))
            {
                Uposlenici.Visible = true;
                Proizvodi.Visible = true;
                Rezervacije.Visible = true;
                Novosti.Visible = true;
                Slike.Visible = true;
                Arhiva.Visible = true;
            }

            else if (APIService.Korisnik.Uloge.ToLower().Contains("uposlenik"))
            {
                Proizvodi.Visible = true;
                Rezervacije.Visible = true;
                Novosti.Visible = true;
                Slike.Visible = true;
                Arhiva.Visible = true;
            }

            else
            {
                MessageBox.Show("Nemate permisije za pristup");
            }
        }

        private void DodajProizvod_Click(object sender, EventArgs e)
        {
            frmProizvodDodaj childrenForm = new frmProizvodDodaj();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void PregledProizvoda_Click(object sender, EventArgs e)
        {
            frmProizvod childrenForm = new frmProizvod();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void UposlenikPregled_Click(object sender, EventArgs e)
        {
            frmUposlenik childrenForm = new frmUposlenik();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void RezervacijaPregled_Click(object sender, EventArgs e)
        {
            frmRezervacija childrenForm = new frmRezervacija();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void NovostiPregled_Click(object sender, EventArgs e)
        {
            frmNovost childrenForm = new frmNovost();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void SlikaPregled_Click(object sender, EventArgs e)
        {
            frmSlika childrenForm = new frmSlika();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void ArhivaPregled_Click(object sender, EventArgs e)
        {
            frmArhiva childrenForm = new frmArhiva();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void NovostiDodaj_Click(object sender, EventArgs e)
        {
            frmNovostiDodaj childrenForm = new frmNovostiDodaj();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void SlikaDodaj_Click(object sender, EventArgs e)
        {
            frmSlikaDodaj childrenForm = new frmSlikaDodaj();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void UposlenikDodaj_Click(object sender, EventArgs e)
        {
            frmUposlenikDodaj childrenForm = new frmUposlenikDodaj();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();

        }

        private void PregledTermina_Click(object sender, EventArgs e)
        {
            frmTermin childrenForm = new frmTermin();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }

        private void DodajTermin_Click(object sender, EventArgs e)
        {
            frmTerminDodaj childrenForm = new frmTerminDodaj();
            childrenForm.MdiParent = this;
            childrenForm.Text = "Window " + childFormNumber++;
            childrenForm.WindowState = FormWindowState.Maximized;
            childrenForm.Show();
        }
    }
}
