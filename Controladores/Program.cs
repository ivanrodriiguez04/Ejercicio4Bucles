using Ejercicio4Bucles.Servicios;

namespace Ejercicio4Bucles.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 30102023 -> irm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 30102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Atributos
            string respuestaIntroducida;
            long numIntroducido;

            //Creamos los objetos
            CalculoInterfaz cI = new CalculoImplementacion();
            ControlFlujoInterfaz cFI = new ControlFlujoImplementacion();

            //Llamamos a los metodos
            do
            {
                numIntroducido = cFI.pedirNum();
                cI.multiplicacionNum(numIntroducido);
                respuestaIntroducida = cFI.pedirConfirmacion();
            }while (respuestaIntroducida == "s");
        }
    }
}