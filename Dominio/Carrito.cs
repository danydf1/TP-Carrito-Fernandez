﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito 
    {
        public List<ItemCarrito> listaCarrito { get; set; }
        public decimal total { get; set; }
    }
}
