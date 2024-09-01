using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Persona //La clase Persona actúa como un modelo para crear y manipular objetos que representan personas.
    {
        //variables
        Connection_Database c = new Connection_Database();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();
        //---------------------------------------------------


        public DataTable Mostrar() //Sirve para recuperar datos de una base de datos y devolverlos en un objeto DataTable.
        {
            try // Inicia un bloque donde se intenta ejecutar código que puede generar excepciones.
            {
                cmd.Connection = c.OpenConnection(); //Abre la conexión a la base de datos.
                cmd.CommandText = "SP_Mostrar"; //Establece el texto del comando a un procedimiento almacenado llamado SP_Mostrar.
                cmd.CommandType = CommandType.StoredProcedure; //Especifica que el comando es un procedimiento almacenado.
                dr = cmd.ExecuteReader(); //Ejecuta el comando y obtiene un lector de datos (dr) que permite leer los resultados del procedimiento.
                td.Load(dr); //Carga los datos obtenidos del lector en un DataTable (td).
            }
            catch (Exception ex) //Captura cualquier excepción que ocurra durante la ejecución del bloque try.
            {
                string msj = ex.ToString(); //Convierte la excepción en una cadena de texto y la almacena en la variable msj (aunque no se usa en este código).
            }
            finally //Este bloque se ejecuta después de try y catch, sin importar si ocurrió una excepción o no.
            {
                cmd.Connection = c.CloseConnection(); //Cierra la conexión a la base de datos, asegurando que los recursos se liberen.
            }
            return td; //Devuelve el DataTable (td) que contiene los datos recuperados de la base de datos.
        }
        //----------------------------------------------


        public DataTable Buscar(string Buscar) //Se utiliza para buscar y recuperar datos de una base de datos basándose en un criterio de búsqueda específico.
        {
            try //Inicia un bloque donde se intentará ejecutar el código que puede generar excepciones.
            {
                cmd.Connection = c.OpenConnection(); //Abre la conexión a la base de datos.
                cmd.CommandText = "SP_Buscar"; //Establece el comando para ejecutar el procedimiento almacenado llamado SP_Buscar.
                cmd.CommandType = CommandType.StoredProcedure; //Indica que el comando es un procedimiento almacenado.
                cmd.Parameters.AddWithValue("@Buscar", Buscar); //Agrega un parámetro llamado @Buscar al comando, asignándole el valor de la variable Buscar, que se usará para filtrar los resultados.
                dr = cmd.ExecuteReader(); //Ejecuta el comando y obtiene un lector de datos (dr) que permite leer los resultados del procedimiento.
                SqlDataAdapter da = new SqlDataAdapter(cmd); //Crea un adaptador de datos que puede trabajar con los datos leídos (aunque no se usa después en el código).
                td.Load(dr); //Carga los datos obtenidos del lector en un objeto DataTable (td).
            }
            catch (Exception ex) //Captura cualquier excepción que ocurra durante la ejecución del bloque try.
            {
                string msj = ex.ToString(); //Convierte la excepción en una cadena de texto y la almacena en la variable msj (aunque no se usa en el código).
            }
            finally //Este bloque se ejecuta después de try y catch, sin importar si ocurrió una excepción o no.
            {
                cmd.Connection = c.CloseConnection(); //Cierra la conexión a la base de datos, asegurando que los recursos se liberen.
            }
            return td; //Devuelve el DataTable (td) que contiene los datos recuperados de la búsqueda.
        }
        //----------------------------------------------


        public void Insertar(AttributePeople obj) //Se utiliza para insertar un nuevo registro de datos en una base de datos o colección utilizando un objeto AttributePeople.
        {
            try //Inicia un bloque donde se intenta ejecutar el código que puede generar excepciones.
            {
                cmd.Connection = c.OpenConnection(); //Abre la conexión a la base de datos.
                cmd.CommandText = "SP_Insertar"; // Define el comando que se va a ejecutar, en este caso, el procedimiento almacenado SP_Insertar.
                cmd.CommandType= CommandType.StoredProcedure; //Indica que el comando es un procedimiento almacenado.
                cmd.Parameters.AddWithValue("@ID", obj.ID); //Agrega un parámetro @ID al comando, con el valor del campo ID del objeto obj.
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre); //Agrega un parámetro @Nombre al comando, con el valor del campo Nombre del objeto obj.
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido); //Agrega un parámetro @Apellido al comando, con el valor del campo Apellido del objeto obj.
                cmd.Parameters.AddWithValue("@Sexo", obj.Sexo); //Agrega un parámetro @Sexo al comando, con el valor del campo Sexo del objeto obj.
                cmd.ExecuteNonQuery(); //Ejecuta el comando para insertar el registro en la base de datos. Como es una operación de inserción, no se espera un resultado (de ahí ExecuteNonQuery).
                cmd.Parameters.Clear(); //Limpia los parámetros del comando para evitar que se reutilicen de manera incorrecta en futuras operaciones.
            }
            catch (Exception ex) //Captura cualquier excepción que ocurra durante la ejecución del bloque try.
            {
                string msj = ex.ToString(); // Convierte la excepción en una cadena de texto y la almacena en la variable msj (aunque no se usa en el código).
            }
            finally //Este bloque se ejecuta después de try y catch, sin importar si ocurrió una excepción o no.
            {
                cmd.Connection= c.CloseConnection(); //Cierra la conexión a la base de datos, asegurando que los recursos se liberen.
            }
        }
        //----------------------------------------------


        public void Modificar(AttributePeople obj) //se utiliza para actualizar o modificar un registro existente en una base de datos o colección utilizando un objeto AttributePeople.
        {
            try //Inicia un bloque donde se intenta ejecutar el código que puede generar excepciones.
            {
                cmd.Connection = c.OpenConnection(); //Abre la conexión a la base de datos.
                cmd.CommandText = "SP_Modificar"; //Define el comando que se va a ejecutar, en este caso, el procedimiento almacenado SP_Modificar.
                cmd.CommandType = CommandType.StoredProcedure; //Indica que el comando es un procedimiento almacenado.
                cmd.Parameters.AddWithValue("@ID", obj.ID); //Agrega un parámetro @ID al comando, con el valor del campo ID del objeto obj. Este valor se usa para identificar el registro que se desea modificar.
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre); //Agrega un parámetro @Nombre al comando, con el valor del campo Nombre del objeto obj.
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido); //Agrega un parámetro @Apellido al comando, con el valor del campo Apellido del objeto obj.
                cmd.Parameters.AddWithValue("@Sexo", obj.Sexo); //Agrega un parámetro @Sexo al comando, con el valor del campo Sexo del objeto obj.
                cmd.ExecuteNonQuery(); //Ejecuta el comando para modificar el registro en la base de datos. Como es una operación de modificación, no se espera un resultado (por eso se usa ExecuteNonQuery).
                cmd.Parameters.Clear(); //Limpia los parámetros del comando para evitar que se reutilicen de manera incorrecta en futuras operaciones.
            }
            catch (Exception ex) //Captura cualquier excepción que ocurra durante la ejecución del bloque try.
            {
                string msj = ex.ToString(); // Convierte la excepción en una cadena de texto y la almacena en la variable msj (aunque no se usa en el código).
            }
            finally //Este bloque se ejecuta después de try y catch, sin importar si ocurrió una excepción o no.
            {
                cmd.Connection = c.CloseConnection(); //Cierra la conexión a la base de datos, asegurando que los recursos se liberen.
            }
        }
        //----------------------------------------------


        public void Eliminar(AttributePeople obj) //Se utiliza para eliminar un registro de la base de datos o de una colección utilizando un objeto AttributePeople.
        {
            try //Inicia un bloque donde se intenta ejecutar el código que puede generar excepciones.
            {
                cmd.Connection = c.OpenConnection(); //Abre la conexión a la base de datos.
                cmd.CommandText = "SP_Eliminar"; //Define el comando que se va a ejecutar, en este caso, el procedimiento almacenado SP_Eliminar.
                cmd.CommandType = CommandType.StoredProcedure; //Indica que el comando es un procedimiento almacenado.
                cmd.Parameters.AddWithValue("@ID", obj.ID); //Agrega un parámetro @ID al comando, con el valor del campo ID del objeto obj. Este valor se usa para identificar el registro que se desea eliminar.
                cmd.ExecuteReader(); //Ejecuta el comando para eliminar el registro en la base de datos.
                cmd.Parameters.Clear(); //Limpia los parámetros del comando para evitar que se reutilicen de manera incorrecta en futuras operaciones.
            }
            catch (Exception ex) //Captura cualquier excepción que ocurra durante la ejecución del bloque try.
            {
                string msj = ex.ToString(); //Convierte la excepción en una cadena de texto y la almacena en la variable msj (aunque no se utiliza en este código).
            }
            finally //Este bloque se ejecuta después de try y catch, sin importar si ocurrió una excepción o no.
            {
                cmd.Connection = c.CloseConnection(); //Cierra la conexión a la base de datos, asegurando que los recursos se liberen.
            }
        }
    }
}
