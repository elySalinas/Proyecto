﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace LogicaNegocio
{
    public class FichaMedidaBL
    {

        public FichaMedidaBL()
        {
            FichaMedidaDA fichaMedidaDA;
        }

        public BindingList<FichaMedida> listarFichaMedidas()
        {
            FichaMedidaDA fichaMedidaDA = new FichaMedidaDA();
            return fichaMedidaDA.listarFichaMedidas();
        }
    }
}