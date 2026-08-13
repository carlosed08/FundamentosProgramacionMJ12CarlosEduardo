using System;


namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Multiples
            //Crear un algoritmo que muestre por pantalla un menu con 5 opciones, y segun la opcion elegida del menu, muestre la opcion elegida, y en caso que se seleccione una opcion que no esta en el menu, se muestra un mensaje de error.

            int respuesta = 0;
            Console.WriteLine("-------Menú-------");
            Console.WriteLine("1.Opción 1");
            Console.WriteLine("2.Opción 2");
            Console.WriteLine("3.Opción 3");
            Console.WriteLine("4.Opción 4");
            Console.WriteLine("5.Opción 5");
            Console.WriteLine("------------------");
            Console.WriteLine("\nElija Alguna Opción");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio la Opción 1");
                    break;
                case 2:
                    Console.WriteLine("Eligio la Opción 2");
                    break;
                case 3:
                    Console.WriteLine("Eligio la Opción 3");
                    break;
                case 4:
                    Console.WriteLine("Eligio la Opción 4");
                    break;
                case 5:
                    Console.WriteLine("Eligio la Opción 5");
                    break;
                default:
                    Console.WriteLine("Elija una Opción valida");
                    break;

            }
        }
    }
}
