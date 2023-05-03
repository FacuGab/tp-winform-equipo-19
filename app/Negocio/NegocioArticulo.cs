using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocio
{
    public class NegocioArticulo
    {
        //TODO: VARIABLES:
        private SqlDataReader lector = null;
        private Database datos;
        public List<Articulo> articulos;
        public List<Categoria> categorias;
        public List<Marca> marcas;

        //TODO: METODOS:
        // Leer Datos
        public List<Articulo> Leer()
        {
            try
            {
                Articulo artAux;
                articulos = new List<Articulo>();
                datos = new Database();

                datos.AbrirConexion("server=Manulo-PC\\SQLLABO; database = CATALOGO_P3_DB; integrated security = true"); // CADENA DE CONEXION A LA BD 
                datos.setQuery("SELECT Codigo, Nombre, A.Descripcion as Descripcion, C.Descripcion as Marca, M.Descripcion as Categoria, Precio, I.ImagenUrl  as URL FROM ARTICULOS A INNER JOIN CATEGORIAS C on C.Id = A.IdCategoria INNER JOIN MARCAS M on M.Id = A.IdMarca INNER JOIN IMAGENES I on I.IdArticulo = A.Id");    
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
                    artAux.imagenes = new List<string> { lector["URL"].ToString() }; // cuidado, si tiene mas fotos no se como cargarlas, hay que usar una query y modo distinto
                    // metodo lector de imagenes ?
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
        //TODO: CBO BOX CATEGORIAS
        public List<Categoria> LeerCategorias()
        {
            try
            {
                Categoria cat;
                categorias = new List<Categoria>();
                datos = new Database();

                datos.AbrirConexion("server=Manulo-PC\\SQLLABO; database = CATALOGO_P3_DB; integrated security = true"); // CADENA DE CONEXION A LA BD 
                datos.setQuery("SELECT id, Descripcion FROM CATEGORIAS");
                datos.readData();
                lector = datos.reader;

                while (lector.Read())
                {
                    cat = new Categoria();
                    cat.idCategoria = (int)lector["id"];
                    cat.categoria = lector["Descripcion"].ToString();

                    // metodo lector de imagenes ?
                    categorias.Add(cat);
                }
                return categorias;

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
        //TODO: CBO BOX MARCAS
        public List<Marca> LeerMarcas()
        {
            try
            {
                Marca marca;
                marcas = new List<Marca>();
                datos = new Database();

                datos.AbrirConexion("server=Manulo-PC\\SQLLABO; database = CATALOGO_P3_DB; integrated security = true"); // CADENA DE CONEXION A LA BD 
                datos.setQuery("SELECT id, Descripcion FROM MARCAS");
                datos.readData();
                lector = datos.reader;

                while (lector.Read())
                {
                    marca = new Marca();
                    marca.idMarca = (int)lector["id"];
                    marca.marca = lector["Descripcion"].ToString();

                    // metodo lector de imagenes ?
                    marcas.Add(marca);
                }
                return marcas;

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

        // TODO: Agregar Datos
        public int Agregar(Articulo nuevoArticulo)
        {
            try
            {
                datos = new Database();
                datos.AbrirConexion("server=Manulo-PC\\SQLLABO; database = CATALOGO_P3_DB; integrated security = true"); // CADENA DE CONEXION A LA BD 
                datos.setQuery($"INSERT INTO ARTICULOS VALUES ('{nuevoArticulo.codigo}','{nuevoArticulo.nombre}', '{nuevoArticulo.descrpicion}', @marca, @categoria, '{nuevoArticulo.precio}')");
                datos.setearParamento("@categoria", nuevoArticulo.categoria.idCategoria);
                datos.setearParamento("@marca", nuevoArticulo.marca.idMarca);
                return datos.executeQuery();
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
