
namespace testFinal
{
    partial class FormNotas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox gbListado;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.dgvListadoNotas = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuerpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.gbCrearEditar = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labFecha = new System.Windows.Forms.Label();
            this.tbCuerpo = new System.Windows.Forms.TextBox();
            this.labCuerpo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.labTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labModoEdicion = new System.Windows.Forms.Label();
            gbListado = new System.Windows.Forms.GroupBox();
            gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).BeginInit();
            this.gbCrearEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            gbListado.Controls.Add(this.tbBuscador);
            gbListado.Controls.Add(this.dgvListadoNotas);
            gbListado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gbListado.Location = new System.Drawing.Point(421, 130);
            gbListado.Name = "gbListado";
            gbListado.Size = new System.Drawing.Size(383, 519);
            gbListado.TabIndex = 3;
            gbListado.TabStop = false;
            gbListado.Text = "Listado de Notas";
            // 
            // tbBuscador
            // 
            this.tbBuscador.Location = new System.Drawing.Point(5, 38);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(374, 27);
            this.tbBuscador.TabIndex = 4;
            this.tbBuscador.TextChanged += new System.EventHandler(this.tbBuscador_TextChanged);
            // 
            // dgvListadoNotas
            // 
            this.dgvListadoNotas.AllowUserToAddRows = false;
            this.dgvListadoNotas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Titulo,
            this.Cuerpo,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoNotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoNotas.Location = new System.Drawing.Point(5, 72);
            this.dgvListadoNotas.MultiSelect = false;
            this.dgvListadoNotas.Name = "dgvListadoNotas";
            this.dgvListadoNotas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoNotas.RowHeadersWidth = 51;
            this.dgvListadoNotas.RowTemplate.Height = 29;
            this.dgvListadoNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoNotas.Size = new System.Drawing.Size(371, 441);
            this.dgvListadoNotas.TabIndex = 0;
            this.dgvListadoNotas.DoubleClick += new System.EventHandler(this.dgvListadoNotas_CellDoubleClick);
           
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Id";
            this.Identificador.MinimumWidth = 6;
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Visible = false;
            this.Identificador.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // Cuerpo
            // 
            this.Cuerpo.HeaderText = "Cuerpo";
            this.Cuerpo.MinimumWidth = 6;
            this.Cuerpo.Name = "Cuerpo";
            this.Cuerpo.ReadOnly = true;
            this.Cuerpo.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Items.AddRange(new object[] {
            "Usuario 1",
            "Usuario 2",
            "Usuario 3",
            "Usuario 4"});
            this.cbUsuario.Location = new System.Drawing.Point(421, 48);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(383, 28);
            this.cbUsuario.TabIndex = 0;
            this.cbUsuario.Text = "Seleccione";
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.CbUsuario_SelectedIndexChanged);
            // 
            // gbCrearEditar
            // 
            this.gbCrearEditar.Controls.Add(this.btnLimpiar);
            this.gbCrearEditar.Controls.Add(this.btnGuardar);
            this.gbCrearEditar.Controls.Add(this.dtpFecha);
            this.gbCrearEditar.Controls.Add(this.labFecha);
            this.gbCrearEditar.Controls.Add(this.tbCuerpo);
            this.gbCrearEditar.Controls.Add(this.labCuerpo);
            this.gbCrearEditar.Controls.Add(this.tbTitulo);
            this.gbCrearEditar.Controls.Add(this.labTitulo);
            this.gbCrearEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCrearEditar.Location = new System.Drawing.Point(22, 130);
            this.gbCrearEditar.Name = "gbCrearEditar";
            this.gbCrearEditar.Size = new System.Drawing.Size(383, 519);
            this.gbCrearEditar.TabIndex = 2;
            this.gbCrearEditar.TabStop = false;
            this.gbCrearEditar.Text = "Crear/Editar Notas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(205, 458);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 39);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 458);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 378);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(348, 27);
            this.dtpFecha.TabIndex = 5;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(15, 337);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(50, 20);
            this.labFecha.TabIndex = 4;
            this.labFecha.Text = "Fecha:";
            // 
            // tbCuerpo
            // 
            this.tbCuerpo.Location = new System.Drawing.Point(15, 165);
            this.tbCuerpo.Multiline = true;
            this.tbCuerpo.Name = "tbCuerpo";
            this.tbCuerpo.Size = new System.Drawing.Size(348, 136);
            this.tbCuerpo.TabIndex = 3;
            // 
            // labCuerpo
            // 
            this.labCuerpo.AutoSize = true;
            this.labCuerpo.Location = new System.Drawing.Point(15, 141);
            this.labCuerpo.Name = "labCuerpo";
            this.labCuerpo.Size = new System.Drawing.Size(60, 20);
            this.labCuerpo.TabIndex = 2;
            this.labCuerpo.Text = "Cuerpo:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(15, 72);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(348, 27);
            this.tbTitulo.TabIndex = 1;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(15, 48);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(50, 20);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccion de usuario:";
            // 
            // labModoEdicion
            // 
            this.labModoEdicion.AutoSize = true;
            this.labModoEdicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labModoEdicion.Location = new System.Drawing.Point(20, 82);
            this.labModoEdicion.Name = "labModoEdicion";
            this.labModoEdicion.Size = new System.Drawing.Size(799, 40);
            this.labModoEdicion.TabIndex = 4;
            this.labModoEdicion.Text = "Usted se encuentra en modo edicion, para salir del estado presione el boton limpi" +
    "ar, la nota que se guarde se realizara \r\na la nota previamente seleccionada\r\n";
            this.labModoEdicion.Visible = false;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 669);
            this.Controls.Add(this.labModoEdicion);
            this.Controls.Add(gbListado);
            this.Controls.Add(this.gbCrearEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotas";
            this.Text = "Notas";
            gbListado.ResumeLayout(false);
            gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).EndInit();
            this.gbCrearEditar.ResumeLayout(false);
            this.gbCrearEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.GroupBox gbCrearEditar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.TextBox tbCuerpo;
        private System.Windows.Forms.Label labCuerpo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.DataGridView dgvListadoNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuerpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label labModoEdicion;
    }
}

