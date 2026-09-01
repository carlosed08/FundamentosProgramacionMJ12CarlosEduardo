using System;
using System.ComponentModel;


namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo DoWhile
            int contador = 0;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"La suma de los numeros del 1 al 5 cinco veces es igual a: {acumulador} ");
            //Algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y asi sucesivamente hasta que el usuario ya no desee seguir generando tablas de multiplicar
            int numeroElegido = 0;
            bool comfirmacion;
            Console.WriteLine("Digite un numero y se te diran las tablas de multiplicar del mismo, hazlo con los numeros que desees\n\n");
            
            do
            {
                contador = 1;
                Console.WriteLine("\n\nEscoja un numero para conocer su tabla hasta el 10:");
                numeroElegido = int.Parse(Console.ReadLine());
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");
                contador++;
                Console.WriteLine($"\n{numeroElegido} * {contador} = {numeroElegido * contador}\n");

                Console.WriteLine("Desea evaluar otro numero? \nEscriba 'true' para confirmar que quiere inicial el proceso y 'false' si desea finalizarlo\n\nDesea empezar el proceso?");
                comfirmacion = bool.Parse(Console.ReadLine());

            } while (comfirmacion == true);
            //Crear un algoritmo que permita calcular y mostrar por pantalla los numeros primos hasta el numero 100.
            contador = 1; 
            acumulador = 0;
            int contador2 = 1;
            int numDivisiones = 0;
            Console.WriteLine("\n\nLos numeros primos hasta el 100 son los siguientes: ");
            do
            {
                do
                {
                    if (contador%contador2==0)
                    {
                        numDivisiones++;
                    }
                    contador2++;
                } while (contador2 <= contador);
                if (numDivisiones == 2)
                {
                    Console.WriteLine($"{contador}");
                }
                contador2 = 1;
                numDivisiones = 0;
                 contador++;
                

            } while (contador<=100);
            Console.WriteLine("El Programa ha finalizado\nPresione cualquier tecla para terminarlo.");
            Console.ReadKey();
        }
    }
}
