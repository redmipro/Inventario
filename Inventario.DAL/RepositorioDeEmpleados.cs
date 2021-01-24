using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        private String DBName = "Inventario.db";
        private String TableName = "Empleados";

        //base de datos NOsql: orientada a documentos -> LiteDB
        public List<Empleado> Read {
            get
            {
                List<Empleado> datos = new List<Empleado>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Empleado>(TableName).FindAll().ToList();
                }
                return datos;
            }

        }

        public bool Create(Empleado entidad)
        { 
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Empleado>(TableName);
                    coleccion.Insert(entidad);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string id, Empleado entidad)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Empleado>(TableName);
                    coleccion.Delete(entidad.Id == id);
                }
                //si logra eliminar un registro retornara true, de lo contrario retorna false
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(string id, Empleado entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Empleado>(TableName);
                    coleccion.Insert(entidadModificada);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
