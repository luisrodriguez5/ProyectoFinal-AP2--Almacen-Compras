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

namespace SistemaTech.Consulta
{
    public partial class FormConsultaProveedores : Form
    {
        public List<Proveedor> Lista { get; set; }
        FormProveedores frm = new FormProveedores();

        public FormConsultaProveedores()

        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }

        private void MesajeOk(string Mesaje)
        {
            MessageBox.Show(Mesaje, "Sistema De Almacen ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar mesaje de Erro
        private void MesajeError(string Mesaje)
        {
            MessageBox.Show(Mesaje, "Sistema De Almacen ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OcultarCulunas()
        {
            dataListadoProveedor.Columns[0].Visible = false;
            dataListadoProveedor.Columns[1].Visible = false;
            dataListadoProveedor.Columns[8].Visible = false;

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


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
            OcultarCulunas();
        }

        private void dataListadoProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoProveedor.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoProveedor.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opc;
                Opc = MessageBox.Show("Realmente desea Eliminar los registros", "....Sistema De Almacen....", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opc == DialogResult.OK)
                {
                    int Codigo = Utilidades.TOINT(frm.proveedorIdTextBox.Text);

                    foreach (DataGridViewRow row in dataListadoProveedor.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            if (ProveedorBLL.Eliminar(ProveedorBLL.Buscar(p => p.ProveedorId == Codigo)))
                            {
                                MesajeOk("Se Elimino correta mente el registro");

                            }
                            else
                            {
                                MesajeError("No ah podido eliminar el registro");
                            }
                        }
                    }
                    Listar();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void dataListadoProveedor_DoubleClick(object sender, EventArgs e)
        {
            this.frm.proveedorIdTextBox.Text = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["ProveedorId"].Value);
            this.frm.RazonSocialTextBox.Text = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["Razon_Social"].Value);
            this.frm.DireccionTextBox.Text = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["Direccion"].Value);
            this.frm.emailtextBox1.Text = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["Email"].Value);
            this.frm.maskedTextBox1.Text = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["Telefono"].Value);
            this.frm.texNumDocumento.Text = Convert.ToString(dataListadoProveedor.CurrentRow.Cells["Num_Documento"].Value);
     
            this.Hide();

            frm.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.dataListadoProveedor.Columns[0].Visible = true;
            }
            else
            {
                this.dataListadoProveedor.Columns[0].Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
