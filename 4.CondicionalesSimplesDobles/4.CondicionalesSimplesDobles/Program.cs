using System;


namespace _4.CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control condicional
            //Condicional Simple
            //1. Crear un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el mensaje "Bienvenido a mi sitio web".
            byte edad = 0;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            if (edad >= 18) 
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            //if (edad < 18) 
            //{
            //  Console.WriteLine("Acceso denegado");
            //}
            Console.WriteLine("");
            //2. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos
            short salario = 0;
            string nombreCompleto;
            Console.WriteLine("Ingrese su nombre completo: ");
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su salario: ");
            salario = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            if (salario >= 3000)
            {
                Console.WriteLine("{0} su salario es de {1} pesos, esta obligado a abonar impuestos", nombreCompleto, salario);
            }
            //if (salario < 3000)
            //{
            //    Console.WriteLine("{0} su salario es de {1} pesos, no esta obligado a abonar impuestos", nombreCompleto, salario);
            //}
            Console.WriteLine("");

            //Condicionales dobles
            Console.WriteLine("Aqui los ejercicios mediante condicionales dobles");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }
            Console.WriteLine("");

            Console.WriteLine("Ingrese su nombre completo: ");
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese su salario: ");
            salario = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            if (salario >= 3000)
            {
                Console.WriteLine("{0} su salario es de {1} pesos, esta obligado a abonar impuestos", nombreCompleto, salario);
            }
            else
            {
                Console.WriteLine("{0} su salario es de {1} pesos, por lo tanto NO esta obligado a abonar impuestos", nombreCompleto, salario);
            }
            Console.WriteLine("");

            //3. Crear un algoritmo que permita ingresar dos numeros, si el primer numero es mayor al segundo numero, informar su suma y diferencia, en caso contrario informar el producto y division del primer numero respecto al segundo
            
            //Tipos de variables, condicionales y operadores
            short num1 = 0;
            short num2 = 0;
            Console.WriteLine("");
            Console.WriteLine("En este ejercicio deberas de ingresar dos numeros, si el primero es mayor que el segundo se sumaran y restaran \nsi el primero es menor que el segundo se multiplicaran y dividiran los numeros");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un valor para un primer numero: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese un valor para un segundo numero: ");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            if (num1>= num2)
            {
                Console.WriteLine("Ya que el primer valor es mayor o igual a el segundo valor, se le mostrara el valor de su Suma la cual es: {0} y de su Resta la cual es {1}", (num1+num2), (num1-num2));
            }
            else
            {
                Console.WriteLine("Ya que el primer valor es menor o igual a el segundo valor, se le mostrara el valor de su Multiplicacion la cual es: {0} y de su Division la cual es: {1}", (num1 * num2), (num1/ (float)num2));
            }
            //4. Escribir un algoritmo que le permita a un usuario ingresar un numero entero y le diga si es un numero positivo o negativo
            
            float numSigno = 0;
            Console.WriteLine("\nIngrese un numero cualquiera y la maquina dira si es un numero positivo o negativo: ");
            numSigno = Convert.ToSingle(Console.ReadLine());

            if (numSigno > 0)
            {
                Console.WriteLine("\nEl numero ingresado es positivo.");
            }
            else
            {
                Console.WriteLine("\nEl numero ingresado es negativo.");
            }
            if (numSigno == 0)
            {
                Console.WriteLine("\nEl numero ingresado es exactamente " + numSigno);
            }
            
            
        }
    }
}
