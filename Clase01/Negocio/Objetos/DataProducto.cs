using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Objetos
{
    public class DataProducto
    {
        private string id;
        private string codigo;
        private string descripcion;
        private string precio;
        
        public string Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }             
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Precio { get => precio; set => precio = value; }

        public DataProducto()
        {
        }
    }
}
