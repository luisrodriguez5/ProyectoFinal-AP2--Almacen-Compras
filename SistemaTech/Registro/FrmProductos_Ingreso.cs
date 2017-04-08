using BLL;
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
    public partial class FrmProductos_Ingreso : Form
    {
        public List<Entidades.Productos> Lista { get; set; }
        public FrmProductos_Ingreso()
        {
            InitializeComponent();
        }

        private void FrmProductos_Ingreso_Load(object sender, EventArgs e)
        {
            Listar();
            OcultarCulunas();
        }


      

        private void OcultarCulunas()
        {
          
            dataListadoProducto.Columns[0].Visible = false;
            dataListadoProducto.Columns[4].Visible = false;
            dataListadoProducto.Columns[7].Visible = false;
            dataListadoProducto.Columns[8].Visible = false;

        }
        private void Listar()
        {
            Lista = ProductosBLL.GetListAll();
            if (comboBox1.SelectedIndex == 0)
            {

                Lista = ProductosBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.ProductosBLL.GetList(p => p.ProductoId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = ProductosBLL.GetList(p => p.Nombre == textBox1.Text);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                Lista = BLL.ProductosBLL.GetList(p => p.Descripcion == textBox1.Text);

            }

            dataListadoProducto.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListadoProducto.Rows.Count);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataListadoProducto_DoubleClick(object sender, EventArgs e)
        {
            FormCompras frm = FormCompras.GetInstancia();
            string var1, var2;
            var1 = Convert.ToString(dataListadoProducto.CurrentRow.Cells["ProductoId"].Value);
            var2 = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Nombre"].Value);

            frm.SetProductos(var2, var1);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFiltrar.Enabled = false;


            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = false;
                btnFiltrar.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                btnFiltrar.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                btnFiltrar.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            else
            {

                textBox1.Clear();

                dataListadoProducto.DataSource = null;


            }
        }
    }
}
