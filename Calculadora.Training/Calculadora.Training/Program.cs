using System;

namespace Calculadora.Training
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero1, numero2, resultado;
            string tipoOperacion;

            Console.WriteLine("..........CALCULADORA LAS GORDAS..........");
            Console.WriteLine("..........Suma, Resta, Multiplica o Divide 2 Numeros..........");

            Console.WriteLine("Ingresa un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese operacion a realizar, Suma, Resta, Multiplicacion o Division:");
            tipoOperacion = Console.ReadLine();

            //if (tipoOperacion.Equals("Suma"))
            //{
            //    Console.WriteLine("El resultado de la sumas es: " + sumaDelCholo(numero1, numero2));
            //}
            //else if(tipoOperacion.Equals("Resta"))
            //{
            //    Console.WriteLine("El resultado de la resta es: " + restaCholo(numero1, numero2));
            //}
            //else if (tipoOperacion.Equals("Multiplicacion"))
            //{
            //    Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacionChuy(numero1, numero2));
            //}
            //else if (tipoOperacion.Equals("Division"))
            //{
            //    Console.WriteLine("El resultado de la division es: " + divisionChuy(numero1, numero2));
            //}  
            //else
            //{
            //    Console.WriteLine("El valor ingresado no es ningun tipo de operacion valido.");
            //}

            switch (tipoOperacion)
            {
                case "Suma":
                    Console.WriteLine("El resultado de la sumas es: " + sumaDelCholo(numero1, numero2));
                    break;
                case "Resta":
                    Console.WriteLine("El resultado de la resta es: " + restaCholo(numero1, numero2));
                    break;
                case "Multiplicacion":
                    Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacionChuy(numero1, numero2));
                    break;
                case "Division":
                    Console.WriteLine("El resultado de la division es: " + divisionChuy(numero1, numero2));
                    break;
                default:
                    Console.WriteLine("El valor ingresado no es ningun tipo de operacion valido.");
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































