﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace Negocio
{
    public class NegocioArticulo
    {
        //TODO: VARIABLES NEGOCIO:
        private SqlDataReader lector = null;
        private Database datos;
        public List<Articulo> articulos;
        public List<Categoria> categorias;
        public List<Marca> marcas;

        //TODO: METODOS NEGOCIO:
        //TODO: Leer Datos
        public List<Articulo> Leer()
        {
            try
            {
                Articulo artAux;
                articulos = new List<Articulo>();
                datos = new Database();

                // CADENA DE CONEXION A LA BD EN Database.cs (sino hay que cambiar todos las cadenas de todos los metodos, ir a Database para cambiarlo de forma unificada)
                datos.AbrirConexion();
                datos.setQuery("SELECT A.Id, Codigo, Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio, I.ImagenUrl  as URL FROM ARTICULOS A INNER JOIN CATEGORIAS C on C.Id = A.IdCategoria INNER JOIN MARCAS M on M.Id = A.IdMarca INNER JOIN IMAGENES I on I.IdArticulo = A.Id");    
                datos.readData();
                lector = datos.reader;

                while(lector.Read())
                {
                    artAux = new Articulo();
                    artAux.id = Convert.ToInt32(lector["Id"]);
                    artAux.codigo = lector["Codigo"].ToString();
                    artAux.nombre = lector["Nombre"].ToString();
                    artAux.descripicion = lector["Descripcion"].ToString();

                    artAux.marca = new Marca(lector["Marca"].ToString());
                    artAux.marca.idMarca = (int)lector["Id"];
                    artAux.marca.marca = lector["Marca"].ToString();

                    artAux.categoria = new Categoria(lector["Categoria"].ToString());
                    artAux.categoria.idCategoria = (int)lector["Id"];
                    artAux.categoria.categoria = lector["Categoria"].ToString();

                    artAux.precio = Convert.ToDecimal(lector["Precio"]);
                    if (!(lector["URL"] is DBNull))
                        artAux.UrlImagen = lector["URL"].ToString(); // cuidado, si tiene mas fotos no se como cargarlas, hay que usar una query y modo distinto
                    // metodo lector de imagenes ?
                    articulos.Add(artAux);
                }
                return articulos;

            }
            catch(SqlException ex)
            {
                throw ex;
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

                datos.AbrirConexion();
                datos.setQuery("SELECT id, Descripcion FROM CATEGORIAS");
                datos.readData();
                lector = datos.reader;

                while (lector.Read())
                {
                    cat = new Categoria();
                    cat.idCategoria = (int)lector["id"];
                    cat.categoria = lector["Descripcion"].ToString();
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

                datos.AbrirConexion();
                datos.setQuery("SELECT id, Descripcion FROM MARCAS");
                datos.readData();
                lector = datos.reader;

                while (lector.Read())
                {
                    marca = new Marca();
                    marca.idMarca = (int)lector["id"];
                    marca.marca = lector["Descripcion"].ToString();
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
        //TODO: Agregar Datos
        public int Agregar(Articulo nuevoArticulo)
        {
            try
            {
                datos = new Database();
                datos.AbrirConexion(); // CADENA DE CONEXION A LA BD (ir a Database.cs para cambiar la cadena)
                string query = $"INSERT INTO ARTICULOS VALUES ('@codigo', '@nombre', '@descripcion', @marca, @categoria, @precio)";
                datos.setQuery(query);
                datos.setearParamento("@codigo", nuevoArticulo.codigo);
                datos.setearParamento("@nombre", nuevoArticulo.nombre);
                datos.setearParamento("@descrpicion", nuevoArticulo.descripicion);
                datos.setearParamento("@categoria", nuevoArticulo.categoria.idCategoria);
                datos.setearParamento("@marca", nuevoArticulo.marca.idMarca);
                datos.setearParamento("@precio", nuevoArticulo.precio);
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

        //TODO: Modificar artículo (falta agregar el metodo modificar)
        public int Modificar(Articulo nuevoArticulo)
        {
            try
            {
                Database datos = new Database();
                datos.AbrirConexion();
                string query = "UPDATE ARTICULOS SET Codigo='@codigo',Nombre='@nombre', Descripcion='@descripcion', IdMarca=@marca, IdCategoria=@categoria, Precio=@precio WHERE ID=@id" ;
                datos.setQuery(query);
                datos.setearParamento("@id", nuevoArticulo.id);
                datos.setearParamento("@codigo", nuevoArticulo.codigo);
                datos.setearParamento("@nombre", nuevoArticulo.nombre);
                datos.setearParamento("@descripcion", nuevoArticulo.descripicion);
                datos.setearParamento("@categoria", nuevoArticulo.categoria.idCategoria);
                datos.setearParamento("@marca", nuevoArticulo.marca.idMarca);
                datos.setearParamento("@precio", nuevoArticulo.precio);
                return datos.executeQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //finally
            //{
            //    datos.CerrarConexion();
            //}
        }
        //TODO: Agregar url Img
        public int AgregarImg(int idArt, string urlImg)
        {
            // se necesita el id de articulo + el url de la imagen asociada
            try
            {
                datos = new Database();
                datos.AbrirConexion();
                datos.setQuery("INSERT INTO IMAGENES VALUES (@idarticulo,'@urlimg')");
                datos.setearParamento("@idarticulo", idArt);
                datos.setearParamento("@urlimg", urlImg);
                return datos.executeQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                lector?.Close(); 
                datos.CerrarConexion();
            }
        }

    }//Fin
}
