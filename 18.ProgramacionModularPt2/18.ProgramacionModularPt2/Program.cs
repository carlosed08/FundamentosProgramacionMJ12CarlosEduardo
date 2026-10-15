using System;


namespace _18.ProgramacionModularPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
            
        }
        static void MostrarMenu()
        {
            Console.WriteLine("--------------------Menú--------------------\n1.Suma                    2.Resta\n3.Multiplicacion          4.Division\n0.Salir");
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La SUMA de los numeros ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La RESTA de los numeros ingresados es {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La MULTIPLICACION de los numeros ingresados es {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La DIVISION de los numeros ingresados es {Division()}");
                        break;
                    default:
                        break;

                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
            

        }
        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }
        static float Suma()
        {
            float suma = 0;
            float numero = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("\nIngrese un numero:");
                numero=float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("\nQuiere seguir sumando?\n Presione 's' para continuar");
                respuesta = Console.ReadKey().KeyChar;
            } while (respuesta == 's');
            return suma;
        }
        static float Resta()
        {
            float resta = 0;
            float numero = 0;
            
                Console.WriteLine("\nIngrese un numero:");
                numero = float.Parse(Console.ReadLine());
                resta += numero;
                Console.WriteLine("\nIngrese un numero para restarle:");
                numero = float.Parse(Console.ReadLine());
                resta -= numero;

            /*Console.WriteLine("Quiere seguir restando?\n Presione 's' para continuar");
            respuesta = Console.ReadKey().KeyChar;*/
            return resta;
        }
        static float Multiplicacion()
        {
            float numero = 0;
            float multiplicacion = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("\nIngrese un numero:");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("\nQuiere elegir un numero por el cual multiplicarlo?\n Presione 's' para continuar");
                respuesta = Console.ReadKey().KeyChar;
            } while (respuesta == 's');
            return multiplicacion;
        }
        static float Division()
        {
            float numero = 0;
            float division = 0;
            
            Console.WriteLine("\nIngrese un numero:");
            numero = float.Parse(Console.ReadLine());
            division += numero;
            Console.WriteLine("\nIngrese un numero por el cual dividir:");
            numero = float.Parse(Console.ReadLine());
            division /= numero;

            return division;
        }
    }
}
