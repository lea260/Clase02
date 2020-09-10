using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Persistencia.Repositorios;


//de pueba

namespace Presentacion.Formularios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //llamo a conexion. 
            try
            {
                MySqlDataReader reader = null;
                MySqlConnection con = ConexionDB.GetConexion();
                con.Open();
                string sql = "SELECT * FROM productos";               
                MySqlCommand comando = new MySqlCommand(sql,con);
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
                Console.WriteLine("hola");
            }
            finally{

            }
        }
    }
}
