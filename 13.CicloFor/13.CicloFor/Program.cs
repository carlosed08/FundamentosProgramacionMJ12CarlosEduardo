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
            Console.WriteLine($"{numero}! es {acumulador}");
            //Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por el teclado el rango de números a evaluar.
            numero = 0;
            Console.WriteLine("Escoja un rango de numeros para analizar, si es multiplo de 5 el numero del contador se mostrara en pantalla\n(Escribe unicamente el numero final del rango)");
            numero = int.Parse(Console.ReadLine());
            for (int contador = 1; contador <= numero; contador++)
            {
                if(contador % 5 == 0)
                {
                    Console.WriteLine($"\n{contador}");
                }
            }
        }
    }
}
