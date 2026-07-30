using System;

namespace _2.ConstanteTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva = "19%";
            string nombre = "Carlos";
            nombre = "Si?";
            //iva = "21%"; A una constante no se le puede cambiar el valor en medio de la ejecucion

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = -256;
            ulong dato3 = 9999999999999999999;
            float dato4 = 2.99f;
            double dato5 = 2000000000000.999999d;
            char dato6 = 'A'; //Almacena un solo caracter
            string dato7 = "Buenos Dias";
            bool dato8 = true; //"true" o "false"
            object dato9 = new object();


            //Operadores
            //Numericos
            //Cambio de signo
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato10: {0}, dato11: {1}, dato12: {2}, dato13: {3} ", dato10, dato11, dato12, dato13); //{Numero} Indice, se coloca alli el dato: {0} es dato10 y asi
            Console.ReadKey();

            //Operadores Aritmeticos
            int dato14 = 5 + 3;//Suma
            int dato15 = dato14 - 2;//Resta
            int dato16 = dato15 * 3;//Multiplicacion
            float dato17 = dato16 /(float) 5.0;//Division
            Console.WriteLine("\nSuma: {0}, Resta: {1}, Multiplicacion: {2}, Division: {3} ", dato14, dato15, dato16, dato17);
            Console.ReadKey();

            //Incremento - Decremento
            int dato18 = 1;
            dato18++;//Es igual a decir dato18=dato18+1;
            Console.WriteLine(dato18);
            dato18--;//Es igual a decir dato18=dato18-1;
            Console.WriteLine(dato18);
            dato18 += 3;//Es igual a decir dato18=dato18+3; Ademas tambien se puede con -,*,/
            Console.WriteLine(dato18);
            Console.WriteLine("Wow Escritura Triple");
            Console.WriteLine("Wow Escritura Triple");
            Console.WriteLine("Wow Escritura Triple");
        }
    }
}
