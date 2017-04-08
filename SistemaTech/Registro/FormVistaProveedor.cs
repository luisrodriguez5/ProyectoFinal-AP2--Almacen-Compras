using BLL;
using Entidades;
using SistemaTech.Registro;
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
    public partial class FormVistaProveedor : Form
    {
        public List<Proveedor> Lista { get; set; }
        public FormVistaProveedor()
        {
            InitializeComponent();
        }

        private void FormVistaProveedor_Load(object sender, EventArgs e)
        {

        }
        private void OcultarCulunas()
        {
            dataListadoProveedor.Columns[0].Visible = false;
            dataListadoProveedor.Columns[1].Visible = false;
            dataListadoProveedor.Columns[7].Visible = false;

        }

        private void Listar()
        {

            if (comboBox1.SelectedIndex == 0)
            {

                Lista = ProveedorBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.ProveedorBLL.GetList(p => p.ProveedorId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = ProveedorBLL.GetList(p => p.Direccion == textBox1.Text);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                Lista = BLL.ProveedorBLL.GetList(p => p.Razon_Social == textBox1.Text);

            }


            dataListadoProveedor.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListadoProveedor.Rows.Count);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataListadoProveedor_DoubleClick(object sender, EventArgs e)
        {
            FormCompras frm = FormCompras.GetInstancia();
            string var1, var2;
            var1 = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["ProveedorId"].Value);
            var2 = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["Razon_Social"].Value);
            frm.SetProveedor(var1, var2);
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
                btnFiltrar.Enabled = true;
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

                dataListadoProveedor.DataSource = null;


            }
        }
    }
}
