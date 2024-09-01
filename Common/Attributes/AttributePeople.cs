using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attributes
{
    public class AttributePeople //define una clase llamada AttributePeople
    {
        private int iD; //Un número entero que podría representar un identificador único para una persona.
        private string nombre; //Una cadena de texto que almacena el nombre de la persona.
        private string apellido; //Una cadena de texto que almacena el apellido de la persona.
        private string sexo; //Una cadena de texto que almacena el sexo de la persona.

        public int ID { get => iD; set => iD = value; } //Permite leer (get) y modificar (set) el valor privado iD desde fuera de la clase.
        public string Nombre { get => nombre; set => nombre = value; } //Permite leer y modificar el valor privado nombre.
        public string Apellido { get => apellido; set => apellido = value; } //Permite leer y modificar el valor privado apellido.
        public string Sexo { get => sexo; set => sexo = value; } //Permite leer y modificar el valor privado sexo.

        //En resumen estas propiedades proporcionan una manera segura de acceder y actualizar los campos privados de la clase desde fuera de ella.
    }
}
