using System;


namespace TallerProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrolla un programa que permita: 
            Ingresar una palabra 
            LLevar la palabra ingresada a un vector de caracteres 
            Contar la cantidad de vocales y consonantes en la palabra proporcionada por el usuario. */
            Console.WriteLine(IngresarPalabra());
        }
        static string IngresarPalabra()
        {

            return Console.ReadLine();

        }
        static string MatrizDePalabra(string palabra)
        {
            char[] caracteres = palabra.ToCharArray();
            return "";
        }
    }
}
