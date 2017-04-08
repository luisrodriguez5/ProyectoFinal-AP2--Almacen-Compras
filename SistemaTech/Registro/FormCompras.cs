using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTech.Registro
{
    public partial class FormCompras : Form
    {
        private static FormCompras _Instancia;
        private decimal Total = 0;
        private Detalle_Ingreso detalle;

        public static FormCompras GetInstancia()
        {
            if(_Instancia == null)
            {
                _Instancia = new FormCompras();
            }
            return _Instancia;
        }
        public void SetProveedor(string proveedroId, string Nombre)
        {
            this.textProveedorId.Text = proveedroId;
            this.textProveedor.Text = Nombre;

        }

        public void SetProductos(string producto, string Nombre)
        {
            this.ArticulotextBox.Text = producto;
            this.textProductoId.Text = Nombre;
        }

       
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
           FormVistaProveedor frm = new FormVistaProveedor();
            frm.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FrmProductos_Ingreso frm = new FrmProductos_Ingreso();
            frm.ShowDialog();
        }
    }
}
