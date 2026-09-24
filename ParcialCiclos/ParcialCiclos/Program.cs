using System;


namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            float promedio = 0;
            int sumaEdad = 0;
            int grupoMenor = 0;
            int grupoEq = 0;
            int grupoMayor = 0;
            float divisor = 0;
            Console.WriteLine("Bienvenido a la base de datos del colegio María Estévez, aqui deberas de ingresar la edad de los estudiantes del grupo piloto que van a estudiar aqui");
            for(int cantEst=1; cantEst<=15; cantEst++)
            {
                edad = 0;
                Console.WriteLine($"\n\nIngrese la edad del estudiante {cantEst}:");
                edad = int.Parse(Console.ReadLine());
                while (edad < 4|| edad > 6)
                {
                    Console.WriteLine("\n\nEl o La estudiante no tiene una edad valida, ingrese otro valor:");
                    edad = int.Parse(Console.ReadLine());
                }
                
                if (edad == 4)
                {
                    grupoMenor++;
                }
                else if (edad == 5)
                {
                    grupoEq++;
                }
                else if (edad == 6)
                {
                    grupoMayor++;
                }
                sumaEdad += edad;
                divisor = cantEst;
            }
            promedio = sumaEdad / divisor; 
            Console.WriteLine($"El promedio de edad de los estudiantes es: {promedio} y");
            if (grupoMenor > grupoEq && grupoMenor > grupoMayor)
            {
                Console.Write("El Grupo es Menor");
            }
            else if (grupoMayor > grupoMenor && grupoMayor > grupoEq)
            {
                Console.Write("El Grupo es Mayor");
            }
            else
            {
                Console.Write("El Grupo es equilibrado");
            }
            
            Console.WriteLine($"\n\nLos contadores finales de cada edad son los siguientes: \n4 Años {grupoMenor}\n5 Años {grupoEq}\n6 Años {grupoMayor}");
        }
    }
}
