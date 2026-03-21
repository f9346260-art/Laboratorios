using System;

class Program
{
    
   

    static void Main()
    {
        Console.WriteLine("Laboratorio 9 - Procedimientos");

        Console.WriteLine("Laboratorio 9\n");

        Ej1();
        Ej2();
        Ej3();
        Ej4();
        Ej5();
    }

    // EJERCICIO 1
    static void Ej1()
    {
        Console.Write("===== Ejercicio 1 =====");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Nombre: ");
        string n = Console.ReadLine();
        Saludo(n);
        Curso();
    }

    static void Saludo(string n) => Console.WriteLine("Hola " + n);
    static void Curso() => Console.WriteLine("Prog 1 - Lab 9");


    // EJERCICIO 2
    static void Ej2()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("===== Ejercicio 2 =====");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Lado: ");
        AreaC(double.Parse(Console.ReadLine()));

        Console.Write("Base y altura rectangulo: ");
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        AreaR(b, h);

        Console.Write("Base y altura triangulo: ");
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
        AreaT(b, h);
    }

    static void AreaC(double l) => Console.WriteLine(l * l);
    static void AreaR(double b, double h) => Console.WriteLine(b * h);
    static void AreaT(double b, double h) => Console.WriteLine((b * h) / 2);

    // EJERCICIO 3
    static void Ej3()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("===== Ejercicio 3 =====");
        Console.WriteLine("");
        Console.WriteLine("");
        int op;
        do
        {
            Console.WriteLine("\n1.Cuadrado 2.Triángulo 3.Línea 4.Salir");
            op = int.Parse(Console.ReadLine());

            if (op < 4)
            {
                Console.Write("N: ");
                int n = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: Cuadrado(n); break;
                    case 2: Triangulo(n); break;
                    case 3: Linea(n); break;
                }
            }

        } while (op != 4);
    }

    static void Cuadrado(int n)
    {
        for (int i = 0; i < n; i++)
            Console.WriteLine(new string('*', n));
    }

    static void Triangulo(int n)
    {
        for (int i = 1; i <= n; i++)
            Console.WriteLine(new string('*', i));
    }

    static void Linea(int n) => Console.WriteLine(new string('*', n));

    // EJERCICIO 4
    static void Ej4()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("===== Ejercicio 4 =====");
        Console.WriteLine("");
        Console.WriteLine("");
        double suma = 0;
        int ap = 0, rep = 0;

        for (int i = 0; i < 5; i++)
        {
            double nota = double.Parse(Console.ReadLine());
            Eval(nota, ref ap, ref rep);
            suma += nota;
        }

        Console.WriteLine("Promedio: " + suma / 5);
        Console.WriteLine("Aprobado: " + ap);
        Console.WriteLine("Reprobado: " + rep);
    }

    static void Eval(double n, ref int a, ref int r)
    {
        if (n >= 61) a++; else r++;
    }

    // EJERCICIO 5
    static void Ej5()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("===== Ejercicio 5 =====");
        Console.WriteLine("");
        Console.WriteLine("");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Antes: " + a + "," + b);
        Swap(ref a, ref b);
        Console.WriteLine("Después: " + a + "," + b);
    }

    static void Swap(ref int x, ref int y)
    {
        int t = x; x = y; y = t;
    }
}