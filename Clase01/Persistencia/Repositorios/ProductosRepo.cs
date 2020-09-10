using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace Persistencia.Repositorios
{
    public class ProductosRepo
    {
        public void Listar()
        {
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
        }        
    }
}
