﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    public class Boleta:Base
    {
        //public String  Id { get; set; }
        public DateTime FechaHoraSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEntregaReal { get; set; }
        public List<Material> MaterialesPrestados { get; set; }

        //clases
        public Empleado Solicitante { get; set; }
        public Empleado EncargadoDeAlmacen { get; set; }
    }
}
