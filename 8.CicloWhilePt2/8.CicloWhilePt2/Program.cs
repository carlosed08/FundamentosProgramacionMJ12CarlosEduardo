using System;
using System.Diagnostics.Eventing.Reader;


namespace _8.CicloWhilePt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizzar un algoritmo que pida numeros enteros positivos y los sume, hasta que se ingrese un numero entero negativo. Se debe mostrar por pantalla el total de la suma de los numeros ingresados.
            int acumulador = 0;
            int numero = 0;
            //int cantNums = 0;
            //int pos = 0;
            //int neg = 0;
            //int zero = 0;

            Console.WriteLine("Ingrese el numero a sumar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                acumulador += numero;
                Console.WriteLine("Ingrese otro numero a sumar");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nEl Numero negativo no sera tomado en cuenta\nLa suma de los numeros ingresados es igual a: {acumulador}");//\n\nA continuacion deberas introducir numeros enteros al azar, tanto positivos como negativos y se te dira cuantos de cada ingresaste\n\nPrimero, escoja la cantidad de numeros que desea ingresar: ");
            //Realizar un algoritmo que le pida al usuario ingresar por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir
            //acumulador = 0;
            //numero = 0;
            //cantNums = int.Parse(Console.ReadLine());
            //while (cantNums>0)
            //{
            //   Console.WriteLine("\nIngrese un numero: ");
            //    numero = int.Parse(Console.ReadLine());
            //    cantNums = --cantNums;
            //    if (numero>0) 
            //    {
            //        pos = ++pos;
            //    }
            //    if (numero == 0)
            //    {
            //        zero = ++zero;
            //    }
            //    if (numero<0)
            //    {
            //        neg = ++neg;
            //    }
            //}
            //Console.WriteLine($"La cantidad de numeros positivos es igual a: {pos}\nLa cantidad de numeros negativos es igual a: {neg}\nLa cantidad de numeros que son iguales a zero: {zero}");
        }
    }
}
