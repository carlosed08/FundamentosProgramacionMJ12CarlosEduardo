using System;


namespace _8.Parcial2Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pizzería Olafo — Cálculo del precio de una pizza
            //La pizzería Olafo ofrece dos tipos de pizza: vegetariana y no vegetariana.
            //El precio final de la pizza depende del tipo de pizza, de los ingredientes seleccionados y de la combinación de ingredientes. Además, al precio base se le aplica el porcentaje de IVA correspondiente.
            string tipoPizza;
            string ingrediente1;
            string ingrediente2;
            string ingrediente3;
            string comboIngredientes;
            float precioBase=0;
            float iva = 0;
            float valorIVA = 0.0f;
            float precioFinal = 0.0f;

            Console.WriteLine("Bienvenido a la pizzeria olfato\naqui ofrecemos dos tipos de pizza diferentes:\n'Vegetariana' y 'No Vegetariana' escriba la que desea ordenar para proceder a elegir los ingredientes disponibles\n        ----Menú----\nVegetariana      No Vegetariana\n");
            tipoPizza = Console.ReadLine();
            switch (tipoPizza)
            {
                case "Vegetariana":
                    Console.WriteLine("Los ingredientes disponibles para la pizza vegetariana son:\n\nPimiento\nTofu\nChampiñones\nTomate\nLechuga\n\n---------------\nEscoja la letra correspondiente del menú para los ingredientes\n(Se pueden escojer 3 ingredientes)\n----Menú----\n   P    Tof\n   C    Tom\n   L");
                    Console.WriteLine("Ingrediente 1:");
                    ingrediente1 = Console.ReadLine();
                    Console.WriteLine("Ingrediente 2:");
                    ingrediente2 = Console.ReadLine();
                    Console.WriteLine("Ingrediente 3:");
                    ingrediente3 = Console.ReadLine();
                    comboIngredientes= ingrediente1 + ingrediente2+ ingrediente3;
                    //Console.WriteLine($"{comboIngredientes}");

                    switch (comboIngredientes)
                    {
                        //Pimienta Campiñones Lechuga
                        case "PCL":
                            precioBase = 20000;
                            iva = 19;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "PLC":
                            precioBase = 20000;
                            iva = 19;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "LPC":
                            precioBase = 20000;
                            iva = 19;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "LCP":
                            precioBase = 20000;
                            iva = 19;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "CPL":
                            precioBase = 20000;
                            iva = 19;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "CLP":
                            precioBase = 20000;
                            iva = 19;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                            //Tofu Champiñones Lechuga
                        case "TofCL":
                            precioBase = 30000;
                            iva = 15;
                            Console.WriteLine($"Pizza Vegetariana + Pimiento, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "TofLC":
                            precioBase = 30000;
                            iva = 15;
                            Console.WriteLine($"Pizza Vegetariana + Tofu, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "CLTof":
                            precioBase = 30000;
                            iva = 15;
                            Console.WriteLine($"Pizza Vegetariana + Tofu, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "LCTof":
                            precioBase = 30000;
                            iva = 15;
                            Console.WriteLine($"Pizza Vegetariana + Tofu, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "LTofC":
                            precioBase = 30000;
                            iva = 15;
                            Console.WriteLine($"Pizza Vegetariana + Tofu, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        case "CTofL":
                            precioBase = 30000;
                            iva = 15;
                            Console.WriteLine($"Pizza Vegetariana + Tofu, Champiñones y Lechuga\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;
                        default:
                            precioBase = 25000;
                            iva = 10;
                            Console.WriteLine($"Pizza Vegetariana + 3 Ingredientes\nPrecio Base: ${precioBase}\n\nIVA: {iva}%");
                        break;

                        
                    }
                break;
                case "No Vegetariana":
                    Console.WriteLine("Los ingredientes disponibles para la pizza no vegetariana son:\n\nRes\nChorizo\nPollo\nTocineta\nCerdo\n\n---------------\nEscoja la letra correspondiente del menú para los ingredientes\n(Se pueden escojer 2 ingredientes)\n----Menú----\n   R    Ch\n   P    T\n   Ce");
                    Console.WriteLine("Ingrediente 1:");
                    ingrediente1 = Console.ReadLine();
                    Console.WriteLine("Ingrediente 2:");
                    ingrediente2 = Console.ReadLine();
                    comboIngredientes = ingrediente1 + ingrediente2;
                    switch (comboIngredientes)
                    {
                        case "RP":
                            precioBase = 10000;
                            iva = 19;
                            Console.WriteLine($"Pizza No Vegetariana + Res + Pollo \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;
                        case "PR":
                            precioBase = 10000;
                            iva = 19;
                            Console.WriteLine($"Pizza No Vegetariana + Res + Pollo \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;
                        case "RT":
                            precioBase = 15000;
                            iva = 17;
                            Console.WriteLine($"Pizza No Vegetariana + Res + Tocineta \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;
                        case "TR":
                            precioBase = 15000;
                            iva = 17;
                            Console.WriteLine($"Pizza No Vegetariana + Res + Tocineta \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;
                        case "ChT":
                            precioBase = 25000;
                            iva = 9;
                            Console.WriteLine($"Pizza No Vegetariana + Chorizo + Tocineta \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;
                        case "TCh":
                            precioBase = 25000;
                            iva = 9;
                            Console.WriteLine($"Pizza No Vegetariana + Chorizo + Tocineta \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;
                        default:
                            precioBase = 22000;
                            iva = 10;
                            Console.WriteLine($"Pizza No Vegetariana + 2 Ingredientes \nPrecio Base: ${precioBase}\n\nIVA: {iva}%\n");
                            break;

                    }
                    break;

                default:
                    ingrediente1 = " ";
                    ingrediente2 = " ";
                    ingrediente3 = " ";

                    comboIngredientes = ingrediente1 + ingrediente2 + ingrediente3;
            Console.WriteLine("No son ingredientes validos");
            break;
                    
                    
            }
            //switch (tipoPizza)
            //{
                
                //default:
                    //ingrediente1 = " ";
                    //ingrediente2 = " ";
                    //ngrediente3 = " ";

                    //comboIngredientes = ingrediente1 + ingrediente2 + ingrediente3;
                    //Console.WriteLine("No son ingredientes validos");
                //break;
            //}
            valorIVA = (float)precioBase * (float)(iva / 100);
            precioFinal = (float)precioBase + (float)valorIVA;
            Console.WriteLine($"\n\nLa cuenta es la siguiente:\nTipo de pizza: {tipoPizza}\nIngredientes: {comboIngredientes}\nPrecio Base: {precioBase}\nIva: {iva}\nValor del IVA: {valorIVA}\nPrecio final: {precioFinal}");
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.");
            Console.ReadKey();

        }
    }
}
