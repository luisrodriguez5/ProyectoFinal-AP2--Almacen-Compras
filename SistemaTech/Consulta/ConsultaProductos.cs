using BLL;
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
    public partial class ConsultaProductos : Form
    {
        public bool IsNuevo = false;
        public List<Entidades.Productos> Lista { get; set; }
        public bool Editar = false;
        FormProductos frm = new FormProductos();

        public ConsultaProductos()
        {
            InitializeComponent();
        }

       

        private void OcultarCulunas()
        {
            dataListadoProducto.Columns[0].Visible = false;
            dataListadoProducto.Columns[1].Visible = false;
            dataListadoProducto.Columns[7].Visible = false;
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            Listar();
            OcultarCulunas();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.dataListadoProducto.Columns[0].Visible = true;
            }
            else
            {
                this.dataListadoProducto.Columns[0].Visible = false;
            }
        }

        private void dataListadoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoProducto.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoProducto.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opc;
                Opc = MessageBox.Show("Realmente desea Eliminar los registros", "....Sistema De Almacen....", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opc == DialogResult.OK)
                {
                    int Codigo = Utilidades.TOINT(frm.productoIdTextBox.Text); ;

                    foreach (DataGridViewRow row in dataListadoProducto.Rows)
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

        private void dataListadoProducto_DoubleClick(object sender, EventArgs e)
        {
            this.frm.productoIdTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["ProductoId"].Value);
            this.frm.codigoTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Costo"].Value);
            this.frm.nombreTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Nombre"].Value);
            this.frm.descripcionTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Descripcion"].Value);
            this.frm.texIdCategoria.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["CategoriaId"].Value);
            this.frm.textCategoria.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Nombre"].Value);
            this.frm.comboBoxCategoria.SelectedValue = Convert.ToString(dataListadoProducto.CurrentRow.Cells["PresentacionId"].Value);

            this.Hide();

            frm.Show();
            
           
        }
    }
}
