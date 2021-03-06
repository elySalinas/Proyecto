﻿using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class TerapistaBL
    {
        private TerapistaDA terapistaDA;


        public TerapistaBL()
        {
            terapistaDA = new TerapistaDA();
        }

        public void registrarTerapista(Terapista t, string a, string b, string c, string d)
        {
            terapistaDA.registrarTerapista(t, a, b, c, d);
        }

        public BindingList<Terapista> listarTerapistas()
        {
            return terapistaDA.listarTerapistas();
        }

        public void modificarTerapista(Terapista t, string horaE, string horaS, string minutoE, string minutoS)
        {
            terapistaDA.modificarTerapista(t, horaE, horaS, minutoE, minutoS);
        }

        public bool registrarTratamiento_X_terapista(Terapista terapistaAnt, Terapista terapistaMod)
        {
            try
            {
                foreach (Tratamiento trat in terapistaAnt.Tratamientos)
                {
                    if (!terapistaMod.Tratamientos.Contains(trat))
                    {
                        terapistaDA.modificarTerapista_X_Tratamiento(trat.IdTrat, terapistaMod.IdTerapista, terapistaMod.IdTrabajador, terapistaMod.IdPersona, 0);
                    }
                }
                BindingList<Tratamiento> tratamientosInactivos = terapistaDA.listarTratamientosInactivos(terapistaMod.IdTerapista);
                foreach (Tratamiento trat in terapistaMod.Tratamientos)
                {
                    if (tratamientosInactivos.Contains(trat))
                    {
                        terapistaDA.modificarTerapista_X_Tratamiento(trat.IdTrat, terapistaMod.IdTerapista, terapistaMod.IdTrabajador, terapistaMod.IdPersona, 1);

                    }

                    if (!terapistaAnt.Tratamientos.Contains(trat))
                    {
                        terapistaDA.registrarTratamiento_X_terapista(terapistaAnt, trat);
                    }
                }
                return true; 
            }catch (Exception ex)
            {
                return false;
            }
           

        }

        public BindingList<Tratamiento> listarTratamientos_X_Terapista(int IdTerapista)
        {
            return terapistaDA.listarTratamientos_X_Terapista(IdTerapista);
        }

        public BindingList<Terapista> listarTerapistas_X_Tratamiento(int idTratamiento)
        {
            return terapistaDA.listarTerapistas_X_Tratamiento(idTratamiento);
        }

        public BindingList<Terapista> listarTerapistas_X_Paquete(int id_servicio)
        {
            return terapistaDA.listarTerapistasXPaquetes(id_servicio);
        }

        public BindingList<Terapista> listarTerapistaVerificaciones()
        {
            return terapistaDA.listarTerapistasVerificaciones();
        }
    }
}
