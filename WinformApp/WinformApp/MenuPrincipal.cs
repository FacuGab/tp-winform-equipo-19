using Dominio;

namespace WinformApp
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCargaArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmCargaArt))
                {
                    return;
                }
                if (item.GetType() != typeof(frmCargaArt) && item.GetType() != typeof(frmMenuPrincipal))
                {
                    MessageBox.Show("Debe terminar con el proceso actual para comenzar uno nuevo.");
                    return;
                }
            }
            imgPrincipal.Visible = false;
            frmCargaArt ventana = new frmCargaArt();
            ventana.MdiParent = this;
            ventana.Show();
            ventana.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargar datos
            Articulo Arti_ = new Articulo();
            // cargar en el caja de datos :D
        }

        private void btnGestionArt_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmGestionArt))
                {
                    return;
                }
                if (item.GetType() != typeof(frmGestionArt) && item.GetType() != typeof(frmMenuPrincipal))
                {
                    MessageBox.Show("Debe terminar con el proceso actual para comenzar uno nuevo.");
                    return;
                }
            }
            imgPrincipal.Visible = false;
            frmGestionArt ventana = new frmGestionArt();
            ventana.MdiParent = this;
            ventana.Show();
            ventana.WindowState = FormWindowState.Normal;
        }
    }
}
