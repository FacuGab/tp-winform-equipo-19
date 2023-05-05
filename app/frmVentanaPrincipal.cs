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
        //TODO: VARIABLES frmVentanaPrincipal
        NegocioArticulo negocio;
        private List<Articulo> ListaArticulos;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }
        //TODO: LOAD frmVentanaPrincipal
        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            ListaArticulos = negocio.Leer();
            dgvPanel.DataSource = ListaArticulos;
            dgvPanel.Columns["UrlImagen"].Visible = false;
            CargarImg(ListaArticulos[0].UrlImagen);
            //pbxArticuloLoad.Load(ListaArticulos[0].UrlImagen);
        }
        //TODO: EVENTOS frmVentanaPrincipal
        //TODO: BOTON ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            negocio = new NegocioArticulo();
            dgvPanel.DataSource = negocio.Leer();
            CargarImg( ((Articulo)dgvPanel.CurrentRow.DataBoundItem).UrlImagen );
        }
        //TODO: BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt frmAgregarArt = new frmAgregarArt();
            frmAgregarArt.ShowDialog();
        }
        //TODO: SELECCION EN GRID
        private void dgvPanel_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvPanel.CurrentRow.DataBoundItem;
            CargarImg(seleccionado.UrlImagen);
        }
        //TODO: BOTON EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // nada por ahora... 
        }
        //TODO: METODOS frmVentanaPrincipal
        //TODO: Cargar Imagen
        private void CargarImg(string path)
        {
            try
            {
                pbxArticuloLoad.Load(path);
            }
            catch (Exception)
            {
                pbxArticuloLoad.Load("https://www.shutterstock.com/image-vector/no-image-available-vector-illustration-260nw-744886198.jpg");
            }
        }
    }
}
