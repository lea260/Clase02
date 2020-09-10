using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Objetos;
using Persistencia.Repositorios;
using Persistencia.Entidades;

namespace Negocio.Servicios
{
    /// <summary>
    /// voy a llamar a la persistencia.
    /// </summary>
    public class ProductosServicio
    {
        public List<DataProducto> obtenerProductos()
        {
            List<DataProducto> lista = new List<DataProducto>();
            DataProducto prod1 = new DataProducto();
            prod1.Id = "id01";
            prod1.Codigo = "codigo";
            prod1.Descripcion = "descripcion01";
            prod1.Precio = "descripcion01";
            lista.Add(prod1);
            DataProducto prod2 = new DataProducto();
            prod1.Id = "id01";
            prod1.Codigo = "codigo01";
            prod1.Descripcion = "descripcion01";
            prod1.Precio = "descripcion01";
            lista.Add(prod1);
            prod2.Id = "id02";
            prod2.Codigo = "codigo02";
            prod2.Descripcion = "descripcion02";
            prod2.Precio = "descripcion02";
            lista.Add(prod2);
            ProductosRepo prodRep = new ProductosRepo();
            List<ProductoEntidad> list2 = prodRep.ListarProductos();
            
            return lista;
        }

    }
}
