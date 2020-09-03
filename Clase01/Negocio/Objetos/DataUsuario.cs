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
        private string nombre;
        private string apellido;
        public DataUsuario()
        {
            this.nombre = "";
            this.apellido = "";

        }

        public string nombreCompleto()   // property
        {
            string fname = this.nombre + this.apellido;
            return fname; 
        }

        /// <summary>
        /// permite datau = new DataUsuario()
        /// datu.Nombre = "juan";
        /// 
        /// </summary>
        public string Nombre   // property
        {
            get { return nombre; }   // get method
            set { apellido = value; }  // set method
        }

        public string Apellido   // property
        {
            get; set;
        }



    }
}
