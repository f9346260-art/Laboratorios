using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de usuario
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            // Salida de datos
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            Console.WriteLine("");

            //Ejercicio 1
            Console.Write("===== Ejercicio 1 =====");

            Console.WriteLine("");

            int suma = 0;
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese nota: ");
                int nota = int.Parse(Console.ReadLine());

                suma += nota;

                if (nota >= 61)
                    aprobados++;
                else
                    reprobados++;
            }

            Console.WriteLine("Promedio: " + (suma / 10));
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);

            Console.WriteLine("");

            //Ejercicio 2
            Console.Write("===== Ejercicio 2 =====");

            Console.WriteLine("");

            Console.WriteLine("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            int Suma2 = 0;
            int Pares = 0;
            int Impares = 0;

            for (int i = 1; i <= N; i++)
            {
                Suma2 += i;
                if (i % 2 == 0)
                    Pares++;
                else
                    Impares++;
            }
            Console.WriteLine("Suma: " + Suma2);
            Console.WriteLine("Pares: " + Pares);
            Console.WriteLine("Impares: " + Impares);

            Console.WriteLine("");

            //ejercicio 3
            Console.Write("===== Ejercicio 3 =====");

            Console.WriteLine("");

            int opcion = 0;
            int total = 0;
            int clientes = 0;

            do
            {
                Console.WriteLine("1 Registrar compra");
                Console.WriteLine("2 Mostrar ventas");
                Console.WriteLine("3 Mostrar clientes");
                Console.WriteLine("4 Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Monto: ");
                        int compra = int.Parse(Console.ReadLine());
                        total += compra;
                        clientes++;
                        break;

                    case 2:
                        Console.WriteLine("Total ventas: " + total);
                        break;

                    case 3:
                        Console.WriteLine("Clientes: " + clientes);
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("");

            Console.Write("===== Ejercicio 4 =====");

            Console.WriteLine("");

            int numero;
            int totalNum = 0;
            int positivos = 0;
            int negativos = 0;
            int sumaNum = 0;

            do
            {
                Console.Write("Ingrese número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    totalNum++;
                    sumaNum += numero;

                    if (numero > 0)
                        positivos++;
                    else
                        negativos++;
                }

            } while (numero != 0);

            Console.WriteLine("Cantidad: " + totalNum);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Suma: " + sumaNum);

            Console.WriteLine("");

            // -------- EJERCICIO 5 --------
            Console.Write("===== Ejercicio 5 =====");

            Console.WriteLine("");

            Console.Write("Ingrese N: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}

