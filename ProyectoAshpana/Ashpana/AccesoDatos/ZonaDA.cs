﻿using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ZonaDA
    {
        public BindingList<Zona> listarZonas()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Zona> zonas = new BindingList<Zona>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_ZONAS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Zona z = new Zona();
                z.IdZona= reader.GetInt32(0);
                z.NombreZona = reader.GetString(1);
                z.DescripicionZona = reader.GetString(2);
                z.EstadoZona = reader.GetInt32(3);
                zonas.Add(z);
            }
            conexion.Close();
            return zonas;
        }

        public void registrarZona_X_Tratamiento(int id_tratamiento, Zona z)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "REGISTRAR_ZONA_X_TRATAMIENTO";
            comando.Connection = con;

           

            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.VarChar).Value = id_tratamiento;
            comando.Parameters.Add("_ID_ZONA", MySqlDbType.VarChar).Value = z.IdZona;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;

            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Zona> listarZonas_X_Tratamiento(int id_Tratamiento)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            BindingList<Zona> zonasTratamiento = new BindingList<Zona>();

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_ZONAS_X_TRATAMIENTO";
            comando.Connection = con;
            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = id_Tratamiento;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Zona c = new Zona();
                c.IdZona = reader.GetInt32(0);
                c.NombreZona = reader.GetString(1);
                c.DescripicionZona = reader.GetString(2);
                c.EstadoZona = reader.GetInt32(3);
                zonasTratamiento.Add(c);
            }
            con.Close();
            return zonasTratamiento;
        }

        public void desactivarZonas_X_Tratamiento(int idTrat)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "DESACTIVAR_ZONAS_X_TRATAMIENTO";
            comando.Connection = con;

            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = idTrat;



            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
