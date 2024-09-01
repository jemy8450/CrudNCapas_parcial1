using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Connection
{
    public class Connection_Database //Define una clase en C# que generalmente se utiliza para gestionar la conexión a una base de datos.


    {
        //esto es la cadena de conexion------------------------------------------------------------------------------------------------------------------//
        private SqlConnection c = new SqlConnection("Data Source=JEREMYGAMER8450\\SQLEXPRESS;Initial Catalog=CRUD_N_CAPAS;Integrated Security=True;");   //
        //-----------------------------------------------------------------------------------------------------------------------------------------------//


        public SqlConnection OpenConnection() //Se utiliza para gestionar la conexión a una base de datos SQL Server.
        {
            if (c.State == ConnectionState.Closed) c.Open(); /*if (c.State == ConnectionState.Closed):Esta línea verifica si la conexión (c) está cerrada. c es una instancia de SqlConnection.
            ConnectionState.Closed: es un estado que indica que la conexión no está actualmente abierta.
            c.Open(); :Si la conexión está cerrada, este comando abre la conexión a la base de datos. Esto permite que se puedan realizar operaciones de lectura o escritura en la base de datos.*/
            return c; //Después de asegurarse de que la conexión está abierta, el método devuelve el objeto SqlConnection (c). Esto permite que el llamador del método utilice la conexión para ejecutar comandos SQL.
        }

        public SqlConnection CloseConnection() //Su propósito es gestionar el cierre de la conexión a una base de datos SQL Server.
        {
            if (c.State == ConnectionState.Open) c.Close(); /*if (c.State == ConnectionState.Open): Esta línea verifica si la conexión (c) está abierta. c es una instancia de SqlConnection.
            ConnectionState.Open: es un estado que indica que la conexión está actualmente abierta y lista para ser utilizada.
            c.Close(); :Si la conexión está abierta, este comando cierra la conexión a la base de datos. Cerrar la conexión es importante para liberar recursos y evitar posibles problemas de rendimiento o bloqueos en la base de datos.*/
            return c; //Después de asegurarse de que la conexión está cerrada, el método devuelve el objeto SqlConnection (c). Esto permite que el llamador del método tenga acceso a la instancia de conexión, incluso después de que se haya cerrado.
        }
    }
}
