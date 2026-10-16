using System;


namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para el Ciclo for no es necesario definir un contador ya que es algo que controla el mismo proceso.
            int acumulador = 0;
            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine($"La suma de los primeros 5 numeros enteros es {acumulador}");
            //Ejemplo con un algoritmo que permite calcular la factorial de un numero que se ingrese.
            acumulador = 1;
            int numero = 0;
            Console.WriteLine("Ingrese un numero para calcular su factorial:");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= numero; contador++)
            {
                acumulador = contador * acumulador;
            }
            Console.WriteLine($"El factorial del numero {numero} es {acumulador}");
        }
    }
}
