using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Objetos
{
    /// <summary>
    /// constiyen los objetos de datos, 
    /// </summary>
    public class DataUsuario
    {
        //private string nombre;
        //private string apellido;
        public DataUsuario()
        {
            
           
        }

        public string nombreCompleto()   // property
        {
            string fname = this.Nombre + this.Apellido;
            return fname; 
        }

        /// <summary>
        /// permite datau = new DataUsuario()
        /// datu.Nombre = "juan";
        /// 
        /// </summary>
        /// 
        public string Nombre   // property
        {
            get; set;
        }
        public string Apellido   // property
        {
            get; set;
        }






    }
}
