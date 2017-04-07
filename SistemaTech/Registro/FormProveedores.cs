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
    public partial class FormProveedores : Form
    {
        private bool isNuevo = false;
        private bool Editar = false;



        public FormProveedores()
        {
            InitializeComponent();

        }

        private Proveedor LlenarCampos()
        {
            Proveedor proveedor = new Proveedor();

            proveedor.ProveedorId = Utilidades.TOINT(proveedorIdTextBox.Text);
            proveedor.Razon_Social = RazonSocialTextBox.Text;
            proveedor.Num_Documento = Utilidades.TOINT(texNumDocumento.Text);
            proveedor.Sector_Comercial= comboBoxSector.Text;
            proveedor.Direccion = DireccionTextBox.Text;
            proveedor.Telefono = maskedTextBox1.Text;


            return proveedor;
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
           RazonSocialTextBox.Clear();
           maskedTextBox1.Clear();
           emailtextBox1.Clear();
           texNumDocumento.Clear();
           DireccionTextBox.Clear();
           proveedorIdTextBox.Clear();
        }
        //Habilitar Controles
        private void Habilitar(bool valor)
        {
            RazonSocialTextBox.ReadOnly = !valor;
            DireccionTextBox.ReadOnly = !valor;
            comboBoxSector.Enabled = valor;
            comboBoxDocument.Enabled = valor;
            texNumDocumento.ReadOnly = !valor;
            maskedTextBox1.ReadOnly = !valor;
            emailtextBox1.ReadOnly = !valor;


        }

        //Habilitar Botones
        private void Botones()
        {
            if (isNuevo || Editar)
            {
                Habilitar(true);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminae.Enabled = false;
            }

            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminae.Enabled = false;

            }
        }


        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                errorProvider1.SetError(DireccionTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrWhiteSpace(RazonSocialTextBox.Text))
            {
                errorProvider1.SetError(RazonSocialTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(comboBoxDocument.Text))
            {
                errorProvider1.SetError(comboBoxDocument, "Por favor selcionar un tipo de documento.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(texNumDocumento.Text))
            {
                errorProvider1.SetError(texNumDocumento, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(comboBoxSector.Text))
            {
                errorProvider1.SetError(comboBoxSector, "Por favor selecione un sector.");
                interruptor = false;
            }


            return interruptor;
        }


        private void FormProveedores_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Habilitar(false);
            Botones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                proveedor = LlenarCampos();

                if (ProveedorBLL.Guardar(proveedor))
                {
                    MesajeOk("Se Guardo con exito");
                    Limpiar();
                }
                else
                    MesajeError("Error! no se pudo guardar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminae.Enabled = true;
            btnGuardar.Enabled = true;
            if (string.IsNullOrEmpty(proveedorIdTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(proveedorIdTextBox.Text);
                Proveedor proveedor = new Proveedor();

                proveedor = ProveedorBLL.Buscar(p => p.ProveedorId == id);

                if (proveedor != null)
                {
                    DireccionTextBox.Text = proveedor.Direccion;
                    RazonSocialTextBox.Text = proveedor.Razon_Social;
                    texNumDocumento.Text = proveedor.Num_Documento.ToString();
                    comboBoxSector.Text = proveedor.Sector_Comercial;
                    maskedTextBox1.Text = proveedor.Telefono;
                    emailtextBox1.Text = proveedor.Email;

                }
                else
                {
                    MessageBox.Show("El Producto no exite.");
                    Limpiar();
                }
            }
        }

        private void btnEliminae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(proveedorIdTextBox.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id del Producto a Eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (eliminar == DialogResult.OK)
                {
                    int id = Utilidades.TOINT(proveedorIdTextBox.Text);

                    if (ProveedorBLL.Eliminar(ProveedorBLL.Buscar(p => p.ProveedorId == id)))
                    {
                        Limpiar();
                        MesajeOk("Producto Eliminado con exito");
                    }
                    else
                        MesajeError("No se ah podido Eliminar el producto");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
