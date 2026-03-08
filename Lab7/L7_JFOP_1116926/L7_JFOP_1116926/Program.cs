using System;

class Program
{
    static void Main()
    {


        // PARTE 1: Suma controlada por contador (WHILE)

        Console.WriteLine("EJERCICIO 1");

        int n = 0;


        while (n <= 0)
        {
            Console.Write("¿Cuántos números desea sumar?: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("El número debe ser mayor que 0");
            }
        }

        int contador = 1;
        double suma = 0;


        while (contador <= n)
        {
            Console.Write("Ingrese número " + contador + ": ");
            double num = double.Parse(Console.ReadLine());

            suma = suma + num;
            contador++;
        }

        double promedio = suma / n;

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);




        // PARTE 2: Menú de conversiones (DO-WHILE)


        Console.WriteLine("EJERCICIO 2");

        int opcion;

        do
        {
            Console.WriteLine("MENÚ");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine("Resultado: " + f.ToString("0.00"));
                    break;

                case 2:
                    Console.Write("Ingrese Fahrenheit: ");
                    double fa = double.Parse(Console.ReadLine());
                    double ce = (fa - 32) * 5 / 9;
                    Console.WriteLine("Resultado: " + ce.ToString("0.00"));
                    break;

                case 3:
                    Console.Write("Ingrese kilómetros: ");
                    double km = double.Parse(Console.ReadLine());
                    double millas = km * 0.621371;
                    Console.WriteLine("Resultado: " + millas.ToString("0.00"));
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);




        // PARTE 3: Juego Adivina el número

        Console.WriteLine("\nEJERCICIO 3");

        Random rnd = new Random();
        int numero = rnd.Next(1, 101);

        int intento = 0;
        int usuario = 0;

        while (usuario != numero)
        {
            Console.Write("Adivine el número (1-100): ");
            usuario = int.Parse(Console.ReadLine());

            // Validar rango
            if (usuario < 1 || usuario > 100)
            {
                Console.WriteLine("Número fuera de rango");
                continue;
            }

            intento++;

            if (usuario < numero)
            {
                Console.WriteLine("Más alto");
            }
            else if (usuario > numero)
            {
                Console.WriteLine("Más bajo");
            }
            else
            {
                Console.WriteLine("¡Correcto! Intentos: " + intento);
            }
        }




        // PARTE 4: PIN de acceso (DO-WHILE)

        Console.WriteLine("\nEJERCICIO 4");

        int pinCorrecto = 1234;
        int intentos = 0;
        int pin;

        do
        {
            Console.Write("Ingrese PIN: ");
            pin = int.Parse(Console.ReadLine());

            intentos++;

            if (pin == pinCorrecto)
            {
                Console.WriteLine("Acceso concedido");
                break;
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

        } while (intentos < 3);

        if (pin != pinCorrecto)
        {
            Console.WriteLine("Cuenta bloqueada");
        }

    }
}