/*
 * Programación III
 * Daniel Cedillo Guevara
 * Practica 1: Calculadora
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Practica1
    {
        double ope1, ope2;
        string s;

        public Practica1()
        {
            ope1 = ope2 = 0.0;
            s = "";
        }

        private void ObtenerDatos()
        {
                Console.Write("Valor 1: ");
                ope1 = double.Parse(Console.ReadLine());
                Console.Write("Valor 2: ");
                ope2 = double.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Practica1 p = new Practica1();
            double res = 0.0;
            char c;

            do
            {
                char op2;
                Console.Clear();
                Console.Out.Write("\n1. Suma\n2. Resta\n3. Multiplicación\n4. División\n5. Áreas\n6. Salir\n\nElije opción: ");
                p.s = Console.ReadLine();
                c = p.s[0];

                switch (c)
                {
                    case '1':
                        try
                        {
                            p.ObtenerDatos();
                            res = p.ope1 + p.ope2;
                            Console.WriteLine("La suma es: " + res);
                            Console.ReadLine();
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Entrada no válida");
                            Console.ReadLine();
                        }
                        break;
                    case '2':
                        try
                        {
                            p.ObtenerDatos();
                            res = p.ope1 - p.ope2;
                            Console.WriteLine("La diferencia es: " + res);
                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Entrada no válida");
                            Console.ReadLine();
                        }
                        break;
                    case '3':
                        try
                        {
                            p.ObtenerDatos();
                            res = p.ope1 * p.ope2;
                            Console.WriteLine("El producto es: " + res);
                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Entrada no válida");
                            Console.ReadLine();
                        }
                        break;
                    case '4':
                        try
                        {
                            p.ObtenerDatos();
                            res = p.ope1 / p.ope2;
                            Console.WriteLine("El cociente es: " + res);
                            Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Entrada no válida");
                            Console.ReadLine();
                        }
                        break;
                    case '5':
                        try
                        {
                            do
                            {
                                Console.Write("\n1. Triángulo\n2. Círculo\n3. Cuadrado\n4. Salir\n\nOpción: ");
                                p.s = Console.ReadLine();
                                op2 = p.s[0];
                                switch (op2)
                                {
                                    case '1':
                                        Console.WriteLine("Introduce la base y la altura.");
                                        p.ObtenerDatos();
                                        res = p.ope1 * p.ope2 / 2.0f;
                                        Console.WriteLine("El área del triángulo es: " + res);
                                        break;
                                    case '2':
                                        Console.Write("Introduce el radio: ");
                                        p.ope1 = double.Parse(Console.ReadLine());
                                        res = Math.PI * Math.Pow(p.ope1, 2);
                                        Console.WriteLine("El área del círculo es: " + res);
                                        break;
                                    case '3':
                                        Console.Write("Medida de un lado del cuadrado: ");
                                        p.ope1 = double.Parse(Console.ReadLine());
                                        res = Math.Pow(p.ope1, 2);
                                        Console.WriteLine("El área del cuadrado es: " + res);
                                        break;
                                }
                                Console.ReadLine();
                            }
                            while (op2 != '4');
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Entrada no válida");
                            Console.ReadLine();
                        }
                        break;
                    case '6':
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            while (c != '6');
        }
    }
}
