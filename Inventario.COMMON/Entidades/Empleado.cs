using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    public class Empleado:Base
    {
        //public int Id { get; set; }
        public String Nombre { get; set; }
        public String  Apellidos { get; set; }
        public String Area { get; set; }
    }
}
