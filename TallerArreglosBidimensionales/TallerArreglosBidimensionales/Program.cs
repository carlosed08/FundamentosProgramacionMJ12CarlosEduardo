using System;



namespace TallerArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre porpantalla la suma de los elementos de cada columna.*/
            Console.WriteLine("Inicio Ejercicio#1");
            int[,]  numerosArreglo = new int [10,20];
            Random numerosAzar = new Random();
            int suma = 0;

            for (int i =0; i<10; i++)
            {
                for (int j =0; j < 20; j++)
                {
                    numerosArreglo[i, j] = numerosAzar.Next(1,101);
                    Console.Write($"{numerosArreglo[i,j]} | ");
                }

            }
            for (int j=0; j<20;j++)
            {
                for(int i=0; i < 10; i++)
                {
                    suma += numerosArreglo[i, j]; 
                }
                Console.WriteLine($"\nLa suma de la columna {j+1} es: {suma}");
                suma = 0;
            }
            Console.WriteLine("Fin Ejercicio#1");
            Console.ReadKey();
            Console.Clear();
            /*2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas.*/
            Console.WriteLine("Inicio Ejercicio#2");
            int n = 0;
            int m = 0;
            Console.WriteLine("Ingrese un numero de filas para la matriz:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero de columnas para la matriz:");
            m = int.Parse(Console.ReadLine());
            char[,] matrizPrincipal = new char[n,m];
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    Console.WriteLine($"\nIngrese un valor para la matriz en su espacio [{i+1},{j+1}]");
                    matrizPrincipal[i, j]=Console.ReadKey().KeyChar;
                    Console.Write("\n");
                }
            }
            for (int i=0; i<n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Orden regular de la matriz en [{i+1},{1+j}]: {matrizPrincipal[i,j]}");
                }
            }
            for(int i=0; i < n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    Console.Write($"\nOrden trucado de la matriz en ");
                    if (i==0)
                    {
                        Console.Write($"[{n},{j+1}]: {matrizPrincipal[n-1,j]}");
                    }
                    else if (i == n-1)
                    {
                        Console.Write($"[0,{j+1}]: {matrizPrincipal[0,j]}");
                    }
                    else
                    {
                        Console.Write($"[{i+1},{j+1}]: {matrizPrincipal[i, j]}");
                    }
                }
            }
            Console.WriteLine("\nFin Ejercicio#2");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Inicio Ejercicio#3");
            /*3.Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 5x5 llena de números aleatorios. El algoritmo debe permitir:
               Usa la función Random para generar los números aleatorios.
               Crea un arreglo adicional para almacenar la frecuencia de cada número.
               Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número*/
            Random azar10 = new Random();
            int[,] matrizPeque = new int[5,5];
            int[] frecuencia = new int[10];
            Console.WriteLine("La matriz es la siguiente:\n");
            for( int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    matrizPeque[i, j] = azar10.Next(1, 11);
                    Console.WriteLine($"Numero en [{i+1},{j+1}]: {matrizPeque[i,j]}");
                }
            }
            Console.ReadKey();
            for(int i=0; i < 5; i++)
            {
                for( int j=0; j < 5; j++)
                {
                    switch (matrizPeque[i,j])
                    {
                        case 1:
                            frecuencia[0]++;
                        break;
                        case 2:
                            frecuencia[1]++;
                        break;
                        case 3:
                            frecuencia[2]++;
                        break;
                        case 4:
                            frecuencia[3]++;
                        break;
                        case 5:
                            frecuencia[4]++;
                        break;
                        case 6:
                            frecuencia[5]++;
                        break;
                        case 7:
                            frecuencia[6]++;
                        break;
                        case 8:
                            frecuencia[7]++;
                        break;
                        case 9:
                            frecuencia[8]++;
                        break;
                        case 10:
                            frecuencia[9]++;
                        break;
                    }
                }
            }
            for (int i = 0; i < frecuencia.GetLength(0); i++)
            {
                Console.WriteLine($"La cantidad de veces que aparece el numero {i + 1} en el arreglo es: {frecuencia[i]}");
            }
            Console.WriteLine("\nFin Ejercicio#3");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Inicio Ejercicio#4");
            /*4.Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias.Luego, el algoritmo le debe permitir al usuario intentar adivinar la posición de una "X". El algoritmo debe permitir:
               Usar la función Random para colocar las "X" en la matriz.
               Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
               Al final sacar un mensaje de éxito o error.Si el mensaje es de éxito mostrar la posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz.*/
            char[,] tablero = new char[5,5];
            Random posicion = new Random();
            n = 0;
            m = 0;
            bool xHallada = false;
            for(int i = 0;i < 3; i++)
            {
                tablero[posicion.Next(0, 5), posicion.Next(0, 5)] = 'X';
            }
            for(int i =0;i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (tablero[i, j] != 'X')
                    {
                        tablero[i, j] = ' ';
                    }
                }
            }
            Console.WriteLine("Se escondieron 3 X en posiciones desconocidas de un tablero 5x5 (Escojiendo de 0 a 4)\nEscoge una fila y columna para adivinar la posicion de la X (Dispones de 3 intentos)");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Escoje la fila: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Escoje la columna: ");
                m = int.Parse(Console.ReadLine());

                if (tablero[n, m] == 'X')
                {
                    Console.WriteLine($"\nHallaste una X\nFelicidades!\n{i-1} Intentos Restantes");
                    xHallada = true;
                }
                else
                {
                    Console.WriteLine($"\nWomp Womp\nEsa casilla no tenia nada\n{i-1} Intentos Restantes");
                }
            }
            if (xHallada == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"|{tablero[i, 0]}|");
                }
                Console.Write("\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"|{tablero[i, 1]}|");
                }
                Console.Write("\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"|{tablero[i, 2]}|");
                }
                Console.Write("\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"|{tablero[i, 3]}|");
                }
                Console.Write("\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"|{tablero[i, 4]}|");
                }
            }
            else if (xHallada == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (tablero[i, j] == 'X')
                        {
                            Console.WriteLine($"La posicion de una X era: [{i},{j}]");
                        }
                        
                    }
                }
            }
        }
    }
}
