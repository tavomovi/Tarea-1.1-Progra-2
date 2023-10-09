using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1._1_Progra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Tarea de Programacion");
                Console.WriteLine("1- Ejercicio 1 - Tienda");
                Console.WriteLine("2- Ejercicio 2 - Promedio Notas");
                Console.WriteLine("3- Ejercicio 3 - Venta Productos");
                Console.WriteLine("4- Salir");
                Console.Write("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("El valor ingresado es incorrecto.");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 4);
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1 - TIENDA");
            int camisas;
            float precio;

            Console.Write("Digite la cantidad de camisas: ");
            camisas = int.Parse(Console.ReadLine());

            Console.Write("Digite el precio unitario de la camisa: ");
            precio = float.Parse(Console.ReadLine());

            calculoCamisas(camisas, precio);
        }

        static void calculoCamisas(int camisas, float precio)
        { 
            if (camisas == 0)
            {
                Console.WriteLine("No digito ninguna camisa");
            }
            else if (camisas == 1)
            {
                Console.WriteLine("El total a pagar es de: " + camisas * precio);
            }
            else if (camisas > 1 && camisas < 6)
            {
                Console.WriteLine("Aplica descuento de 15%");
                Console.WriteLine("El valor a pagar es de: " + camisas * precio * 0.85);
            }
            else if (camisas > 5)
            {
                Console.WriteLine("Aplica descuento de 20%");
                Console.WriteLine("El valor a pagar es de: " + camisas * precio * 0.8);
            }
            else
            {
                Console.WriteLine("El valor ingresado es incorrecto.");
            }
            Console.ReadLine();
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2 - Calculo de nota");
            int carnet;
            string nombre;
            float quiz, tarea, examen, porcentajeQuiz = 0, porcentajeTarea = 0, porcentajeExamen = 0, promedioFinal = 0;

            Console.Write("Digite el numero de carnet del Estudiante: ");
            carnet = int.Parse(Console.ReadLine());
            Console.Write("Digite el nombre del Estudiante: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("Digite la nota del quiz " + (j + 1) + ": ");
                        quiz = float.Parse(Console.ReadLine());
                        porcentajeQuiz += quiz;
                    }
                    if (i == 1)
                    {
                        Console.Write("Digite la nota del tarea " + (j + 1) + ": ");
                        tarea = float.Parse(Console.ReadLine());
                        porcentajeTarea += tarea;
                    }
                    if (i == 2)
                    {
                        Console.Write("Digite la nota del examen " + (j + 1) + ": ");
                        examen = float.Parse(Console.ReadLine());
                        porcentajeExamen += examen;
                    }
                }
            }
            porcentajeQuiz = porcentajeQuiz / 3 * 25 / 100;
            porcentajeTarea = porcentajeTarea / 3 * 30 / 100;
            porcentajeExamen = porcentajeExamen / 3 * 45 / 100;
            promedioFinal = porcentajeQuiz + porcentajeTarea + porcentajeExamen;

            Console.Write("Presione Enter para calcular la nota");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Desglose de nota");
            Console.WriteLine($"Estudiante: {nombre} - Numero de carnet: {carnet}");
            Console.WriteLine($"Porcentaje obtenido en Quices: {porcentajeQuiz}");
            Console.WriteLine($"Porcentaje obtenido en Tareas: {porcentajeTarea}");
            Console.WriteLine($"Porcentaje obtenido en Examenes: {porcentajeExamen}");
            Console.WriteLine($"Promedio Final: {promedioFinal}");
            if (promedioFinal >= 70) { Console.WriteLine("Condicion: APROBADO"); }
            else if (promedioFinal >= 50 && promedioFinal < 70) { Console.WriteLine("Condicion: APLAZADO"); }
            else { Console.WriteLine("Condicion: REPROBADO"); }

            Console.ReadLine();
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3 - VENTA DE PRODUCTOS");
            int cantidad;

            Console.WriteLine("Digite la cantidad de productos que desea comprar: ");
            cantidad = int.Parse(Console.ReadLine());
            calculoProductos(cantidad);
        }

        static void calculoProductos(int cantidad) { 
            if (cantidad > 0 && cantidad < 11)
            {
                Console.WriteLine("El precio por producto es de $20");
                Console.WriteLine($"El total a pagar por {cantidad} productos es de: $" + cantidad * 20);
            }
            else if (cantidad > 10)
            {
                Console.WriteLine("El precio por producto es de $15");
                Console.WriteLine($"El total a pagar por {cantidad} productos es de: $" + cantidad * 15);
            }
            else
            {
                Console.WriteLine("El valor ingresado es incorrecto.");
            }
            Console.ReadLine();
        }
    }
}
