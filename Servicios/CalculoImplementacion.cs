using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Bucles.Servicios
{
    internal class CalculoImplementacion : CalculoInterfaz
    {
        public long multiplicacionNum(long numIntroducido)
        {
            long aux=1;
            for (int i = 2; i <= numIntroducido; i++) 
            { 
                aux=aux*i;
            }
            Console.WriteLine("El resultado es: "+aux);
            return aux;
        }
    }
}
