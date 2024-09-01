using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    internal static class Program //Se usa para definir métodos y datos que pertenecen a la clase en general, no a una instancia específica.
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread] //Básicamente se asegura que el programa maneje correctamente tareas relacionadas con la interfaz de usuario en un único subproceso.
        static void Main() // Es donde comienza y se controla la ejecución de tu aplicación.
        {
            Application.EnableVisualStyles();//
            Application.SetCompatibleTextRenderingDefault(false);//En resumen estas 3 lineas de código inicializa y ejecuta una aplicación de Windows Forms con configuraciones visuales modernas.
            Application.Run(new Form1());//
        }
    }
}
