using System;


namespace TallerEjercitacionCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente.
            float suma = 0;
            int cantidad = 0;
            float calificacion = 0;
            char confirmacion;
            Console.WriteLine("Ejercicio#1\nColoque calificaciones hasta que decidas no añadir mas y se dara el promedio de estas.");
            do
            {
                Console.WriteLine("\nAñada una calificacion:");
                calificacion = float.Parse(Console.ReadLine());
                suma += calificacion;
                cantidad++;
                Console.WriteLine("\nDesea añadir otra calificacion?\n('n' para parar y cualquier otra letra para continuar)");
                confirmacion = Console.ReadKey().KeyChar;
            } while (confirmacion != 'n');

        }
    }
}
