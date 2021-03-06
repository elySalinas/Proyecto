﻿using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmNuevoTratamientos : Form
    {
        private TratamientoBL tratamientoBL;
        private CondicionMedicaBL condicionMedicaBL;
        private ZonaBL zonaBL; 
        public frmNuevoTratamientos()
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
            condicionMedicaBL = new CondicionMedicaBL();
            zonaBL = new ZonaBL();
            BindingList<CondicionMedica> condicionesMedicas = condicionMedicaBL.listarCondicionesMedicas();
            foreach (CondicionMedica cm in condicionesMedicas)
            {
                clbCondMedicas.Items.Add(cm);
            }


            BindingList<Zona> zonas = zonaBL.listarZonas();
            foreach (Zona z in zonas)
            {
                clblZonas.Items.Add(z);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tratamiento trat = new Tratamiento();
            if ((txtNombreTrat.Text.Trim() == "") || (txtNombreTrat.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            trat.NombreServicio = txtNombreTrat.Text.Trim();

            if (rbtnFacial.Checked == true)
                trat.TipoTrat = 1;
            else
                trat.TipoTrat = 0;
            if (rbtnFacial.Checked==false && rbtnCorporal.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un tipo de tratamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                trat.DuracionTrat = double.Parse(txtDuracion.Text.Trim());
                if (txtDuracion.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la duracion en minutos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente la duracion en minutos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                trat.PrecioServicio = double.Parse(txtPrecio.Text.Trim());
                if (txtPrecio.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente el precio en soles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el precio en soles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (int i = 0; i < clbCondMedicas.CheckedIndices.Count; i++)
            {
                trat.CondicionesMedicas.Add((CondicionMedica)clbCondMedicas.CheckedItems[i]);
            }

            for (int i = 0; i < clblZonas.CheckedIndices.Count; i++)
            {
                trat.ZonasTratar.Add((Zona)clblZonas.CheckedItems[i]);
            }

            if (tratamientoBL.registrarTratamiento(trat) != 0)
            {
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //estadoComponentes(Estado.Guardar);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            this.DialogResult = DialogResult.OK;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombreTrat_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtNombreTrat.Text)) txtNombreTrat.ForeColor = Color.Red;
            else txtNombreTrat.ForeColor = Color.Black;
        }

        private void lblSoles_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtPrecio.Text)) txtPrecio.ForeColor = Color.Red;
            else txtPrecio.ForeColor = Color.Black;
        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtDuracion.Text)) txtDuracion.ForeColor = Color.Red;
            else txtDuracion.ForeColor = Color.Black;

        }

        private void txtDescPadecimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomPadecimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZonaTratar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoTratamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {

        }

        private void lblDescPadecimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblNomPadecimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblZonaTratar_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoTratamiento_Click(object sender, EventArgs e)
        {

        }

        private void rbtnFacial_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.clblZonas.Visible = false;
        }

        private void rbtnCorporal_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.clblZonas.Visible = true;
        }
    }
}
