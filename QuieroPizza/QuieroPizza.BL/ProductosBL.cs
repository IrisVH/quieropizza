﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 Quesos";

            var listaProductos = new List<Producto>();
            listaProductos.Add(producto1);

            return listaProductos;
        }
    }
}