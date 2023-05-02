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
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        // METODOS
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            dgvPanel.DataSource = negocio.Leer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //negocio = new NegocioArticulo();
            //Articulo art = new Articulo();
            //art.nombre = "Facu";
            //art.descrpicion = "programador";
            //art.precio = 1;
            //art.marca.marca = "1";
            //art.categoria.categoria = "1";
            //art.codigo = "aaa";

            //if (negocio.Agregar(art) > 0)
            //    MessageBox.Show("Articulo Agregado!");
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
