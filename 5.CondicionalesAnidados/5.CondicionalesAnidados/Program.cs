using System;


namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales anidados
            //b. Diseñar un algoritmo que lea tres numeros A, B, C y visualice en pantalla el valor mas grande, el usuario debe ingresar 3 valores diferentes
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("En este ejercicio deberas de ingresar 3 valores diferentes, se te devolveran los valores haciendo enfasis de cual es el mayor.");
            Console.WriteLine("\nIngrese el valor del primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor del segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor del tercer número");
            num3 = int.Parse(Console.ReadLine());

            if (num1>num2)
            {
                //Verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("\nEl primer numero: {0} es mayor que el segundo numero: {1} y el tercer numero: {2} ",num1,num2,num3);
                }
                else
                {
                    Console.WriteLine("\nEl tercer numero: {2} es mayor que el segundo numero: {1} y el primer numero: {0} ",num1,num2,num3);
                }
            }
            else
            {
                //Falsa
                if (num2 > num3)
                {
                    Console.WriteLine("\nEl segundo numero: {1} es mayor que el primer numero: {0} y el tercer numero: {2} ", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("\nEl tercer numero: {2} es mayor que el segundo numero: {1} y el primer numero: {0} ", num1, num2, num3);
                }
            }
        }
    }
}
