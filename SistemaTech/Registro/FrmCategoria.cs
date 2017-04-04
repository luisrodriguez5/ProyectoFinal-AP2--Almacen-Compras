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
    public partial class FrmCategoria : Form
    {
        public bool IsNuevo = false;
        public List<Categoria>Lista { get; set; }
        public bool Editar = false;

        public FrmCategoria()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.nombreTextBox, "Ingrese El Nombre De La Categoria");
            this.toolTip1.SetToolTip(this.CodigotextBox2, "Ingrese El Codigo de la Categoria");
            this.toolTip1.SetToolTip(this.descripcionTextBox, "Ingrese La Descripcion Que pertenece La Categoria");
        }

        private Categoria LlenarCampos()
        {
            Categoria categoria = new Categoria();

            categoria.CategoriaId = Utilidades.TOINT(CategoriaIdTextBox.Text);
            categoria.Descripcion = descripcionTextBox.Text;
            categoria.Nombre = nombreTextBox.Text;
            categoria.Codigo = Utilidades.TOINT(CodigotextBox2.Text);


            return categoria;
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
        private void Limpiar()
        {
            nombreTextBox.Clear();
            descripcionTextBox.Clear();
            CodigotextBox2.Clear();
            CategoriaIdTextBox.Clear();

        }
        //Habilitar Controles
        private void Habilitar(bool valor)
        {
            nombreTextBox.ReadOnly = !valor;
            descripcionTextBox.ReadOnly = !valor;
            CodigotextBox2.ReadOnly = !valor;
            CategoriaIdTextBox.ReadOnly = !valor;
            textBox1.ReadOnly = !valor;

        }

        //Habilitar Botones
        private void Botones()
        {
            if (IsNuevo || Editar)
            {
                Habilitar(true);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminae.Enabled = false;
                btnFiltrar.Enabled = true;
            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminae.Enabled = false;
                btnFiltrar.Enabled = false;
            }
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

                Lista = PresentancionBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.PresentancionBLL.GetList(p => p.CategoriaId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = PresentancionBLL.GetList(p => p.Nombre == textBox1.Text);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                Lista = BLL.PresentancionBLL.GetList(p => p.Descripcion == textBox1.Text);

            }
            if(comboBox1.SelectedIndex == 4)
            {
                int codigo = Utilidades.TOINT(textBox1.Text);
                Lista = PresentancionBLL.GetList(P => P.Codigo == codigo);
            }

            dataListadoCategoria.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListadoCategoria.Rows.Count);
        }


        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            Habilitar(false);
            Botones();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
            OcultarCulunas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsNuevo = true;
            Botones();
            Habilitar(true);

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;

            Botones();
            Limpiar();
            Habilitar(true);
            nombreTextBox.Focus();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                errorProvider1.SetError(descripcionTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CodigotextBox2.Text))
            {
                errorProvider1.SetError(CodigotextBox2, "Por favor llenar el campo vacio.");
                interruptor = false;
            }


            return interruptor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                categoria = LlenarCampos();

                if (PresentancionBLL.Guardar(categoria))
                {
                    MesajeOk("Se Guardo con exito");
                    Limpiar();
                }
                else
                    MesajeError("Error! no se pudo guardar.");
            }

        }

        private void dataListadoCategoria_DoubleClick(object sender, EventArgs e)
        {
            this.CategoriaIdTextBox.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["CategoriaId"].Value);
            this.CodigotextBox2.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Codigo"].Value);
            this.nombreTextBox.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Nombre"].Value);
            this.descripcionTextBox.Text = Convert.ToString(dataListadoCategoria.CurrentRow.Cells["Descripcion"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminae.Enabled = true;
            btnGuardar.Enabled = true;
            if (string.IsNullOrEmpty(CategoriaIdTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(CategoriaIdTextBox.Text);
                Categoria categoria = new Categoria();

                categoria = PresentancionBLL.Buscar(p => p.CategoriaId == id);

                if (categoria != null)
                {
                    descripcionTextBox.Text = categoria.Descripcion;
                    nombreTextBox.Text = categoria.Nombre;
                    CodigotextBox2.Text = categoria.Codigo.ToString();
                   
                }
                else
                {
                    MessageBox.Show("El Producto no exite.");
                    Limpiar();
                }
            }
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
                    int Codigo = Utilidades.TOINT(CategoriaIdTextBox.Text); ;

                    foreach (DataGridViewRow row in dataListadoCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            if (PresentancionBLL.Eliminar(PresentancionBLL.Buscar(p => p.CategoriaId == Codigo)))
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

        private void btnEliminae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoriaIdTextBox.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id del Producto a Eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (eliminar == DialogResult.OK)
                {
                    int id = Utilidades.TOINT(CategoriaIdTextBox.Text);

                    if (PresentancionBLL.Eliminar(PresentancionBLL.Buscar(p => p.CategoriaId == id)))
                    {
                        Limpiar();
                        MesajeOk("Producto Eliminado con exito");
                    }
                    else
                        MesajeError("No se ah podido Eliminar el producto");
                }
            }
        }
    }
}
