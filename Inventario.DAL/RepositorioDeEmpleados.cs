﻿using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        //base de datos NOsql: orientada a documentos -> LiteDB
        public List<Empleado> Read => throw new NotImplementedException();

        public bool Create(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entidadOriginal, Empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
