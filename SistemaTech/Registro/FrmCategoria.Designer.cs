namespace SistemaTech.Registro
{
    partial class FrmCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodigotextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriaIdTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminae = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            productoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productoIdLabel
            // 
            productoIdLabel.AutoSize = true;
            productoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoIdLabel.ForeColor = System.Drawing.Color.Black;
            productoIdLabel.Location = new System.Drawing.Point(29, 37);
            productoIdLabel.Name = "productoIdLabel";
            productoIdLabel.Size = new System.Drawing.Size(97, 16);
            productoIdLabel.TabIndex = 0;
            productoIdLabel.Text = "Categoria Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.Color.Black;
            descripcionLabel.Location = new System.Drawing.Point(34, 155);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(95, 16);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(62, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 16);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Categorias";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 319);
            this.tabControl1.TabIndex = 16;
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
            this.tabPage2.Text = "Registro De Categoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CodigotextBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminae);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(productoIdLabel);
            this.groupBox1.Controls.Add(this.CategoriaIdTextBox);
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
            this.groupBox1.Text = "Categoria";
            // 
            // CodigotextBox2
            // 
            this.CodigotextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CodigotextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodigotextBox2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigotextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CodigotextBox2.Location = new System.Drawing.Point(131, 105);
            this.CodigotextBox2.Name = "CodigotextBox2";
            this.CodigotextBox2.Size = new System.Drawing.Size(256, 24);
            this.CodigotextBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo:";
            // 
            // CategoriaIdTextBox
            // 
            this.CategoriaIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CategoriaIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoriaIdTextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaIdTextBox.Location = new System.Drawing.Point(131, 34);
            this.CategoriaIdTextBox.Name = "CategoriaIdTextBox";
            this.CategoriaIdTextBox.Size = new System.Drawing.Size(100, 24);
            this.CategoriaIdTextBox.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.descripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcionTextBox.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(131, 140);
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
            this.nombreTextBox.Location = new System.Drawing.Point(131, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(256, 24);
            this.nombreTextBox.TabIndex = 1;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaTech.Properties.Resources.My_Icons;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(151, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 62);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::SistemaTech.Properties.Resources.Search_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(249, 25);
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
            this.btnEliminae.Location = new System.Drawing.Point(315, 223);
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
            this.btnGuardar.Location = new System.Drawing.Point(197, 223);
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
            this.btnNuevo.Location = new System.Drawing.Point(81, 222);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(81, 34);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminae;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox CategoriaIdTextBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
        public System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.TextBox CodigotextBox2;
    }
}