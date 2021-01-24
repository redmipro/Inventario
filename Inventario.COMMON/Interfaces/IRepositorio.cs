using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Interfaces
{
    public interface IRepositorio<T> where T:Base // donde T hereda de clase
    {
        bool Create(T entidad);
        bool Update(String id, T entidadModificada);
        bool Delete(T entidad);

        List<T> Read { get; }


    }
}
