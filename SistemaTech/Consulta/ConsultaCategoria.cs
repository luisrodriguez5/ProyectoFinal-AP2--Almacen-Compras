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
    public partial class ConsultaCategoria : Form
    {
        public bool IsNuevo = false;
        public List<Categoria> Lista { get; set; }
        public bool Editar = false;
        FrmCategoria frm = new FrmCategoria();


        public ConsultaCategoria()
        {
            InitializeComponent();
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
            dataListadoCategoria.Columns[0].Visible = false;
            dataListadoCategoria.Columns[1].Visible = false;

        }

        private void Listar()
        {

            if (comboBox1.SelectedIndex == 0)
            {

                Lista = CategoriaBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = CategoriaBLL.GetList(p => p.Nombre == textBox1.Text);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                Lista = BLL.CategoriaBLL.GetList(p => p.Descripcion == textBox1.Text);

            }
            if (comboBox1.SelectedIndex == 4)
            {
                int codigo = Utilidades.TOINT(textBox1.Text);
                Lista = CategoriaBLL.GetList(P => P.Codigo == codigo);
            }

            dataListadoCategoria.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListadoCategoria.Rows.Count);
        }


        private void ConsultaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.dataListadoCategoria.Columns[0].Visible = true;
            }
            else
            {
                this.dataListadoCategoria.Columns[0].Visible = false;
            }
        }

        private void dataListadoCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoCategoria.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoCategoria.Rows[e.RowIndex].Cells["Eliminar"];
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
                    int Codigo = Utilidades.TOINT(frm.CategoriaIdTextBox.Text); ;

                    foreach (DataGridViewRow row in dataListadoCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            if (CategoriaBLL.Eliminar(CategoriaBLL.Buscar(p => p.CategoriaId == Codigo)))
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

        private void dataListadoCategoria_DoubleClick(object sender, EventArgs e)
        {
            this.frm.CategoriaIdTextBox.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["CategoriaId"].Value);
            this.frm.CodigotextBox2.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Codigo"].Value);
            this.frm.nombreTextBox.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Nombre"].Value);
            this.frm.descripcionTextBox.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Descripcion"].Value);
            this.tabControl1.SelectedIndex = 1;


            this.Hide();

            frm.Show();
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

                dataListadoCategoria.DataSource = null;


            }

        }
    }
}
