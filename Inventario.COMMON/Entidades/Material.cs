using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    public class Material:Base
    {
        //public int Id { get; set; }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public String Descripcion { get; set; }
    }
}
