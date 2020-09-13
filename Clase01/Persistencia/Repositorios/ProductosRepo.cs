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
            MySqlConnection conexion = null;
            try
            {
                MySqlDataReader reader = null;
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = "SELECT id_productos, codigo,descripcion,precio,fecha FROM productos";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        string id = reader.GetString(0);
                        string codigo = reader.GetString(1);
                        string descripcion = reader.GetString(2);
                        string precio = reader.GetString(3);
                        string fecha = (reader[4] != DBNull.Value) ? reader.GetString(4) : "29/12/2012 0:00:00";
                        ProductoEntidad prod = new ProductoEntidad();
                        prod.Id_productos = long.Parse(id);
                        prod.Codigo = codigo;
                        prod.Descripcion = descripcion;
                        prod.Precio = float.Parse(precio);
                        DateTime fechaD = DateTime.ParseExact(fecha, "dd/MM/yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        prod.Fecha = fechaD;
                        list.Add(prod);
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
                if (conexion != null) {
                    conexion.Close();
                } 
            }
            return list;
        }        
    }
}
