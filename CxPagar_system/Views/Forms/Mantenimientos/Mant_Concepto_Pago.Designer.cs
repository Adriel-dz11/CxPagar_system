namespace CxPagar_system.Views.Forms.Mant
{
    partial class Mant_Concepto_Pago
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIDCP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnUltimoReg = new FontAwesome.Sharp.IconButton();
            this.BtnSiguiente = new FontAwesome.Sharp.IconButton();
            this.BtnAnterior = new FontAwesome.Sharp.IconButton();
            this.BtnPrimerReg = new FontAwesome.Sharp.IconButton();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.CbEstado);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtIDCP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 350);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BnBuscar);
            this.groupBox1.Controls.Add(this.txtConsultar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(319, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 66);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // BnBuscar
            // 
            this.BnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BnBuscar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.BnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BnBuscar.IconSize = 25;
            this.BnBuscar.Location = new System.Drawing.Point(359, 17);
            this.BnBuscar.Name = "BnBuscar";
            this.BnBuscar.Size = new System.Drawing.Size(69, 43);
            this.BnBuscar.TabIndex = 17;
            this.BnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BnBuscar.UseVisualStyleBackColor = false;
            this.BnBuscar.Click += new System.EventHandler(this.BnBuscar_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(19, 24);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(334, 29);
            this.txtConsultar.TabIndex = 18;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.BtnEditar.IconColor = System.Drawing.Color.Khaki;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 35;
            this.BtnEditar.Location = new System.Drawing.Point(89, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(71, 66);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.LightCoral;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 35;
            this.BtnEliminar.Location = new System.Drawing.Point(166, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(71, 66);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAgregar.IconColor = System.Drawing.Color.LightGreen;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 35;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 12);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(71, 66);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Añadir";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(21, 198);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(340, 42);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtIDCP
            // 
            this.txtIDCP.Location = new System.Drawing.Point(21, 131);
            this.txtIDCP.Name = "txtIDCP";
            this.txtIDCP.Size = new System.Drawing.Size(89, 22);
            this.txtIDCP.TabIndex = 9;
            this.txtIDCP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(18, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "⁯Id Concepto de Pago";
            // 
            // dgLista
            // 
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(12, 10);
            this.dgLista.Name = "dgLista";
            this.dgLista.Size = new System.Drawing.Size(758, 278);
            this.dgLista.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgLista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 388);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.BtnCancelar);
            this.panel3.Controls.Add(this.BtnGuardar);
            this.panel3.Controls.Add(this.BtnUltimoReg);
            this.panel3.Controls.Add(this.BtnSiguiente);
            this.panel3.Controls.Add(this.BtnAnterior);
            this.panel3.Controls.Add(this.BtnPrimerReg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 54);
            this.panel3.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelar.IconColor = System.Drawing.Color.Brown;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 35;
            this.BtnCancelar.Location = new System.Drawing.Point(654, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 48);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 35;
            this.BtnGuardar.Location = new System.Drawing.Point(532, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 48);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnUltimoReg
            // 
            this.BtnUltimoReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnUltimoReg.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnUltimoReg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnUltimoReg.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.BtnUltimoReg.IconColor = System.Drawing.Color.White;
            this.BtnUltimoReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUltimoReg.IconSize = 25;
            this.BtnUltimoReg.Location = new System.Drawing.Point(214, 4);
            this.BtnUltimoReg.Name = "BtnUltimoReg";
            this.BtnUltimoReg.Size = new System.Drawing.Size(55, 45);
            this.BtnUltimoReg.TabIndex = 9;
            this.BtnUltimoReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUltimoReg.UseVisualStyleBackColor = false;
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnSiguiente.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSiguiente.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.BtnSiguiente.IconColor = System.Drawing.Color.White;
            this.BtnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSiguiente.IconSize = 25;
            this.BtnSiguiente.Location = new System.Drawing.Point(142, 4);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(55, 45);
            this.BtnSiguiente.TabIndex = 8;
            this.BtnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnAnterior.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnAnterior.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAnterior.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.BtnAnterior.IconColor = System.Drawing.Color.White;
            this.BtnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnterior.IconSize = 25;
            this.BtnAnterior.Location = new System.Drawing.Point(81, 4);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(55, 45);
            this.BtnAnterior.TabIndex = 7;
            this.BtnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAnterior.UseVisualStyleBackColor = false;
            // 
            // BtnPrimerReg
            // 
            this.BtnPrimerReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnPrimerReg.Font = new System.Drawing.Font("Segoe UI Black", 8.25F);
            this.BtnPrimerReg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnPrimerReg.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.BtnPrimerReg.IconColor = System.Drawing.Color.White;
            this.BtnPrimerReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrimerReg.IconSize = 25;
            this.BtnPrimerReg.Location = new System.Drawing.Point(12, 3);
            this.BtnPrimerReg.Name = "BtnPrimerReg";
            this.BtnPrimerReg.Size = new System.Drawing.Size(55, 45);
            this.BtnPrimerReg.TabIndex = 6;
            this.BtnPrimerReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrimerReg.UseVisualStyleBackColor = false;
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbEstado.Location = new System.Drawing.Point(24, 288);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(337, 21);
            this.CbEstado.TabIndex = 20;
            // 
            // Mant_Concepto_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 738);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mant_Concepto_Pago";
            this.ShowIcon = false;
            this.Text = "Mantenimiento de Concepto de Pagos";
            this.Load += new System.EventHandler(this.Mant_Concepto_Pago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIDCP;
        private System.Windows.Forms.TextBox txtDescripcion;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnUltimoReg;
        private FontAwesome.Sharp.IconButton BtnSiguiente;
        private FontAwesome.Sharp.IconButton BtnAnterior;
        private FontAwesome.Sharp.IconButton BtnPrimerReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BnBuscar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.ComboBox CbEstado;
    }
}