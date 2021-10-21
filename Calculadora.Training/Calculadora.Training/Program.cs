using System;
using System.Collections.Generic;

namespace Calculadora.Training
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero1, numero2;
            decimal resultado = 0;
            string tipoOperacion, Respuesta;
            bool otroNUmero = true;
            int i = 0;

            List<decimal> valores = new List<decimal>();

            Console.WriteLine("..........CALCULADORA LAS GORDAS..........");
            Console.WriteLine("..........Suma, Resta, Multiplica o Divide 2 Numeros..........");

            Console.WriteLine("Ingresa un numero: ");
            valores.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Ingrese otro numero: ");
            valores.Add(Convert.ToInt32(Console.ReadLine()));

            do
            {
                Console.WriteLine("Quieres ingresar otro numero SI/NO?");
                Respuesta = Console.ReadLine();
                if (Respuesta.Equals("SI"))
                {
                    Console.WriteLine("Ingrese otro numero: ");
                    valores.Add(Convert.ToInt32(Console.ReadLine()));
                }
                else if (Respuesta.Equals("NO"))
                {
                    otroNUmero = false;
                }
            } while (otroNUmero);

            Console.WriteLine("Ingrese operacion a realizar, Suma, Resta, Multiplicacion o Division:");
            tipoOperacion = Console.ReadLine();

                switch (tipoOperacion)
                {
                    case "Suma":
                    do
                    {
                        resultado = resultado + valores[i];
                        i++;
                    } while (valores.Count > i);
                        break;
                    case "Resta":
                    do
                    {
                        resultado = resultado - valores[i];
                        if (i == 0)
                        {
                            resultado = resultado * -1;
                        }
                        i++;
                      
                     } while (valores.Count > i);
                    break;
                case "Multiplicacion":
                    do
                    {
                        resultado = resultado == 0 ? resultado = valores[i] : resultado * valores[i];
                        i++;
                    } while (valores.Count > i);
                    Console.WriteLine($"El resultado de la multiplicacion es:{resultado}");
                    break;
                    case "Division":
                     //   Console.WriteLine("El resultado de la division es: " + divisionChuy(numero1, numero2));
                        break;
                    default:
                    //    Console.WriteLine("El valor ingresado no es ningun tipo de operacion valido.");
                        break;

                }

            }     

        //Author: Marcos Granados
        //Metodo: sumaDelCholo
        //Descripcion: Suma 2 numeros

        private static decimal sumaDelCholo(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        private static decimal restaCholo(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        private static decimal multiplicacionChuy(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        private static decimal divisionChuy(decimal num1, decimal num2)
        {
            if (num1 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0 no mames!");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}































