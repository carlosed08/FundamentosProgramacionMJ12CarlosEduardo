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
            /*2.Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado. Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/ b el residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números.*/
            Console.WriteLine("\nEjercicio#2\nElije un numero del que quieras obtener sus divisores:");
            int dividendo = 0;
            dividendo = int.Parse(Console.ReadLine());
            for (int divisor = 1; divisor <= dividendo; divisor++)
            {
                if (dividendo % divisor == 0)
                {
                    Console.WriteLine($"{divisor} Es divisor de {dividendo}");
                }
            }
            /*3.Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la potenciación. Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32*/

        }
    }
}
