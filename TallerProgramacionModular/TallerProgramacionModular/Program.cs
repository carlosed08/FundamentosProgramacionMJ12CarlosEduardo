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
            Console.WriteLine(MatrizDePalabra(IngresarPalabra()));
        }
        static string IngresarPalabra()
        {

            return Console.ReadLine();

        }
        static string MatrizDePalabra(string palabra)
        {
            int cantVocales = 0;
            int cantConsonantes = 0;
            char[] caracteres = palabra.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == 'a' || caracteres[i] == 'e' || caracteres[i] == 'i' || caracteres[i] == 'o' || caracteres[i] == 'u'|| caracteres[i] == 'A' || caracteres[i] == 'E' || caracteres[i] == 'I' || caracteres[i] == 'O' || caracteres[i] == 'U')
                {
                    cantVocales++;
                }
                else
                {
                    cantConsonantes++;
                }
            }
            return $"La palabra contiene {cantVocales} Vocales y{cantConsonantes} Consonantes";
        }
    }
}
