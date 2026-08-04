using System;


namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato1 = 0;
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1++;//dato1 = dato1 + 1; Incremento en una unidad
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1--;//dato1 = dato1 - 1; Decremento en 1 unidad
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1 += 15;//dato1 = dato1 +15;
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1 -= 14;//dato1 = dato1 -14;
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1 *= 6;//dato1 = dato1 *6;
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1 /= 7;//dato1 = dato1 /7;
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();
            dato1 *= dato1;
            Console.WriteLine("Dato 1 Es: {0}", dato1);
            Console.ReadKey();

            //Orden de evaluacion operadores
            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 * (4 / 2);

            //Operadores Logicos
            //Conjuncion - AND - Y - &&
            Console.WriteLine("TABLA DE LA CONJUNCIÓN");
            Console.WriteLine("V && V =" +(true&&true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && F =" + (false && false));
            Console.ReadKey();

            //Disyuncion - OR - O - ||
            Console.WriteLine("TABLA DE DISYUNCIÓN");
            Console.WriteLine("V || V=" + (true||true));
            Console.WriteLine("V || F=" + (true || false));
            Console.WriteLine("F || V=" + (false || true));
            Console.WriteLine("F || F=" + (false || false));
            Console.ReadKey();

            //Negacion
            bool dato6 = true;
            bool dato7 = !dato6;

            //Operadores de comparacion
            bool dato8 = 5 > 4;
            bool dato9 = 1002 == 102;
            bool dato10 = 10 >= 9;
            bool dato11 = 0 != 1;
            bool dato12 = 4 < 5 && 3 == 0;
            bool dato13 = 0 != 2 && dato8 || dato9;
        }
    }
}
