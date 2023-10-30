using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    internal interface ControlFlujoInterfaz
    {
        /// <summary>
        /// Metodo que devuelve el numero introducido por el usuario
        /// 30102023 -> irm
        /// </summary>
        /// <returns></returns>
        public long pedirNum();
        /// <summary>
        /// Metodo que pregunta al usuario si quiere volver a utilizar la aplicacion
        /// 30102023 -> irm
        /// </summary>
        /// <returns></returns>
        public string pedirConfirmacion();

    }
}
