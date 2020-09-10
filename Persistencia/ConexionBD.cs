using System;
using MySql.Data.MySqlClient;


namespace Persistencia
{    
    public class ConexionBD
    {
        string servidor = "localhost";
        string database = "clientes";
        string usuario = "";
        
        private string cadenaConexion= "Database=" "; Data Source";
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
    }
}
