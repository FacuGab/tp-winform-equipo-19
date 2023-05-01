using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AccesoDatos
{
    public class Database
    {
        //T VARIABLES:
        public SqlDataReader reader { get; set; }
        private SqlConnection connection;
        private SqlCommand command;

        //T METODOS:
        // ABRIR
        public bool AbrirConexion(string path)
        {
            try
            {
                connection = new SqlConnection(path);
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }  
        // CERRAR
        public void CerrarConexion()
        {
            try
            {
                reader?.Close();
                reader?.Dispose();
                command?.Dispose();
                connection.Close();
                connection.Dispose();
                // ¿ que hace realmente el Dispose, elimina todos los recursos asociados al obj instaciado ?
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // SETEAR
        public void setQuery(string query) 
        {
            try
            {
                command = new SqlCommand(query, connection);
            }
            catch (Exception ex)
            {
                command.Dispose();
                throw ex;
            }
        }
        // LEER 
        public void readData()
        {
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                command.Dispose();
                throw ex;
            }
        }
        // EJECUTAR
        public int executeQuery()
        {// podria retornar un int para obtener info de los datos afectados ¿?
            try
            {
               return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }//fin
}
