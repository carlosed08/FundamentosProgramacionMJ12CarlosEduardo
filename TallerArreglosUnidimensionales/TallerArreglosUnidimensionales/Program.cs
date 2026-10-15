using System;


namespace TallerArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados.*/

            int[] arrayDe15 = new int[15];
            for (int i = 0; i < 15; i++)
            {
                arrayDe15[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < 15; i++)
            {
                if (i > 0)
                {
                    if (arrayDe15[i] > arrayDe15[i - 1])
                    {

                    }
                }
            }
        }
    }
}
