using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Persistencia.Entidades;

namespace Persistencia.Repositorios
{
    public class ProductosRepo
    {
        public List<ProductoEntidad> ListarProductos()
        {
            List<ProductoEntidad> list = new List<ProductoEntidad>();
            try
            {
                MySqlDataReader reader = null;
                MySqlConnection con = ConexionDB.GetConexion();
                con.Open();
                string sql = "SELECT * FROM productos";
                MySqlCommand comando = new MySqlCommand(sql, con);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string uno = reader.GetString(0);
                        string dos = reader.GetString(1);
                        string tres = reader.GetString(2);
                        string cuatro = reader.GetString(3);
                        string cinco = reader.GetString(4);
                    }
                }

            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("hola"+mensaje );
            }
            finally
            {

            }
            return list;
        }        
    }
}
