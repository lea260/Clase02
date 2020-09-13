using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Objetos;
using Presentacion.Helpers;

namespace Presentacion.Formularios
{
    public partial class AgregarProducto : Form
    {
        Modo modo;
        public AgregarProducto()
        {
            InitializeComponent();               
        }
        public AgregarProducto(DataProducto prod, Modo modo)
        {
            InitializeComponent();
            this.modo = modo;
            Iniciar(prod);
        }

        public void Iniciar()
        {
            txtid.Text = "12";
            txtcodigo.Text = "codigo";
            txtprecio.Text = "asdf";
            txtdescription.Text = "dfdf";
            dtpfecha.Value = new DateTime(2020, 7, 29);
        }
        public void Iniciar(DataProducto prod)
        {
            txtid.Text = prod.Id_productos.ToString();
            txtcodigo.Text = prod.Codigo.ToString();
            txtprecio.Text = prod.Precio.ToString();
            txtdescription.Text = prod.Descripcion;
            dtpfecha.Value = prod.Fecha;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("seguro que desea\r\n agregar", "salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                //llamar a agregar 
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
    }
}
