using System;


namespace _7.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Taller de Fundamentos de Programacion\nEjercicio#1\n\nIngrese el primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el tercer numero");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n------------------------\n");
            
            if (numero1 == numero2 && numero2 == numero3)
            {
                Console.WriteLine($"{numero1} = {numero2} = {numero3}");
            }
            else
            {
                if (numero1 > numero2 && numero1 > numero3) 
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine($"{numero1} >= {numero2} >= {numero3}");
                    }
                    else
                    {
                        Console.WriteLine($"{numero1} >= {numero3} >= {numero2}");
                    }
                }
                else
                {
                    if (numero1 < numero2 && numero2 > numero3)
                    {
                        if (numero1 > numero3)
                        {
                            Console.WriteLine($"{numero2} >= {numero1} >= {numero3}");
                        }
                        else
                        {
                            Console.WriteLine($"{numero2} >= {numero3} >= {numero1}");
                        }
                    }
                    else
                    {
                        if (numero3 > numero2 && numero3 > numero1)
                        {
                            if (numero2 > numero1)
                            {
                                Console.WriteLine($"{numero3} >= {numero2} >= {numero1}");
                            }
                            else
                            {
                                Console.WriteLine($"{numero3} >= {numero1} >= {numero2}");
                            }

                        }
                    }
                }

            }
            
            //Ejercicio 2

            bool estadoInv;
            int municion;
            Random rnd = new Random();
            municion = rnd.Next(0, 10);//Generacion de un numero al azar
            Console.WriteLine($"\n------------------------\nEjercicio#2\n\nMunicion: {municion}");
            Console.WriteLine("\nEl jugador esta en estado de invencibilidad? \nEscriba 'true' o 'false'\n");
            estadoInv =bool.Parse(Console.ReadLine());
            
            if (estadoInv==true && municion>=1 && municion <= 10)
            {
                Console.WriteLine("\nEl personaje esta disparando");
            }
            else
            {
                Console.WriteLine("\nEl personaje no puede disparar");
            }
            //Ejercicio 3
            //int distanciaX1X2 =Convert.ToInt16(Math.Pow((X2 - X1), 2));
            //int distanciaY1Y2 = Convert.ToInt16(Math.Pow((Y2 - Y1), 2));
            int X1 =0;
            int Y1=0;
            int X2=0;
            int Y2=0;
            int X3=0;
            int Y3=0;
            
            Console.WriteLine("\n------------------------\nEjercicio#3\n\nColoque coordenadas para 3 puntos del plano cartesiano y se dara la distancia entre los puntos\n\nIngrese el valor de X1:");
            X1=int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor de Y1");
            Y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor de X2");
            X2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor de Y2");
            Y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor de X3");
            X3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el valor de Y3");
            Y3 = int.Parse(Console.ReadLine());
            float M_P1P2 = (float)(Y2 - Y1) / (X2 - X1);//Pendiente P1 y P2
            float M_P1P3 = (float)(Y3 - Y1) / (X3 - X1);//Pendiente P1 y P3
            float M_P3P2 = (float)(Y2 - Y3) / (X2 - X3);//Pendiente P3 y P2
            double formulaD_P1P2 = Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1) * (Y2 - Y1))); //Distancia P1 y P2
            double formulaD_P1P3 = Math.Sqrt(((X3 - X1) * (X3 - X1)) + ((Y3 - Y1) * (Y3 - Y1))); //Distancia P1 y P3
            double formulaD_P3P2 = Math.Sqrt(((X2 - X3) * (X2 - X3)) + ((Y2 - Y3) * (Y2 - Y3))); //Distancia P3 y P2

            Console.WriteLine($"\nLa Distancia entre P1({X1},{Y1}) y P2({X2},{Y2}) Es igual a {formulaD_P1P2} y su pendiente es {M_P1P2}\n");
            Console.WriteLine($"\nLa Distancia entre P1({X1},{Y1}) y P3({X3},{Y3}) Es igual a {formulaD_P1P3} y su pendiente es {M_P1P3}\n");
            Console.WriteLine($"\nLa Distancia entre P3({X3},{Y3}) y P2({X2},{Y2}) Es igual a {formulaD_P3P2} y su pendiente es {M_P3P2}\n");
            if ((X1 == X2 && X2 == X3)||(Y1 == Y2 && Y2 == Y3))
            {
                Console.WriteLine("P1, P2 y P3 se encuantran en la misma coordenada horizontal o vertical formando una linea recta por lo tanto no pueden formar un triangulo");
            }
            else
            {
               if ((M_P1P2==M_P1P3||M_P3P2==M_P1P2||M_P1P3==M_P3P2))
                {
                    Console.WriteLine("Al menos dos de las pendientes son iguales por lo tanto el conjunto de puntos P1, P2 y P3 no pueden formar un triangulo");
                }
               else
                {
                    Console.WriteLine("No hay problemas para que se forme un triangulo con el conjunto de puntos P1, P2 y P3");
                }
            }
            //Ejercicio 4
            char direccion;
            Console.WriteLine("\n------------------------\nEjercicio#4\nDebes de mover un personaje, tan solo es posible moverlo con las teclas 'd' y 'i' que serian derecha o izquierda");
            Console.WriteLine("----Menu----\n'd'      'i'");
            direccion=char.Parse(Console.ReadLine());

            switch (direccion)
            {
                case 'd':
                    Console.WriteLine("El personaje se movio hacia la derecha");
                break;
                case 'i':
                    Console.WriteLine("El pensonaje se movio hacia la izquierda");
                break;
                default:
                    Console.WriteLine("No es una direccion valida");
                break;


            }
            //Ejercicio 5
            int vidas;
            char accionPersonaje;
            Random random = new Random();
            vidas = random.Next(0,5);
            Console.WriteLine("\n------------------------\nSegun el numero de vida y el boton pulsado el personaje realizara una accion o no, las opciones se encontraran en el menu.");
            Console.WriteLine($"Vida: {vidas}");
            if (vidas==0)
            {
                Console.WriteLine("Estas muerto bleeeeh :p\nNo puedes realizar accion alguna");
            }
            else
            {
                Console.WriteLine("----Menu----\n'c'      'x'\n't'      'i'\n");
                accionPersonaje = char.Parse(Console.ReadLine());
                switch (accionPersonaje)
                {
                    case 'c':
                        Console.WriteLine("El personaje esta disparando");
                    break;
                    case 'x':
                        Console.WriteLine("El personaje esta hablando con la Rana");
                    break;
                    case 't':
                        Console.WriteLine("El personaje entro en el modo Turbo");
                    break;
                    case 'i':
                        Console.WriteLine("El personaje se encuentra en estado de Invencibilidad");
                    break;
                    default:
                        Console.WriteLine("No hay nada con lo que interectuar");
                    break;
                }
            }

         

        }
    }
}
