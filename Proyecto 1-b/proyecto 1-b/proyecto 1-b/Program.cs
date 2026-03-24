using System;

class Program
{
    static void Main()
    {
        // VARIABLES INICIALES
        string operador, codigoTurno;
        int capacidad;

        int ticketsCreados = 0;
        int ticketsCerrados = 0;
        double dinero = 0;
        int tiempo = 0;

        // Ticket activo
        bool activo = false;
        string placa = "", cliente = "";
        int tipo = 0;
        int minutoEntrada = 0;

        // REGISTRO INICIAL
        Console.Write("Nombre operador: ");
        operador = Console.ReadLine();

        do
        {
            Console.Write("Código turno (4 caracteres): ");
            codigoTurno = Console.ReadLine();
        } while (codigoTurno.Length != 4);

        do
        {
            Console.Write("Capacidad (mínimo 10): ");
        } while (!int.TryParse(Console.ReadLine(), out capacidad) || capacidad < 10);

        int opcion = 0;

        // MENU
        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Crear ticket");
            Console.WriteLine("2. Salida y cobro");
            Console.WriteLine("3. Ver estado");
            Console.WriteLine("4. Simular tiempo");
            Console.WriteLine("5. Salir");
            Console.ResetColor();

            Console.Write("Opción: ");
            int.TryParse(Console.ReadLine(), out opcion);

            // CREAR TICKET
            if (opcion == 1)
            {
                if (activo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ya existe ticket activo.");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("Placa: ");
                    placa = Console.ReadLine();

                    Console.Write("Tipo (1 Moto, 2 Auto, 3 Pickup): ");
                    int.TryParse(Console.ReadLine(), out tipo);

                    Console.Write("Cliente: ");
                    cliente = Console.ReadLine();

                    minutoEntrada = tiempo;
                    activo = true;
                    ticketsCreados++;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket creado.");
                    Console.ResetColor();
                }
            }

            // SALIDA
            else if (opcion == 2)
            {
                if (!activo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No hay ticket activo.");
                    Console.ResetColor();
                }
                else
                {
                    int minutos = tiempo - minutoEntrada;
                    double tarifa = 0;

                    if (tipo == 1) tarifa = 5;
                    else if (tipo == 2) tarifa = 10;
                    else tarifa = 15;

                    double horas = Math.Ceiling(minutos / 60.0);
                    double total = horas * tarifa;

                    if (minutos <= 15) total = 0;
                    if (horas > 6) total += 25;

                    Console.Write("¿VIP? (s/n): ");
                    string vip = Console.ReadLine();
                    if (vip == "s") total *= 0.9;

                    dinero += total;
                    ticketsCerrados++;
                    activo = false;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total a pagar: Q" + total);
                    Console.ResetColor();
                }
            }

            // ESTADO
            else if (opcion == 3)
            {
                Console.WriteLine("Capacidad: " + capacidad);
                Console.WriteLine("Ocupados: " + (activo ? 1 : 0));
                Console.WriteLine("Disponibles: " + (capacidad - (activo ? 1 : 0)));
                Console.WriteLine("Tiempo: " + tiempo);
                Console.WriteLine("Dinero: Q" + dinero);
                Console.WriteLine("Creados: " + ticketsCreados);
                Console.WriteLine("Cerrados: " + ticketsCerrados);
            }

            // TIEMPO
            else if (opcion == 4)
            {
                int min;
                Console.Write("Minutos a avanzar: ");
                if (int.TryParse(Console.ReadLine(), out min) && min >= 1 && min <= 1440)
                {
                    tiempo += min;
                    Console.WriteLine("Tiempo actual: " + tiempo);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dato inválido.");
                    Console.ResetColor();
                }
            }

        } while (opcion != 5);

        // RESUMEN FINAL
        Console.WriteLine("\n--- RESUMEN ---");
        Console.WriteLine("Operador: " + operador);
        Console.WriteLine("Dinero total: Q" + dinero);
        Console.WriteLine("Tickets creados: " + ticketsCreados);
        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
    }
}