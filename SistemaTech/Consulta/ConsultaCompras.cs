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
    public partial class ConsultaCompras : Form
    {
        public bool IsNuevo = false;
        public List<Ingreso> Lista { get; set; }
        public FormCompras frm = new FormCompras();

        public ConsultaCompras()
        {
            InitializeComponent();
        }

        private void OcultarCulunas()
        {
            dataListado.Columns[0].Visible = false;
            dataListado.Columns[1].Visible = false;
            
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
        private void Listar()
        {
            Lista = IngresoBLL.GetListAll();

            if (comboBox1.SelectedIndex == 0)
            {

                Lista = IngresoBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.IngresoBLL.GetList(p => p.IngresoId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = BLL.IngresoBLL.GetList(p => p.Fecha_Ingreso >= dtFecha1.Value.Date && p.Fecha_Ingreso <= dtFecha2.Value.Date);

            }
          

            dataListado.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void ConsultaCompras_Load(object sender, EventArgs e)
        {

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
                dtFecha1.Enabled = false;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                dtFecha2.Enabled = false;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = false;
                btnFiltrar.Enabled = true;
                dtFecha2.Enabled = true;
                dtFecha1.Enabled = true;
                Listar();
                OcultarCulunas();
            }
        
            else
            {

                textBox1.Clear();

                dataListado.DataSource = null;


            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opc;
                Opc = MessageBox.Show("Realmente desea Anular los registros", "....Sistema De Almacen....", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opc == DialogResult.OK)
                {
                    int Codigo = Utilidades.TOINT(frm.CompraTextBox.Text); ;

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            if (ProductosBLL.Eliminar(ProductosBLL.Buscar(p => p.ProductoId == Codigo)))
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
