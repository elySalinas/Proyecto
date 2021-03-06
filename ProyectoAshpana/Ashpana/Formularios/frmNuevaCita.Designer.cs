﻿namespace Formularios
{
    partial class frmNuevaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaCita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNuevaCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarTratamientos = new System.Windows.Forms.Button();
            this.btnListarPaquete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.dgvDetallesCitas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSesiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalleServicio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstadoPago = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCita
            // 
            this.lblNuevaCita.AutoSize = true;
            this.lblNuevaCita.Location = new System.Drawing.Point(45, 23);
            this.lblNuevaCita.Name = "lblNuevaCita";
            this.lblNuevaCita.Size = new System.Drawing.Size(0, 13);
            this.lblNuevaCita.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnListarTratamientos
            // 
            this.btnListarTratamientos.BackColor = System.Drawing.Color.Black;
            this.btnListarTratamientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTratamientos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarTratamientos.FlatAppearance.BorderSize = 0;
            this.btnListarTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTratamientos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTratamientos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarTratamientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarTratamientos.Location = new System.Drawing.Point(48, 186);
            this.btnListarTratamientos.Name = "btnListarTratamientos";
            this.btnListarTratamientos.Size = new System.Drawing.Size(205, 32);
            this.btnListarTratamientos.TabIndex = 13;
            this.btnListarTratamientos.Text = "Ver Listar Tratamientos";
            this.btnListarTratamientos.UseVisualStyleBackColor = false;
            this.btnListarTratamientos.Click += new System.EventHandler(this.btnAgregarTratamiento_Click);
            // 
            // btnListarPaquete
            // 
            this.btnListarPaquete.BackColor = System.Drawing.Color.Black;
            this.btnListarPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPaquete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarPaquete.FlatAppearance.BorderSize = 0;
            this.btnListarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPaquete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPaquete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarPaquete.Location = new System.Drawing.Point(307, 186);
            this.btnListarPaquete.Name = "btnListarPaquete";
            this.btnListarPaquete.Size = new System.Drawing.Size(207, 32);
            this.btnListarPaquete.TabIndex = 14;
            this.btnListarPaquete.Text = "Ver Listar Paquetes";
            this.btnListarPaquete.UseVisualStyleBackColor = false;
            this.btnListarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "MONTO TOTAL:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(347, 514);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 26);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(48, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 26);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(388, 429);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(126, 20);
            this.txtMontoTotal.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "NUEVA CITA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 100);
            this.panel1.TabIndex = 23;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.Black;
            this.btnEliminarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarServicio.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarServicio.Location = new System.Drawing.Point(48, 468);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(167, 30);
            this.btnEliminarServicio.TabIndex = 46;
            this.btnEliminarServicio.Text = "Eliminar Servicio";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.BackColor = System.Drawing.Color.Black;
            this.btnListarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPacientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarPacientes.FlatAppearance.BorderSize = 0;
            this.btnListarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPacientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPacientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListarPacientes.Image")));
            this.btnListarPacientes.Location = new System.Drawing.Point(475, 135);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(39, 24);
            this.btnListarPacientes.TabIndex = 47;
            this.btnListarPacientes.UseVisualStyleBackColor = false;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(134, 136);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(335, 19);
            this.txtPaciente.TabIndex = 48;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(44, 134);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(84, 21);
            this.lblPaciente.TabIndex = 49;
            this.lblPaciente.Text = "Paciente:";
            // 
            // dgvDetallesCitas
            // 
            this.dgvDetallesCitas.AllowUserToAddRows = false;
            this.dgvDetallesCitas.AllowUserToDeleteRows = false;
            this.dgvDetallesCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetallesCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetallesCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallesCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetallesCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.NumSesiones});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallesCitas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetallesCitas.EnableHeadersVisualStyles = false;
            this.dgvDetallesCitas.Location = new System.Drawing.Point(48, 236);
            this.dgvDetallesCitas.Name = "dgvDetallesCitas";
            this.dgvDetallesCitas.ReadOnly = true;
            this.dgvDetallesCitas.Size = new System.Drawing.Size(466, 150);
            this.dgvDetallesCitas.TabIndex = 51;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreServicio";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // NumSesiones
            // 
            this.NumSesiones.DataPropertyName = "NumSesiones";
            this.NumSesiones.HeaderText = "Número de Sesiones";
            this.NumSesiones.Name = "NumSesiones";
            this.NumSesiones.ReadOnly = true;
            this.NumSesiones.Width = 120;
            // 
            // btnVerDetalleServicio
            // 
            this.btnVerDetalleServicio.BackColor = System.Drawing.Color.Black;
            this.btnVerDetalleServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalleServicio.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVerDetalleServicio.FlatAppearance.BorderSize = 0;
            this.btnVerDetalleServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalleServicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleServicio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerDetalleServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalleServicio.Location = new System.Drawing.Point(48, 431);
            this.btnVerDetalleServicio.Name = "btnVerDetalleServicio";
            this.btnVerDetalleServicio.Size = new System.Drawing.Size(167, 30);
            this.btnVerDetalleServicio.TabIndex = 52;
            this.btnVerDetalleServicio.Text = "Detalle Servicio";
            this.btnVerDetalleServicio.UseVisualStyleBackColor = false;
            this.btnVerDetalleServicio.Click += new System.EventHandler(this.btnVerDetalleServicio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "ESTADO DE PAGO:";
            // 
            // cboEstadoPago
            // 
            this.cboEstadoPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoPago.FormattingEnabled = true;
            this.cboEstadoPago.Items.AddRange(new object[] {
            "PAGADO",
            "PENDIENTE"});
            this.cboEstadoPago.Location = new System.Drawing.Point(388, 472);
            this.cboEstadoPago.Name = "cboEstadoPago";
            this.cboEstadoPago.Size = new System.Drawing.Size(126, 25);
            this.cboEstadoPago.TabIndex = 54;
            // 
            // frmNuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 562);
            this.Controls.Add(this.cboEstadoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerDetalleServicio);
            this.Controls.Add(this.dgvDetallesCitas);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.btnListarPacientes);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListarPaquete);
            this.Controls.Add(this.btnListarTratamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNuevaCita);
            this.Controls.Add(this.panel1);
            this.Name = "frmNuevaCita";
            this.Text = "formularioNuevaCita";
            this.Load += new System.EventHandler(this.frmNuevaCita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarTratamientos;
        private System.Windows.Forms.Button btnListarPaquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnListarPacientes;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DataGridView dgvDetallesCitas;
        private System.Windows.Forms.Button btnVerDetalleServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSesiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEstadoPago;
    }
}