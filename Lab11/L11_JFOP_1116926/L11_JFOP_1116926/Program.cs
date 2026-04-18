using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido(a), " + nombre);

            Console.WriteLine("\n===== LABORATORIO 11 =====");
            Console.WriteLine("1. Validación de contraseña");
            Console.WriteLine("2. Invertir texto");
            Console.WriteLine("3. Suma, promedio, mayor y menor");
            Console.WriteLine("4. Buscar número en arreglo");
            Console.WriteLine("5. Nombres en arreglo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    ValidarContrasena();
                    break;
                case 2:
                    InvertirTexto();
                    break;
                case 3:
                    ArregloNumeros();
                    break;
                case 4:
                    BuscarNumero();
                    break;
                case 5:
                    NombresArreglo();
                    break;
            }

        } while (opcion != 0);
    }


    static void ValidarContrasena()
    {
        Console.WriteLine("");
        Console.Write("===== Ejercicio 1 =====");
        Console.WriteLine("");
        Console.Write("Ingrese contraseña: ");
        string pass = Console.ReadLine();

        bool tieneLongitud = pass.Length >= 8;
        bool tieneMayuscula = false;
        bool tieneNumero = false;
        bool tieneEspecial = false;

        foreach (char c in pass)
        {
            if (char.IsUpper(c)) tieneMayuscula = true;
            if (char.IsDigit(c)) tieneNumero = true;
            if (!char.IsLetterOrDigit(c)) tieneEspecial = true;
        }

        if (tieneLongitud && tieneMayuscula && tieneNumero && tieneEspecial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.Write("Inválida: ");

            if (!tieneLongitud) Console.Write("mínimo 8 caracteres ");
            if (!tieneMayuscula) Console.Write("falta mayúscula ");
            if (!tieneNumero) Console.Write("falta número ");
            if (!tieneEspecial) Console.Write("falta carácter especial ");

            Console.WriteLine();
        }
    }


    static void InvertirTexto()
    {
        Console.WriteLine("");
        Console.Write("===== Ejercicio 2 =====");
        Console.WriteLine("");
        Console.Write("Ingrese texto: ");
        string texto = Console.ReadLine();

        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertido);
    }


    static void ArregloNumeros()
    {
        Console.WriteLine("");
        Console.Write("===== Ejercicio 3 =====");
        Console.WriteLine("");
        Console.Write("¿Cuántos números desea ingresar? ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        foreach (int num in numeros)
        {
            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
        }

        double promedio = (double)suma / n;

        Console.WriteLine($"Suma = {suma}");
        Console.WriteLine($"Promedio = {promedio}");
        Console.WriteLine($"Mayor = {mayor}");
        Console.WriteLine($"Menor = {menor}");
    }

    static void BuscarNumero()
    {
        Console.WriteLine("");
        Console.Write("===== Ejercicio 4 =====");
        Console.WriteLine("");
        int[] arreglo = new int[8];

        Console.WriteLine("Ingrese 8 números:");

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Número {i}: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscar)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
        {
            Console.WriteLine($"El número sí existe en la posición {posicion}");
        }
        else
        {
            Console.WriteLine("El número no existe en el arreglo");
        }
    }


    static void NombresArreglo()
    {
        Console.WriteLine("");
        Console.Write("===== Ejercicio 5 =====");
        Console.WriteLine("");

        string[] nombres = new string[5];
        int contador = 0;
        string nombreMasLargo = "";

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();

            if (nombres[i].Length > 5)
                contador++;

            if (i == 0 || nombres[i].Length > nombreMasLargo.Length)
                nombreMasLargo = nombres[i];
        }

        Console.WriteLine("\nNombres ingresados:");
        foreach (string n in nombres)
        {
            Console.Write(n + ", ");
        }

        Console.WriteLine($"\nMás de 5 letras: {contador}");
        Console.WriteLine($"Nombre más largo: {nombreMasLargo}");
    }
}
