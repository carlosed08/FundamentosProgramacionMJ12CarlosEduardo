using System;


namespace _12.CicloDoWhileFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo;  para cada usuario se debe hacer lo siguiente:
              i. Si el saldo es mayor o igual a 3´000.000 , sacar un mensaje que diga el nombre del usuario, el numero de cuenta y saldo con el mensaje "es apto para crédito"
              ii. Si el saldo es menor a 3´000.000, mostrar el nombre de usuario, numero de cuenta y saldo pero que el mensaje sea "No es apto para crédito" El algoritmo debe permitir preguntar la información se usuarios, hasta que se indique que ya no se desea preguntar más. Además debe permitir mostrar el número de usuarios a los que se le pidió la información y debe mostrar el promedio de saldos.*/
            string nombre;
            int numCuenta;
            int saldo;
            char confirmar;
            int suma = 0;
            int cantUsuarios = 0;
            do
            {
                Console.WriteLine("\nEscriba el nombre del usuario:");
                nombre = Console.ReadLine();
                Console.WriteLine("\nNumero de cuenta del usuario:");
                numCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("\nSaldo del usuario:");
                saldo = int.Parse(Console.ReadLine());
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"\nEl usuario {nombre} con numero de cuenta {numCuenta} es apto para el credito.");
                }
                else
                {
                    Console.WriteLine($"\nEl usuario {nombre} con numero de cuenta {numCuenta} NO es apto para el credito.");
                }
                Console.WriteLine("\nDesea seguir ingresando usuarios?\nPresione s para continuar y cualquier otra tecla para finalizar el programa:");
                suma += saldo;
                cantUsuarios++;
                confirmar = Console.ReadKey().KeyChar;
            } while (confirmar == 's'|| confirmar == 'S');
            Console.WriteLine($"\nLa cantidad de usuarios ingresados es {cantUsuarios} y el promedio de sus saldos es {(float)suma / (float)cantUsuarios}");
        }
    }
}
