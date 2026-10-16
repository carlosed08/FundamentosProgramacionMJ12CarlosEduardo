using System;
using System.Runtime.InteropServices;


namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            int[] numeros = new int[5]; //La creacion de un arreglo sin elementos en sus indices, ademas solo se pueden colocar numeros del 0-4 para sus cinco posiciones, ya que "numeros[5]" generaria un error
            numeros[0] = 10;
            numeros[1] = 56;
            numeros[2] = 22;
            numeros[3] = 45;
            numeros[4] = 102;
            Console.WriteLine($"El numero almecenado en el indice 2 del arreglo cuya posicion seria la tercera es: {numeros[2]}");
            //Otras formas de inicializar las variables
            Console.WriteLine();
            char[] simbolos = new char[] { '#', '$', '%', 'o', 'R' };
            bool[] valoresDeVerdad = { true, false, true, true, false, false, true, false };
            //Recorrer para almacenar datos
            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese el nombre en la Posicion {i + 1} de Indice {i}");
                nombres[i] = Console.ReadLine();
            }
            Console.ReadKey();
            Console.Clear();
            //Recuperar los datos
            for (int i = 0;i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            //Crear un areglo que asigne el numero 10 a 100 elementos
            int[] numeros10 = new int[100];
            for (int i = 0;i < 100; i++)
            {
                numeros10[i] = 10;
            }
            for(int i = 0; i < numeros10.Length ; i++)
            {
                Console.Write($"{numeros10[i]} | ");
            }
            //Algoritmo que solicitara 10 numeros y dara el promedio de ellos
            float sumaNums = 0;
            int[] numerosElegidos = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nIngrese un numero:");
                numerosElegidos[i] = int.Parse(Console.ReadLine());
                sumaNums += numerosElegidos[i];
            }
            for (int i = 0; i < numerosElegidos.Length ; i++)
            {
                Console.Write($"{numerosElegidos[i]} | ");
            }
            Console.WriteLine($"\n El promedio de los numeros elegidos es: {(float)sumaNums / (float)numerosElegidos.Length}");
        }
    }
}
