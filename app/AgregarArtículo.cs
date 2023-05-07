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
        private Articulo articulo = null;
        private NegocioArticulo negocio;
        public frmAgregarArt()
        {
            InitializeComponent();
        }
        public frmAgregarArt(Articulo art)
        {
            this.articulo = art;
            InitializeComponent();
        }

        //TODO: EVENTOS:
        //TODO: LOAD frmAgregarArt
        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            try
            {
                lblModificar.Visible = false;
                lblCarga.Visible = true;
                cboMarca.DataSource = negocio.LeerMarcas();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "marca";
                cboCategoria.DataSource = negocio.LeerCategorias();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "categoria";

                if (articulo != null ) 
                {
                    lblModificar.Visible = true;
                    lblCarga.Visible = false;
                    cargarFormulario(articulo);
                    cboMarca.SelectedValue = articulo.marca.idMarca;
                    cboCategoria.SelectedValue = articulo.categoria.idCategoria;
                }
                

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
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            int resArt = 0;
            int resImg = 0;
            try 
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.codigo = txtCodArt.Text;
                articulo.descripicion = txtDescrip.Text;
                articulo.UrlImagen = txtUrl.Text;
                articulo.precio = decimal.Parse(txtPrecio.Text);
                articulo.nombre = txtNombre.Text;
                articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                
                if(articulo.id != 0)
                {
                    resArt += negocioArticulo.Modificar(articulo);
                    resImg += negocioArticulo.ModificarImg(articulo.id, articulo.UrlImagen);
                }
                else
                {
                    if(!string.IsNullOrEmpty(txtUrl.Text))
                    {
                        resArt += negocioArticulo.Agregar(articulo);
                        resImg += negocioArticulo.AgregarImg(articulo.id, articulo.UrlImagen);
                    }
                    else
                    {
                        MessageBox.Show("Hay que agregar una imagen para continuar");
                    }
                }

                if (resArt > 0 && resImg > 0)
                {
                    MessageBox.Show("Articulo Guardado/Modificado");
                    Close();
                }
                else if(resImg == 0)
                {
                    MessageBox.Show("Articulo guardado/modificado sin Imagen");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en la carga de datos");
                }


            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
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
        //TODO: METODO CARGAR FORMULARIO
        private void cargarFormulario(Articulo articulo) 
        {
            txtCodArt.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescrip.Text = articulo.descripicion;
            txtPrecio.Text = articulo.precio.ToString();
            txtUrl.Text = articulo.UrlImagen;
            
            try
            {
                pbxCargaImg.Load(articulo.UrlImagen);
            }
            catch (Exception)
            {
                cargarImg("https://images.wondershare.com/repairit/aticle/2021/07/resolve-images-not-showing-problem-1.jpg");
                MessageBox.Show("Se requiere reemplazar la imágen");
            }

            // Hay que ver como hacer que los cbo carguen con la categoria y marca correcta ...

        }

    }//Fin
}
