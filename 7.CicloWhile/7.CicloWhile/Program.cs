using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Escribir un algoritmo que permita generar los primeros 5 numeros enteros positivos y realizar y mostrar su suma.
            int contador = 1;
            int acumulador = 0;
            while (contador <= 5)
            {
                acumulador = acumulador + contador;
                contador++;
            }
            Console.WriteLine($"la suma de los cinco primeros numeros enteros es: {acumulador}");
            //2. Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario.
            int contadorF = 1;
            int acumuladorF = 1;
            int numF;

            Console.WriteLine("\n\n\nEscoja el numero del que desea conocer la factorial");
            numF=int.Parse(Console.ReadLine());


            while (contadorF <= numF)
            {
                acumuladorF = acumuladorF * contadorF;
                contadorF++;
                //Console.WriteLine($"Acumulador: {acumuladorF}, Contador: {contadorF} y Factorial: {numF}!");

            }
            Console.WriteLine($"\n\nFactorial: {numF}! = {acumuladorF}");
        }
    }
}
