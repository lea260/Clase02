﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Servicios;
using Negocio.Objetos;





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
            ProductosServicio servicio = new ProductosServicio();
            List<DataProducto> list = servicio.obtenerProductos();
            dgvProductos.DataSource = list;
            
        }
    }
}
