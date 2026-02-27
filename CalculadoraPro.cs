using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir Variables

            char continuar = 'S';
            string nombre, valida;
            int cuenta_operaciones = 0;
            int operacion = 0;
            double numero1;
            double numero2;

            // Estructura
            Console.WriteLine(" ******* BIENVENIDO/A ******* ");
            Console.WriteLine(" CALCULADORA BASICA ");
            Console.Write("Escribe tu Nombre: ");
            nombre = Console.ReadLine();

            do
            {
                Console.WriteLine(" \n**** MENU PRINCIPAL **** ");
                Console.WriteLine(" 1.-SUMAR ");
                Console.WriteLine(" 2.-RESTAR ");
                Console.WriteLine(" 3.-MULTIPLICAR ");
                Console.WriteLine(" 4.-DIVIDIR ");
                Console.WriteLine(" 4.-DIVIDIR ");
                Console.WriteLine(" 7.-FACTORIAL ");
                Console.Write(" Escoge una operación a ejecutar: ");
                operacion = int.Parse(Console.ReadLine());

                if (operacion >= 1 && operacion <= 7)
                {
                    switch (operacion)
                    {
                        case 1:
                            Console.WriteLine("\n ---OPERACIÓN SUMA---");
                            Console.Write("Digita el primer número: ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.Write("Digita el segundo número: ");
                            numero2 = double.Parse(Console.ReadLine());
                            double resp_suma = numero1 + numero2;
                            Console.WriteLine("El Resultado de la Suma es: " + resp_suma);

                            cuenta_operaciones++;
                            break;

                        case 2:
                            Console.WriteLine("\n ---OPERACIÓN RESTA---");
                            Console.Write("Digita el primer número (minuendo): ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.Write("Digita el segundo número (sustraendo): ");
                            numero2 = double.Parse(Console.ReadLine());
                            double resp_resta = numero1 - numero2;
                            Console.WriteLine("El Resultado de la Resta es: " + resp_resta);
                            cuenta_operaciones++;
                            break;

                        case 3:
                            Console.WriteLine("\n ---OPERACIÓN MULTIPLICACIÓN---");
                            Console.Write("Digita el primer número (multiplicando): ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.Write("Digita el segundo número (multiplicador): ");
                            numero2 = double.Parse(Console.ReadLine());
                            double resp_multiplica = numero1 * numero2;
                            Console.WriteLine("El Resultado de la Multiplicación es: " + resp_multiplica);

                            cuenta_operaciones++;
                            break;

                        case 4:
                            Console.WriteLine("\n ---OPERACIÓN DIVISIÓN---");
                            Console.Write("Digita el primer número (dividendo): ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.Write("Digita el segundo número (divisor): ");
                            numero2 = double.Parse(Console.ReadLine());
                            if (numero2 == 0)
                            {
                                Console.WriteLine("No es posible dividir para 0.");
                            }

                            else
                            {
                                double resp_divide = numero1 / numero2;
                                Console.WriteLine("El Resultado de la División es: " + resp_divide);
                                cuenta_operaciones++;
                            }
                            break;
                        case 5:
                            Console.WriteLine("\n ---RAIZ CUADRADA---");
                            Console.Write("Digita el número: ");

                            int numeroRaiz = int.Parse(Console.ReadLine());

                            while (numeroRaiz < 0)
                            {
                                Console.WriteLine("Error: no puede ingresar un numero negativo.");
                                Console.Write("Ingrese nuevamente el numero: ");
                                numeroRaiz = int.Parse(Console.ReadLine());
                            }

                            double resultado = Math.Sqrt(numeroRaiz);

                            Console.WriteLine("La raíz cuadrada de " + numeroRaiz + " es: " + resultado);

                            break;
                        case 7:
                            Console.WriteLine("=== OPERACION FACTORIAL ==");
                            Console.Write("Ingrese el numero que desea saber su factorial: ");
                            int numeroIngresado = int.Parse(Console.ReadLine());
                            while (numeroIngresado < 0)
                            {
                                Console.WriteLine("Error: no puede ingresar un numero negativo.");
                                Console.Write("Ingrese nuevamente el numero: ");
                                numeroIngresado = int.Parse(Console.ReadLine());
                            }
                            double fact = 1;
                            for (int i = 1; i <= numeroIngresado; i++)
                            {
                                fact *= i;
                            }

                            Console.WriteLine("numero Ingresado: " + numeroIngresado + "\nSu factorial es" + " = " + fact);
                            cuenta_operaciones++;
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Operación No disponible.");
                }

                do
                {
                    Console.Write("\n¿Desea Continuar S/N? ");
                    valida = Console.ReadLine();
                    if (string.IsNullOrEmpty(valida) || (valida.ToUpper() != "S" && valida.ToUpper() != "N"))
                    {
                        Console.Write("Solo se pueden ingresar S o N\n");
                    }
                }
                while (string.IsNullOrEmpty(valida) || (valida.ToUpper() != "S" && valida.ToUpper() != "N"));

                continuar = valida.ToUpper()[0];


            } while (continuar != 'N');
            Console.WriteLine("\nUsuario: " + nombre + " Ha realizado " + cuenta_operaciones + " operaciones. \nSaliendo del Sistema.");
            // Esta es una actualización de prueba




        }
    }
}
