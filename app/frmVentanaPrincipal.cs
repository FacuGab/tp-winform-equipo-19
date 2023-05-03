using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmVentanaPrincipal : Form
    {
        NegocioArticulo negocio;
        private List<Articulo> ListaArticulos;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }
        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            ListaArticulos = negocio.Leer();
            dgvPanel.DataSource = ListaArticulos;
            pbxArticuloLoad.Load(ListaArticulos[0].UrlImagen);
        }


        // METODOS
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            dgvPanel.DataSource = negocio.Leer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt frmAgregarArt = new frmAgregarArt();
            frmAgregarArt.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPanel_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvPanel.CurrentRow.DataBoundItem;
            try
            {
                pbxArticuloLoad.Load(seleccionado.UrlImagen);
            }
            catch (Exception)
            {

                pbxArticuloLoad.Load("https://www.shutterstock.com/image-vector/no-image-available-vector-illustration-260nw-744886198.jpg");
            }
        }
    }
}
