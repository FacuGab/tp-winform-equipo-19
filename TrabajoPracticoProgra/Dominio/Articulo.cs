﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descrpicion{ get; set; }

        Marca marca { get; set; }

        Categoria categoria { get; set; }
        //TODO mirar si agregamos una lista de imagenes o lo tratamos como atributo individual.
        //Puede haber mas de 1 imagen para un articulo
        public List<string> imagenes { get; set; }  
        public float precio { get; set; }
    }
}