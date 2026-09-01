using System;
using System.Reflection;


namespace _9.CicloWhilePt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numero =0;
            int pos=0;
            int neg=0;
            int zero=0;
            int cantNums = 0;
            int cantPares = 0;
            int encontrarPar = 2;
            int contador = 0;
           //Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir

        Console.WriteLine("A continuacion deberas introducir numeros enteros al azar, tanto positivos como negativos y se te dira cuantos de cada ingresaste\n\nPrimero, escoja la cantidad de numeros que desea ingresar: ");
            
            
            
            cantNums = int.Parse(Console.ReadLine());
            while (cantNums>0)
            {
                Console.WriteLine("\nIngrese un numero: ");
                numero = int.Parse(Console.ReadLine());
        cantNums = --cantNums;
                if (numero>0) 
                {
                    pos = ++pos;
                }
                else
                {
                    if (numero == 0)
                    {
                        zero = ++zero;
                    }
                    else
                    {
                        neg = ++neg;
                    }
                }
                
            }
            Console.WriteLine($"La cantidad de numeros positivos es igual a: {pos}\nLa cantidad de numeros negativos es igual a: {neg}\nLa cantidad de numeros que son iguales a zero: {zero}");
            numero = 0;
            cantNums = 0;
            Console.WriteLine("\n\nElija el punto final de rango que se evaluaran los pares: ");
            cantNums = int.Parse(Console.ReadLine());
            while (contador<=cantNums-1)
            {
                contador++;
                
                if (contador % encontrarPar == 0)
                {
                    Console.WriteLine($"{contador}\n");
                    cantPares++;
                }
            }
            Console.WriteLine($"La cantidad de numeros pares en el rango entre 1 y {contador - 1} es igual a: {cantPares}");
        }
    }
}
