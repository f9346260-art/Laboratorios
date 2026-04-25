using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        Console.WriteLine("");
        Console.Write("===== Ejercicio 1 =====");
        Console.WriteLine("");
        

        int[,] matriz1 = new int[4, 4];

        LlenarMatriz4x4(matriz1);

        Console.Write("Ingrese fila a sumar (0-3): ");
        int fila = int.Parse(Console.ReadLine());

        Console.Write("Ingrese columna a sumar (0-3): ");
        int col = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma fila: " + SumaFila(matriz1, fila));
        Console.WriteLine("Suma columna: " + SumaColumna(matriz1, col));


        Console.WriteLine("");
        Console.Write("===== Ejercicio 2 =====");
        Console.WriteLine("");

        float[,] matriz2 = new float[3, 5];

        CargarMatriz3x5(matriz2);

        float mayor = MayorMatriz(matriz2);

        Console.WriteLine("El mayor valor es: " + mayor);

        Console.WriteLine("");
        Console.Write("===== Ejercicio 3 =====");
        Console.WriteLine("");

        int[,] A = new int[2, 3];
        int[,] B = new int[3, 2];
        int[,] R = new int[2, 2];

        LlenarMatrizGenerica(A, "A");
        LlenarMatrizGenerica(B, "B");

        MultiplicarMatrices(A, B, R);

        Console.WriteLine("Matriz Resultante:");
        MostrarMatriz(R);

        Console.WriteLine("");
        Console.Write("===== Ejercicio 4 =====");
        Console.WriteLine("");

        int[,] matriz4 = new int[5, 5];

        LlenarMatriz5x5(matriz4);

        int dp = SumaDiagonalPrincipal(matriz4);
        int ds = SumaDiagonalSecundaria(matriz4);

        Console.WriteLine("Suma diagonal principal: " + dp);
        Console.WriteLine("Suma diagonal secundaria: " + ds);
    }

    
    static void LlenarMatriz4x4(int[,] m)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaFila(int[,] m, int fila)
    {
        int suma = 0;
        for (int j = 0; j < 4; j++)
            suma += m[fila, j];
        return suma;
    }

    static int SumaColumna(int[,] m, int col)
    {
        int suma = 0;
        for (int i = 0; i < 4; i++)
            suma += m[i, col];
        return suma;
    }

    
    static void CargarMatriz3x5(float[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
    }

    static float MayorMatriz(float[,] m)
    {
        float mayor = m[0, 0];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                if (m[i, j] > mayor)
                    mayor = m[i, j];

        return mayor;
    }

    
    static void LlenarMatrizGenerica(int[,] m, string nombre)
    {
        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"{nombre}[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static void MultiplicarMatrices(int[,] A, int[,] B, int[,] R)
    {
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < B.GetLength(1); j++)
            {
                R[i, j] = 0;
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    R[i, j] += A[i, k] * B[k, j];
                }
            }
    }

    static void MostrarMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(m[i, j] + "\t");
            Console.WriteLine();
        }
    }

    
    static void LlenarMatriz5x5(int[,] m)
    {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, i];
        return suma;
    }

    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, 4 - i];
        return suma;
    }
}