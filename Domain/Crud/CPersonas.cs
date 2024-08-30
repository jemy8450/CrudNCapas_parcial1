using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.Entities;
using Common.Attributes;

namespace Domain.Crud
{
    public class CPersonas
    {
        Persona persona = new Persona();

        public DataTable Mostrar()
        {
            DataTable td = new DataTable();
            td = persona.Mostrar();
            return td;
        }

        public DataTable Buscar(string Buscar)
        {
            DataTable td = new DataTable();
            td = persona.Buscar(Buscar);
            return td;
        }

        public void Insertar(AttributePeople obj)
        {
            persona.Insertar(obj);
        }

        public void Modificar(AttributePeople obj)
        {
            persona.Modificar(obj);
        }

        public void Eliminar(AttributePeople obj)
        {
            persona.Eliminar(obj);
        }
    }
}
