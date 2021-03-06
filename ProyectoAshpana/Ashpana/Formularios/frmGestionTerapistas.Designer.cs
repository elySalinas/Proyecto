﻿namespace Formularios
{
    partial class frmGestionTerapistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevoTerapista = new System.Windows.Forms.Button();
            this.dgvTerapistas = new System.Windows.Forms.DataGridView();
            this.CITAS = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnVerTratamientosHabilitados = new System.Windows.Forms.Button();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerapistas)).BeginInit();
            this.CITAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(739, 459);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 45);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevoTerapista
            // 
            this.btnNuevoTerapista.BackColor = System.Drawing.Color.Black;
            this.btnNuevoTerapista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTerapista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevoTerapista.FlatAppearance.BorderSize = 0;
            this.btnNuevoTerapista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTerapista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTerapista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoTerapista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoTerapista.Location = new System.Drawing.Point(709, 131);
            this.btnNuevoTerapista.Name = "btnNuevoTerapista";
            this.btnNuevoTerapista.Size = new System.Drawing.Size(197, 45);
            this.btnNuevoTerapista.TabIndex = 15;
            this.btnNuevoTerapista.Text = "+ NUEVO TERAPISTA";
            this.btnNuevoTerapista.UseVisualStyleBackColor = false;
            this.btnNuevoTerapista.Click += new System.EventHandler(this.btnNuevoTerapista_Click);
            // 
            // dgvTerapistas
            // 
            this.dgvTerapistas.AllowUserToAddRows = false;
            this.dgvTerapistas.AllowUserToDeleteRows = false;
            this.dgvTerapistas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTerapistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTerapistas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerapistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTerapistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerapistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombres,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.HoraEntrada,
            this.HoraSalida,
            this.Sueldo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerapistas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTerapistas.EnableHeadersVisualStyles = false;
            this.dgvTerapistas.Location = new System.Drawing.Point(170, 234);
            this.dgvTerapistas.Name = "dgvTerapistas";
            this.dgvTerapistas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerapistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTerapistas.Size = new System.Drawing.Size(736, 150);
            this.dgvTerapistas.TabIndex = 19;
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.label1);
            this.CITAS.Location = new System.Drawing.Point(-8, -1);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(1276, 87);
            this.CITAS.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(704, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "TERAPISTAS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(260, 147);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(433, 20);
            this.txtBuscar.TabIndex = 22;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(166, 146);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 21);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "BUSCAR:";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // btnVerTratamientosHabilitados
            // 
            this.btnVerTratamientosHabilitados.BackColor = System.Drawing.Color.Black;
            this.btnVerTratamientosHabilitados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTratamientosHabilitados.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVerTratamientosHabilitados.FlatAppearance.BorderSize = 0;
            this.btnVerTratamientosHabilitados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTratamientosHabilitados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTratamientosHabilitados.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerTratamientosHabilitados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTratamientosHabilitados.Location = new System.Drawing.Point(380, 459);
            this.btnVerTratamientosHabilitados.Name = "btnVerTratamientosHabilitados";
            this.btnVerTratamientosHabilitados.Size = new System.Drawing.Size(300, 45);
            this.btnVerTratamientosHabilitados.TabIndex = 23;
            this.btnVerTratamientosHabilitados.Text = "Ver Tratamientos Habilitados";
            this.btnVerTratamientosHabilitados.UseVisualStyleBackColor = false;
            this.btnVerTratamientosHabilitados.Click += new System.EventHandler(this.btnVerTratamientosHabilitados_Click);
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "NOMBRES";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.DataPropertyName = "ApPaterno";
            this.ApellidoPaterno.HeaderText = "APELLIDO PATERNO";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.DataPropertyName = "ApMaterno";
            this.ApellidoMaterno.HeaderText = "APELLIDO MATERNO";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "horaEntry";
            this.HoraEntrada.HeaderText = "HORA ENTRADA";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.DataPropertyName = "horaOut";
            this.HoraSalida.HeaderText = "HORA SALIDA";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.DataPropertyName = "Sueldo";
            this.Sueldo.HeaderText = "SUELDO";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // frmGestionTerapistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 709);
            this.Controls.Add(this.btnVerTratamientosHabilitados);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.CITAS);
            this.Controls.Add(this.dgvTerapistas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevoTerapista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionTerapistas";
            this.Text = "frmGestionTerapistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerapistas)).EndInit();
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevoTerapista;
        private System.Windows.Forms.DataGridView dgvTerapistas;
        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnVerTratamientosHabilitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
    }
}