using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        //TODO: EVENTOS:
        //TODO: LOAD frmAgregarArt
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
        //TODO: BOTON CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TODO: BOTON ACEPTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO: Agregar Articulo
            Articulo art = new Articulo();
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            int res = 0;
            try 
            {
                art.codigo = txtCodArt.Text;
                art.descrpicion = txtDescrip.Text;
                art.UrlImagen = txtUrl.Text;
                art.precio = decimal.Parse(txtPrecio.Text);
                art.nombre = txtNombre.Text;
                art.categoria = (Categoria)cboCategoria.SelectedItem;
                art.marca = (Marca)cboMarca.SelectedItem;

                res += negocioArticulo.Agregar(art);
                //res += negocioArticulo.AgregarImg(art.id, art.UrlImagen);

                if (res > 0)
                    MessageBox.Show("Articulo Guardado");
                else
                    MessageBox.Show("Articulo No Guardado");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            Close();
        }
        //TODO: EVEMTO IMAGEN EN CARGA DE ARTICULO
        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImg(txtUrl.Text);
        }
        //TODO: METODO CARGAR IMAGEN
        private void cargarImg(string imagen)
        {
            try
            {
                pbxCargaImg.Load(imagen);
            }
            catch
            {
                pbxCargaImg.Load("https://images.wondershare.com/repairit/aticle/2021/07/resolve-images-not-showing-problem-1.jpg");
            }
        }
    }
}
