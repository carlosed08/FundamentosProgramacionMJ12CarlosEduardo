using System;


namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100.El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.
            int numeroGanador;
            int numeroElegido=0;
            Random rnd = new Random();
            numeroGanador = rnd.Next(0, 100);
            Console.WriteLine("En este programa deberas de elegir un numero al azar entre el 1 y el 100, ya existe uno elegido por el programa y se te dira si es muy alto o bajo con cada intento de adivinar fallido hasta que logres dar con el resultado.\n\nDigita un numero entre el 1 y 100:");
            numeroElegido=int.Parse(Console.ReadLine());
            while(numeroElegido != numeroGanador)
            {
                if (numeroElegido > numeroGanador)
                {
                    Console.WriteLine("\n\nFallaste, tu numero es muy grande\nElige otro numero:");
                }
                else if (numeroElegido < numeroGanador)
                {
                    Console.WriteLine("\n\nFallaste, tu numero es muy pequeño\nElige otro numero:");
                }
                numeroElegido = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\n\n           Felicidades!\nel numero ganador es: {numeroGanador} y acertaste!");
            
        }
    }
}
