namespace SistemaTech.Registro
{
    partial class FormPresentacion
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataListadoPresentacion = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PresentacionIdTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminae = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            productoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productoIdLabel
            // 
            productoIdLabel.AutoSize = true;
            productoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoIdLabel.ForeColor = System.Drawing.Color.Maroon;
            productoIdLabel.Location = new System.Drawing.Point(35, 37);
            productoIdLabel.Name = "productoIdLabel";
            productoIdLabel.Size = new System.Drawing.Size(124, 16);
            productoIdLabel.TabIndex = 0;
            productoIdLabel.Text = "PresentancionId:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.Color.Maroon;
            descripcionLabel.Location = new System.Drawing.Point(65, 134);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(95, 16);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.Maroon;
            nombreLabel.Location = new System.Drawing.Point(93, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 16);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 21);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.Todos",
            "2.Id",
            "2.Nombres",
            "3.Despripcion"});
            this.comboBox1.Location = new System.Drawing.Point(25, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataListadoPresentacion
            // 
            this.dataListadoPresentacion.AllowUserToAddRows = false;
            this.dataListadoPresentacion.AllowUserToDeleteRows = false;
            this.dataListadoPresentacion.AllowUserToOrderColumns = true;
            this.dataListadoPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoPresentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListadoPresentacion.Location = new System.Drawing.Point(25, 93);
            this.dataListadoPresentacion.Name = "dataListadoPresentacion";
            this.dataListadoPresentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoPresentacion.Size = new System.Drawing.Size(538, 150);
            this.dataListadoPresentacion.TabIndex = 7;
            this.dataListadoPresentacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoPresentacion_CellContentClick);
            this.dataListadoPresentacion.DoubleClick += new System.EventHandler(this.dataListadoPresentacion_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // PresentacionIdTextBox
            // 
            this.PresentacionIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PresentacionIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PresentacionIdTextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentacionIdTextBox.Location = new System.Drawing.Point(162, 34);
            this.PresentacionIdTextBox.Name = "PresentacionIdTextBox";
            this.PresentacionIdTextBox.Size = new System.Drawing.Size(100, 24);
            this.PresentacionIdTextBox.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.descripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcionTextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(162, 110);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionTextBox.Size = new System.Drawing.Size(256, 61);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreTextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(162, 69);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(256, 24);
            this.nombreTextBox.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(370, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "&Eliminar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(491, 23);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(72, 33);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(407, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(326, 23);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 33);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminae);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(productoIdLabel);
            this.groupBox1.Controls.Add(this.PresentacionIdTextBox);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(17, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presentacion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::SistemaTech.Properties.Resources.Search_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(278, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminae
            // 
            this.btnEliminae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminae.ForeColor = System.Drawing.Color.Black;
            this.btnEliminae.Image = global::SistemaTech.Properties.Resources.Delete_26px_1;
            this.btnEliminae.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminae.Location = new System.Drawing.Point(334, 222);
            this.btnEliminae.Name = "btnEliminae";
            this.btnEliminae.Size = new System.Drawing.Size(84, 34);
            this.btnEliminae.TabIndex = 6;
            this.btnEliminae.Text = "E&liminar";
            this.btnEliminae.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminae.UseVisualStyleBackColor = true;
            this.btnEliminae.Click += new System.EventHandler(this.btnEliminae_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::SistemaTech.Properties.Resources.Save_26px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(215, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = global::SistemaTech.Properties.Resources.Create_New_32px;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(105, 221);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(81, 34);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro De Presentacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dataListadoPresentacion);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnFiltrar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado De Presentacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Presentacion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 319);
            this.tabControl1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaTech.Properties.Resources.testtube;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(177, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 62);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPresentacion";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.FormPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminae;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataListadoPresentacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox PresentacionIdTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}