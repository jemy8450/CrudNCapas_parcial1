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
    public class CPersonas //La clase CPersonas ofrece una interfaz sencilla para realizar operaciones comunes (mostrar, buscar, insertar, modificar y eliminar).
    {
        Persona persona = new Persona(); //permite que la clase CPersonas tenga acceso a los métodos y propiedades de la clase Persona a través de la variable persona, lo que permite realizar operaciones relacionadas con personas.

        public DataTable Mostrar() //Llama al método Mostrar() de la clase Persona y devuelve un DataTable con la información que se obtiene.
        {
            DataTable td = new DataTable(); //Se crea una nueva instancia de un objeto DataTable llamado td. 
            td = persona.Mostrar(); //Se llama al método Mostrar() del objeto persona.
            return td; //El DataTable (td) que ahora contiene los datos obtenidos se devuelve como el resultado del método en el que este código está ubicado.
        }
        //-----------------------------------


        public DataTable Buscar(string Buscar) //Llama al método Buscar() de la clase Persona, pasando un string como parámetro de búsqueda, y devuelve un DataTable con los resultados.
        {
            DataTable td = new DataTable(); //Se crea una nueva instancia de un objeto DataTable llamado td.
            td = persona.Buscar(Buscar); //Se llama al método Buscar() del objeto persona.
            return td; //El DataTable (td), que contiene los resultados de la búsqueda, se devuelve como el resultado del método en el que este código está ubicado.
        }
        //-----------------------------------


        public void Insertar(AttributePeople obj) //Llama al método Insertar() de la clase Persona, pasando un objeto AttributePeople para agregar una nueva persona a la base de datos o colección.
        {
            persona.Insertar(obj); //Se utiliza para insertar un nuevo registro en una base de datos o en otra fuente de datos mediante un objeto persona.
        }
        //-----------------------------------


        public void Modificar(AttributePeople obj) //Llama al método Modificar() de la clase Persona, pasando un objeto AttributePeople para actualizar la información de una persona existente.
        {
            persona.Modificar(obj); //Se utiliza para actualizar o modificar un registro existente en una base de datos o en otra fuente de datos utilizando un objeto persona. 
        }
        //-----------------------------------


        public void Eliminar(AttributePeople obj) //Llama al método Eliminar() de la clase Persona, pasando un objeto AttributePeople para eliminar a una persona de la base de datos o colección.
        {
            persona.Eliminar(obj); //Se utiliza para eliminar un registro existente en una base de datos o en otra fuente de datos utilizando un objeto persona.
        }
    }
}
