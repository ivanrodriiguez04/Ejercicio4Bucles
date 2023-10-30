using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    /// <summary>
    /// Implementacino de la interfaz del control de flujo
    /// 30102023 -> irm
    /// </summary>
    internal class ControlFlujoImplementacion : ControlFlujoInterfaz
    {
        public string pedirConfirmacion()
        {
            string respuesta="";
            Console.WriteLine("¿Quiere volver a utilizar la aplicacion[s=si || n=no]?");
            respuesta = Console.ReadLine();
            return respuesta;
        }

        public long pedirNum()
        {
            long num;
            Console.WriteLine("Introduzca el numero deseado:");
            num=Convert.ToInt64(Console.ReadLine());
            return num;
        }
    }
}
