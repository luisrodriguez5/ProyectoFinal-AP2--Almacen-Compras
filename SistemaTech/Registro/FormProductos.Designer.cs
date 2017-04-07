namespace SistemaTech.Registro
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productoIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.texIdCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productoIdTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCategotia = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminae = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            productoIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // productoIdLabel
            // 
            productoIdLabel.AutoSize = true;
            productoIdLabel.Location = new System.Drawing.Point(6, 34);
            productoIdLabel.Name = "productoIdLabel";
            productoIdLabel.Size = new System.Drawing.Size(65, 13);
            productoIdLabel.TabIndex = 0;
            productoIdLabel.Text = "Producto Id:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(25, 104);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(37, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Costo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(15, 63);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(6, 149);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 319);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro De Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.btnBuscarCategotia);
            this.groupBox1.Controls.Add(this.texIdCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminae);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(productoIdLabel);
            this.groupBox1.Controls.Add(this.productoIdTextBox);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(485, 101);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(166, 21);
            this.comboBoxCategoria.TabIndex = 18;
            // 
            // texIdCategoria
            // 
            this.texIdCategoria.Location = new System.Drawing.Point(486, 30);
            this.texIdCategoria.Name = "texIdCategoria";
            this.texIdCategoria.Size = new System.Drawing.Size(69, 20);
            this.texIdCategoria.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Presentacion:";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(485, 60);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(166, 20);
            this.textCategoria.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoria:";
            // 
            // productoIdTextBox
            // 
            this.productoIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.productoIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productoIdTextBox.Location = new System.Drawing.Point(78, 31);
            this.productoIdTextBox.Name = "productoIdTextBox";
            this.productoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.productoIdTextBox.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.descripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcionTextBox.Location = new System.Drawing.Point(78, 137);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionTextBox.Size = new System.Drawing.Size(256, 61);
            this.descripcionTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreTextBox.Location = new System.Drawing.Point(78, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(256, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.codigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTextBox.Location = new System.Drawing.Point(78, 102);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(256, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Productos";
            // 
            // btnBuscarCategotia
            // 
            this.btnBuscarCategotia.Image = global::SistemaTech.Properties.Resources.Search_24px;
            this.btnBuscarCategotia.Location = new System.Drawing.Point(657, 53);
            this.btnBuscarCategotia.Name = "btnBuscarCategotia";
            this.btnBuscarCategotia.Size = new System.Drawing.Size(56, 30);
            this.btnBuscarCategotia.TabIndex = 17;
            this.btnBuscarCategotia.UseVisualStyleBackColor = true;
            this.btnBuscarCategotia.Click += new System.EventHandler(this.btnBuscarCategotia_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SistemaTech.Properties.Resources.Search_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(194, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminae
            // 
            this.btnEliminae.Image = global::SistemaTech.Properties.Resources.Delete_26px_1;
            this.btnEliminae.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminae.Location = new System.Drawing.Point(262, 207);
            this.btnEliminae.Name = "btnEliminae";
            this.btnEliminae.Size = new System.Drawing.Size(72, 34);
            this.btnEliminae.TabIndex = 10;
            this.btnEliminae.Text = "E&liminar";
            this.btnEliminae.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminae.UseVisualStyleBackColor = true;
            this.btnEliminae.Click += new System.EventHandler(this.btnEliminae_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::SistemaTech.Properties.Resources.Save_26px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(161, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 34);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SistemaTech.Properties.Resources.Create_New_32px;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(62, 207);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 34);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Almacen";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminae;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCategotia;
        public System.Windows.Forms.TextBox texIdCategoria;
        public System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox productoIdTextBox;
        public System.Windows.Forms.TextBox codigoTextBox;
        public System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
        public System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}