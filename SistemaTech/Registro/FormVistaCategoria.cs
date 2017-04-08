using BLL;
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
    public partial class FormVistaCategoria : Form
    {
        public List<Categoria> Lista { get; set; }

 

        public FormVistaCategoria()
        {
            InitializeComponent();
           
        }

        private void FormVistaCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void OcultarCulunas()
        {
            dataListadoCategoria.Columns[0].Visible = false;
            dataListadoCategoria.Columns[1].Visible = true;

        }

        private void Listar()
        {

            if (comboBox1.SelectedIndex == 0)
            {

                Lista =CategoriaBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista =CategoriaBLL.GetList(p => p.Nombre == textBox1.Text);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = false;
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
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            else
            {

                textBox1.Clear();
                dataListadoCategoria.DataSource = null;


            }
        }

        private void dataListadoCategoria_DoubleClick(object sender, EventArgs e)
        {
            FormProductos frm =  FormProductos.GetInstancia();
            string var1, var2;
           
            var1 = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["CategoriaId"].Value);
            var2 = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Nombre"].Value);




            frm.setCategoria(var1, var2);
            

            this.Hide();
            
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataListadoCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataListadoCategoria_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
