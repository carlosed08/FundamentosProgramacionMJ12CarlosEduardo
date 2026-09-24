using System;


namespace _16.ArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales o matrices
            int[,] numeros = new int[2,3];
            //numeros[2,1] = 10; No se puede almacenar porque el indice de la fila no existe
            //numeros[1,3] = 15; No se puede almacenar porque el indice de la columna no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 100;
            numeros[0, 2] = 56;
            numeros[1, 0] = 45;
            numeros[1, 1] = 8;
            numeros[1, 2] = 10;
            Console.WriteLine($"El valor almacenado en numeros[1,0]: {numeros[1,0]}");
            //Recorrer la matriz para llenarla
            char[,] simbolos = new char[3, 2];
            for (int i = 0; i < 3; i++)//Recorre las filas
            {
                
                for (int j = 0; j < 2; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para los simbolos [{i},{j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar datos
            Console.Clear();
            for (int i = 0; i < simbolos.GetLength(0); i++)//GetLenght(0) devuelve el numero de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//GetLenght(1) devuelve el numero de columnas
                {
                    Console.Write($" {simbolos[i, j]} |");
                }
            }
            //Otra forma de declarar e inicializar matrices

            string[,] nombres = {
                                 {"Ana","Pedro","Carlos","Alvaro" },
                                 {"Pedro","Ferney","Yuli","Felix" },
                                 {"Jose","Lucia","Miguel","Sofia" }
                                };

            //Crear una matriz[10,20], en cada posicion de la matriz poner el numero 100; mostrar la matriz en la consola
            int[,] matriz100 = new int[10, 20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz100[i, j] = 100;
                }
            }

            Console.Clear();
            for (int i = 0; i < 10; i++)//GetLenght(0) devuelve el numero de filas
            {
                for (int j = 0; j < 20; j++)//GetLenght(1) devuelve el numero de columnas
                {
                    Console.WriteLine($"El valor de la matriz con posicion [{i+1},{j+1}] es igual a: {matriz100[i, j]}");
                }
            }
            //Escribe un Programa que realice la suma de dos matrices de dimensiones 2x3, Requisitos: Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas, Solicite al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones 2x3, Calcula la matriz suma, resultado de sumar cada elemento corresondiente de las dos matrices, Muestra la matriz resultante de la suma en formato de matriz 2 filas 3 columnas
            int[,] primeraMatriz = new int[2,3];
            int[,] segundaMatriz = new int[2,3];
            int[,] matrizSuma = new int[2,3];
        }
    }
}
