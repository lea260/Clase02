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
            /*
            DataProducto prod1 = new DataProducto();
            prod1.Id_productos= 1;
            prod1.Codigo = "codigo";
            prod1.Descripcion = "descripcion01";
            prod1.Precio = 12.0f;
            lista.Add(prod1);
            DataProducto prod2 = new DataProducto();
            prod1.Id_productos = 2;
            prod1.Codigo = "codigo01";
            prod1.Descripcion = "descripcion01";
            prod1.Precio = 15.f;
            lista.Add(prod1);
            prod2.Id_productos = 2;
            prod2.Codigo = "codigo02";
            prod2.Descripcion = "descripcion02";
            prod2.Precio = 2.2f;
            lista.Add(prod2);
            */
            ProductosRepo prodRep = new ProductosRepo();            
            List<ProductoEntidad> list2 = prodRep.ListarProductos();
            ///recorrer la lista 
            foreach (ProductoEntidad prod in list2)
            {                
                DataProducto producto = new DataProducto();
                producto.Id_productos = prod.Id_productos;
                producto.Codigo = prod.Codigo;
                producto.Descripcion = prod.Descripcion;
                producto.Precio = prod.Precio;
                producto.Fecha = prod.Fecha;
                lista.Add(producto);
            }
            
            return lista;
        }

    }
}
