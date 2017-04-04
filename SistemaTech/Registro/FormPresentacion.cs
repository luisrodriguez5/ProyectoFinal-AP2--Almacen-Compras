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
    public partial class FormPresentacion : Form
    {
        public bool IsNuevo = false;
        public List<Presentacion> Lista { get; set; }
        public bool Editar = false;
        public FormPresentacion()
        {
            InitializeComponent();
            
            this.toolTip1.SetToolTip(this.nombreTextBox, "Ingrese El Nombre De Presentacion");
            this.toolTip1.SetToolTip(this.descripcionTextBox, "Ingrese La Descripcion Que pertenece La Presentacion");
        }

        private Presentacion LlenarCampos()
        {
            Presentacion presentacion = new Presentacion();

            presentacion.PresentacionId = Utilidades.TOINT(PresentacionIdTextBox.Text);
            presentacion.Descripcion = descripcionTextBox.Text;
            presentacion.Nombre = nombreTextBox.Text;
           


            return presentacion;
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

            PresentacionIdTextBox.Clear();

        }

        private void Habilitar(bool valor)
        {
            nombreTextBox.ReadOnly = !valor;
            descripcionTextBox.ReadOnly = !valor;
            PresentacionIdTextBox.ReadOnly = !valor;
            textBox1.ReadOnly = !valor;

        }
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
            dataListadoPresentacion.Columns[0].Visible = false;
            dataListadoPresentacion.Columns[1].Visible = false;

        }


        private void Listar()
        {

            if (comboBox1.SelectedIndex == 0)
            {

                Lista = PresentacionBLL.GetListAll();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.PresentacionBLL.GetList(p => p.PresentacionId == id);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = PresentacionBLL.GetList(p => p.Nombre == textBox1.Text);

            }
            if (comboBox1.SelectedIndex == 3)
            {
                Lista = BLL.PresentacionBLL.GetList(p => p.Descripcion == textBox1.Text);

            }
          

            dataListadoPresentacion.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListadoPresentacion.Rows.Count);
        }

        private void FormPresentacion_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            Habilitar(false);
            Botones();
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
                dataListadoPresentacion.DataSource = null;


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
        


            return interruptor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = new Presentacion();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                presentacion = LlenarCampos();

                if (PresentacionBLL.Guardar(presentacion))
                {
                    MesajeOk("Se Guardo con exito");
                    Limpiar();
                }
                else
                    MesajeError("Error! no se pudo guardar.");
            }
        }

        private void dataListadoPresentacion_DoubleClick(object sender, EventArgs e)
        {
            this.PresentacionIdTextBox.Text = Convert.ToString(dataListadoPresentacion.CurrentRow.Cells["PresentacionId"].Value);
           
            this.nombreTextBox.Text = Convert.ToString(dataListadoPresentacion.CurrentRow.Cells["Nombre"].Value);
            this.descripcionTextBox.Text = Convert.ToString(dataListadoPresentacion.CurrentRow.Cells["Descripcion"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void dataListadoPresentacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoPresentacion.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoPresentacion.Rows[e.RowIndex].Cells["Eliminar"];
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
                    int Codigo = Utilidades.TOINT(PresentacionIdTextBox.Text); ;

                    foreach (DataGridViewRow row in dataListadoPresentacion.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            if (PresentacionBLL.Eliminar(PresentacionBLL.Buscar(p => p.PresentacionId == Codigo)))
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

            if (string.IsNullOrEmpty(PresentacionIdTextBox.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id del Producto a Eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (eliminar == DialogResult.OK)
                {
                    int id = Utilidades.TOINT(PresentacionIdTextBox.Text);

                    if (PresentacionBLL.Eliminar(PresentacionBLL.Buscar(p => p.PresentacionId == id)))
                    {
                        Limpiar();
                        MesajeOk("Producto Eliminado con exito");
                    }
                    else
                        MesajeError("No se ah podido Eliminar el producto");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminae.Enabled = true;
            btnGuardar.Enabled = true;
            if (string.IsNullOrEmpty(PresentacionIdTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(PresentacionIdTextBox.Text);
                Presentacion presentacion = new Presentacion();

                presentacion = PresentacionBLL.Buscar(p => p.PresentacionId == id);

                if (presentacion != null)
                {
                    descripcionTextBox.Text = presentacion.Descripcion;
                    nombreTextBox.Text = presentacion.Nombre;
                  

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
                this.dataListadoPresentacion.Columns[0].Visible = true;
            }
            else
            {
                this.dataListadoPresentacion.Columns[0].Visible = false;
            }
        }
    }
}
