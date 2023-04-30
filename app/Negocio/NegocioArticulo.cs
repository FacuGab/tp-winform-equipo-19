using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegocioArticulo
    {
        //T VARIABLES:
        private SqlDataReader lector = null;
        private Database datos;
        public List<Articulo> articulos;

        //T METODOS:
        // Leer Datos
        public List<Articulo> Leer()
        {
            try
            {
                Articulo artAux;
                articulos = new List<Articulo>();
                datos = new Database();

                datos.AbrirConexion("server=.; database = CATALOGO_P3_DB; integrated security = true"); // CADENA DE CONEXION A LA BD 
                datos.setQuery("SELECT Codigo, Nombre, A.Descripcion as Descripcion, C.Descripcion as Marca, M.Descripcion as Categoria, Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN CATEGORIAS C on C.Id = A.IdCategoria INNER JOIN MARCAS M on M.Id = A.IdMarca INNER JOIN IMAGENES I on I.IdArticulo = A.Id");    
                datos.readData();
                lector = datos.reader;

                while(lector.Read())
                {
                    artAux = new Articulo();
                    artAux.codigo = lector["Codigo"].ToString();
                    artAux.nombre = lector["Nombre"].ToString();
                    artAux.descrpicion = lector["Descripcion"].ToString();
                    artAux.marca = new Marca(lector["Marca"].ToString());
                    artAux.categoria = new Categoria(lector["Categoria"].ToString());
                    artAux.precio = Convert.ToDecimal(lector["Precio"]);
                    artAux.imagenes = new List<string> { lector["ImagenUrl"].ToString() }; // cuidado, si tiene mas fotos no se como cargarlas, hay que usar una query y modo distinto
                    articulos.Add(artAux);
                }
                return articulos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                lector?.Close(); // pregunta si " lector == null? " si no lo esta llama al metodo interno Close() 
                datos.CerrarConexion();
            }
        }

    }//Fin
}
