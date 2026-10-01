using System;


namespace _17.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programacion!");
            Console.ReadKey();
            MostrarMensaje("Carlos");
            MostrarMensaje("Carlos", "Esquivel Caicedo");
            Console.WriteLine($"Carlos tiene {CalcularEdad()} años");
            Console.WriteLine($"Carlos tiene {CalcularEdad(2008,2026)} años");
            Console.ReadKey();
            BorrarPantalla();
        }
        //Procedimientos sin párametros
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Procedimientos con parámetros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación!");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programación!");
        }
        //Funciones sin parámetros
        static int CalcularEdad()
        {
            int añoNacimiento = 2008;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        //Funciones con parametros
        static int CalcularEdad(int añoNacimiento, int añoActual)
        {
            return añoActual - añoNacimiento;
            
        }
    }
}
