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
    public partial class FormCompras : Form
    {
        private static FormCompras _Instancia;
        private decimal Total = 0;
        public List<Ingreso> Lista { get; set; }
        Productos producto = null;
        private Detalle_Ingreso detalle;
        private DataTable _detalle;
        public bool isNuevo = false;

        public static FormCompras GetInstancia()
        {
            if(_Instancia == null)
            {
                _Instancia = new FormCompras();
            }
            return _Instancia;
        }
        public void SetProveedor(string proveedroId, string Nombre)
        {
            this.textProveedorId.Text = proveedroId;
            this.textProveedor.Text = Nombre;

        }

        public void SetProductos(string producto, string Nombre)
        {
            this.ArticulotextBox.Text = producto;
            this.textProductoId.Text = Nombre;
        }

       
        public FormCompras()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.textProveedor, "Selecione El Proveedor");
            this.toolTip1.SetToolTip(this.NumeroTextBox, "Ingrese el numero de Comprovante");
            this.toolTip1.SetToolTip(this.textStock, "Ingrese la cantidad de los productos");
            this.toolTip1.SetToolTip(this.ArticulotextBox, "Selecione Un producto de Compra");
            textProveedorId.Visible = false;
            CompraTextBox.Visible = false;
            textProveedor.ReadOnly = true;
            ArticulotextBox.ReadOnly = true;


        }

        //Motrar mesaje de confirmacion
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
            CompraTextBox.Clear();
            textProveedor.Clear();
            textProveedorId.Clear();
            NumeroTextBox.Clear();
            itbiStextBox.Clear();
            lblresult.Text = "0.0";
            itbiStextBox.Text = "18%";
            this.CrearTabla();
        }
        private void LimpiarDetalle()
        {
            ArticulotextBox.Clear();
            textStock.Clear();
            textProductoId.Clear();
            textPrcioCompra.Clear();

        }

        //Habilitar Controles
        private void Habilitar(bool valor)
        {
            CompraTextBox.ReadOnly = !valor;
            comboBox1.Enabled = valor;
            itbiStextBox.ReadOnly = !valor;
            dateFecha.Enabled = valor;
            textProveedor.ReadOnly = !valor;
            textStock.ReadOnly = !valor;
            NumeroTextBox.ReadOnly = !valor;
            textPrcioCompra.ReadOnly = !valor;
            dateTimePicker1.Enabled = valor;
            dateTimePicker2.Enabled = valor;

            btnBuscarArticulo.Enabled = valor;
            btnBuscarProveedor.Enabled = valor;
            button1.Enabled = valor;
            button2.Enabled = valor;



        }
        //Habilitar Botones
        private void Botones()
        {
            if (isNuevo )
            {
                Habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEliminae.Enabled = true;

            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminae.Enabled = false;
                

            }
        }
        private void MostrarDetalle()
        {
            Lista = IngresoBLL.GetListAll();
            dataGridView1.DataSource = Lista;

        }


        private void FormCompras_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Habilitar(false);
            Botones();
            CrearTabla();

        }

        private void CrearTabla()
        {
            this._detalle = new DataTable("Detalles");
            this._detalle.Columns.Add("ProductoId", System.Type.GetType("System.Int32"));
            this._detalle.Columns.Add("Nombre", System.Type.GetType("System.String"));
            this._detalle.Columns.Add("Precio_Compra" , System.Type.GetType("System.Decimal"));
            this._detalle.Columns.Add("Inventario_Inicial", System.Type.GetType("System.Int32"));
            this._detalle.Columns.Add("Fecha_Producion", System.Type.GetType("System.DateTime"));
            this._detalle.Columns.Add("Fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this._detalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this._detalle.Columns.Add("Impuesto", System.Type.GetType("System.Decimal"));

            this.dataGridView1.DataSource = this._detalle;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
           FormVistaProveedor frm = new FormVistaProveedor();
            frm.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FrmProductos_Ingreso frm = new FrmProductos_Ingreso();
            frm.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;

            Botones();
            Limpiar();
            Habilitar(true);
            NumeroTextBox.Focus();
            LimpiarDetalle();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(NumeroTextBox.Text))
            {
                errorProvider1.SetError(NumeroTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            /*if (string.IsNullOrWhiteSpace(textProveedor.Text))
            {
                errorProvider1.SetError(textProveedor, "Por favor Selecione Un proveedor.");
                interruptor = false;
            }*/
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Por favor selecione un tipo de comprovante.");
                interruptor = false;
            }
            /*if (string.IsNullOrEmpty(ArticulotextBox.Text))
            {
                errorProvider1.SetError(ArticulotextBox, "Por favor selecione un Articulo.");

                interruptor = false;
            }*/
            if (string.IsNullOrEmpty(textStock.Text))
            {
                errorProvider1.SetError(textStock, "Por Ingrese La cantidad Inicial.");
                interruptor = false;
            }



            return interruptor;
        }

        private Ingreso LlenarCampos()
        {
            Ingreso ingreso = new Ingreso();
            producto = new Productos();

            ingreso.IngresoId = Utilidades.TOINT(CompraTextBox.Text);
            ingreso.NumIngreso = Utilidades.TOINT(NumeroTextBox.Text);
            ingreso.Fecha = dateFecha.Value;
            ingreso.Itbis = Utilidades.TOINT(itbiStextBox.Text);
            ingreso.Costo_Compra = Utilidades.TOINT(textPrcioCompra.Text);
            ingreso.Inventario_Inicial = Utilidades.TOINT(textStock.Text);
            ingreso.Fecha_Ingreso = dateTimePicker1.Value;
            ingreso.Fecha_Vencimiento = dateTimePicker2.Value;
            producto.ProductoId = Utilidades.TOINT(textProductoId.Text);
            producto.Nombre = ArticulotextBox.Text;
            //ingreso.Proveedor.ProveedorId = Utilidades.TOINT(textProveedorId.Text);
            //ingreso.Proveedor.Razon_Social = textProveedor.Text;
            //ingreso.Detalle.ProductoId = Utilidades.TOINT(textProductoId.Text);
            //ingreso.ProvedorId = Utilidades.TOINT(textProveedorId.Text);

            return ingreso;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                ingreso = LlenarCampos();

                if (IngresoBLL.Guardar(ingreso))
                {
                    MesajeOk("Se Guardo con exito");
                    Limpiar();
                }
                else
                    MesajeError("Error! no se pudo guardar.");
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool registrar = true;
            foreach(DataRow row in _detalle.Rows)
            {
                if (Convert.ToInt32(row["ProductoId"])== Convert.ToInt32(this.textProductoId))
                {
                    registrar = false;
                    this.MesajeError("Ya se encuentra este articulo");

                }
            }
            if(registrar)
            {
                decimal SubTotal = Convert.ToDecimal(textStock.Text) * Convert.ToDecimal(textPrcioCompra.Text);
                Total = Total + SubTotal;
                lblresult.Text = Total.ToString("#0.00#");

                DataRow row = this._detalle.NewRow();
                row["ProductoId"] = Convert.ToInt32(textProductoId.Text);
                row["Nombre"] = ArticulotextBox.Text;
                row["Precio_Compra"] = Convert.ToDecimal(textPrcioCompra.Text);
                row["Inventario_Inicial"] = Convert.ToInt32(textStock.Text);
                row["Fecha_Producion"] = dateTimePicker1.Value;
                row["Fecha_Vencimiento"] = dateTimePicker2.Value;
                row["SubTotal"] = SubTotal;
                this._detalle.Rows.Add(row);
                this.LimpiarDetalle();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Indice = this.dataGridView1.CurrentCell.RowIndex;
                DataRow row = _detalle.Rows[Indice];
                this.Total = Total - Convert.ToDecimal(row["SubTotal"].ToString());
                this.lblresult.Text = Total.ToString("#0.00#");
                this._detalle.Rows.Remove(row);


            }
            catch (Exception)
            {
                MesajeError("No se encuentra detalle para eliminar");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textProveedorId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
