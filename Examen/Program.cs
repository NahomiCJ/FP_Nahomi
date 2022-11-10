using System;


namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            #region Variables
            double galonesValor = 3.785, litrosGas, galonesGas, pagoTotal, gasolinaValor = 22.90;
            string titulo = "American Gas", nombrePersona;
            #endregion

            //Personalizar la consola
            #region PerzonalizadoDeConsola
            Console.Title = titulo; //Asignando un titulo a la consola
            Console.BackgroundColor = ConsoleColor.Blue; //Cambiando el color de fondo
            Console.ForegroundColor = ConsoleColor.White; // Cambiando el color del texto
            Console.SetWindowSize(80, 20); //Fijando las dimenciones de la consola
            Console.Clear(); //Limpiando la consola
            Console.WriteLine("\t Bienvenido a: ");          // Escribiendo
            Console.WriteLine("\t {0}", titulo.ToUpper());   // la bienvenida
            #endregion

            //Funcionalidad
            #region FuncionalidadDelPrograma
            Console.WriteLine("Ingrese el nombre del vendedor:");//ingresando el nombre del personal
            nombrePersona = Console.ReadLine();

            Console.WriteLine("Cuantos galones desea comprar? ");//pidiendo la cantidad de gasolina que se desea comprar
            galonesGas = Convert.ToDouble(Console.ReadLine());

            litrosGas = galonesGas*galonesValor; //conversion de galones a litros
            pagoTotal = litrosGas*gasolinaValor; // calculando el precio

            Console.WriteLine("La compra de: " + galonesGas  + 
                " galones de gasolina, que equivalen a: " + litrosGas + " litros \nTiene un costo de: $" +
                pagoTotal); //imprimiendo los resultados
            Console.WriteLine("Fue atendido por: "+ nombrePersona); //Improimiendo el nombre del personal
            #endregion

            Console.ReadKey();


        }
    }
}
