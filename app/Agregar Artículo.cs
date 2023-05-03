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
    public partial class frmAgregarArt : Form
    {
        public frmAgregarArt()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO: Agregar Articulo
            //TODO: REVISAR PORQUE AL CREAR UN ARTICULO NUEVO, AL TOCAR ACTUALIZAR NO APARECE EL NUEVO ARTICULO, SIENDO QUE EN LA BASE LO VEO CREADO
            Articulo art = new Articulo();
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            //Categoria cat = new Categoria();
            //Marca marca = new Marca();
            try 
            {
                art.codigo = txtCodArt.Text;
                art.descrpicion = txtDescrip.Text;
                art.precio = decimal.Parse(txtPrecio.Text);
                art.nombre = txtNombre.Text;
                art.categoria = (Categoria)cboCategoria.SelectedItem;
                art.marca = (Marca)cboMarca.SelectedItem;

                negocioArticulo.Agregar(art);
                MessageBox.Show("Articulo Guardado");

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                cboCategoria.DataSource = negocio.LeerCategorias();
                cboMarca.DataSource = negocio.LeerMarcas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
