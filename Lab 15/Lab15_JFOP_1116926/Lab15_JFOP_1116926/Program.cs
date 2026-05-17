// Proyecto: L15_TUINICIAL_TUCARNE
// Laboratorio 15 - Control de calidad y depuración
// Curso: Programación en C#
// Descripción:
// Este archivo contiene la solución completa de los 5 ejercicios solicitados.
// Cada ejercicio incluye:
// - Identificación de errores
// - Correcciones realizadas
// - Explicaciones
// - Validaciones
// - Pruebas sugeridas

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Laboratorio 15";


        // EJERCICIO 1


        Console.WriteLine("");
        Console.WriteLine("=== EJERCICIO 1 ===");
        Console.WriteLine("");

        /*
        // Código original con errores:

        using System
        class Program
        {
        static void Main()
        {
        string nombre
        int edad;
        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine())
        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");
        if (edad >= 18)
        {
        Console.WriteLine("Eres mayor de edad");
        else
        {
        Console.WriteLine("Eres menor de edad");
        }
        }
        }

        */

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada:
        // Se agregó punto y coma después de using System;
        // Explicación:
        // En C# todas las instrucciones deben finalizar correctamente.

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada:
        // Se agregó punto y coma después de string nombre;
        // Explicación:
        // La declaración de variables requiere punto y coma.

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada:
        // Se agregó punto y coma después de int.Parse(Console.ReadLine());
        // Explicación:
        // Toda instrucción debe terminar con ;

        // Error encontrado:
        // Tipo de error: sintaxis
        // Corrección realizada:
        // Se cerró correctamente el bloque if antes del else.
        // Explicación:
        // El else debe ir después de cerrar correctamente el bloque if.

        string nombre;
        int edad;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }

        // Pruebas realizadas:
        // Edad 20 -> Eres mayor de edad
        // Edad 15 -> Eres menor de edad

        Console.WriteLine();




        // EJERCICIO 2


        Console.WriteLine("");
        Console.WriteLine("=== EJERCICIO 2 ===");
        Console.WriteLine("");

        /*
        Error lógico original:

        promedio = nota1 + nota2 + nota3 / 3;

        Problema:
        Solo nota3 se dividía entre 3 por prioridad de operadores.

        También:
        if (promedio > 61)

        Problema:
        Un promedio de 61 reprobaba incorrectamente.
        */

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada:
        // Se agregaron paréntesis al cálculo.
        // Explicación:
        // Primero se suman las notas y luego se divide entre 3.

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada:
        // Se cambió > por >=
        // Explicación:
        // El estudiante aprueba con 61 o más.

        double nota1, nota2, nota3, promedio;

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 61)
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }

        // Casos de prueba:
        // 60,60,60 -> 60 -> Reprobó
        // 61,61,61 -> 61 -> Aprobó
        // 70,90,80 -> 80 -> Aprobó

        Console.WriteLine();




        // EJERCICIO 3


        Console.WriteLine("");
        Console.WriteLine("=== EJERCICIO 3 ===");
        Console.WriteLine("");

        /*
        Error original:

        for (int i = 0; i <= 5; i++)

        Problema:
        El arreglo tiene posiciones de 0 a 4.
        La posición 5 no existe.
        */

        // Error encontrado:
        // Tipo de error: ejecución
        // Corrección realizada:
        // Se cambió i <= 5 por i < 5
        // Explicación:
        // Así solo se recorren posiciones válidas.

        // Error encontrado:
        // Tipo de error: ejecución
        // Corrección realizada:
        // Se implementó int.TryParse()
        // Explicación:
        // Evita que el programa falle si el usuario escribe texto.

        int[] numeros = new int[5];
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            bool valido = false;

            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");

                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente nuevamente.");
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            suma = suma + numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);

        // Pruebas:
        // 1,2,3,4,5 -> 15
        // Texto -> vuelve a pedir el dato

        Console.WriteLine();




        // EJERCICIO 4


        Console.WriteLine("");
        Console.WriteLine("=== EJERCICIO 4 ===");
        Console.WriteLine("");

        /*
        Error original:

        double resultado = baseRectangulo + alturaRectangulo;

        Problema:
        El área se calcula multiplicando, no sumando.
        */

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada:
        // Se reemplazó suma por multiplicación.
        // Explicación:
        // El área del rectángulo es base * altura.

        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada:
        // Se cambió >100 por >=100
        // Explicación:
        // Un área igual a 100 también es grande.

        // Error encontrado:
        // Tipo de error: ejecución
        // Corrección realizada:
        // Se agregó validación con TryParse y validación positiva.
        // Explicación:
        // Evita errores y datos inválidos.

        double baseRectangulo = LeerNumeroPositivo("Ingrese la base del rectángulo:");
        double alturaRectangulo = LeerNumeroPositivo("Ingrese la altura del rectángulo:");

        Console.WriteLine("Base ingresada: " + baseRectangulo);
        Console.WriteLine("Altura ingresada: " + alturaRectangulo);

        double area = CalcularArea(baseRectangulo, alturaRectangulo);

        Console.WriteLine("Área calculada: " + area);

        if (area >= 100)
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }

        // Casos de prueba:
        // 10 x 10 = 100 -> Grande
        // 5 x 8 = 40 -> Pequeña
        // 20 x 6 = 120 -> Grande
        // -5 -> No permitido

        Console.WriteLine();




        // EJERCICIO 5


        Console.WriteLine("");
        Console.WriteLine("=== EJERCICIO 5 ===");
        Console.WriteLine("");

        /*
        // Análisis de la solución generada por IA:

        // Error 1:
        // El ciclo iniciaba en 1 y terminaba en 5.
        // El arreglo usa posiciones de 0 a 4.

        // Error 2:
        // Usaba > 18 en lugar de >= 18.

        // Error 3:
        // El promedio se calculaba usando división entera.

        // Limitación encontrada:
        // No validaba texto ni edades negativas.

        // Importancia de la validación humana:
        // La IA puede generar código aparentemente correcto,
        // pero puede contener errores de lógica,
        // ejecución o validaciones incompletas.
        // El programador debe revisar, probar y validar
        // todo el código antes de utilizarlo.
        */

        int[] edades = new int[5];
        int sumaEdades = 0;
        int mayores = 0;
        double promedioEdades;

        for (int i = 0; i < 5; i++)
        {
            bool valido = false;

            while (!valido)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");

                if (int.TryParse(Console.ReadLine(), out edades[i]))
                {
                    if (edades[i] >= 0)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("La edad no puede ser negativa.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                }
            }

            sumaEdades += edades[i];

            if (edades[i] >= 18)
            {
                mayores++;
            }
        }

        promedioEdades = (double)sumaEdades / 5;

        Console.WriteLine("El promedio de edades es: " + promedioEdades);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

        // Casos de prueba:
        // 10,15,18,20,30 -> Promedio 18.6 -> Mayores 3
        // 18,18,18,18,18 -> Promedio 18 -> Mayores 5
        // 5,6,7,8,9 -> Promedio 7 -> Mayores 0

        Console.WriteLine();
        Console.WriteLine("");
        Console.WriteLine("=== Fin del laboratorio ===");
        Console.WriteLine("");
    }




    // MÉTODO DEL EJERCICIO 4


    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        // Error encontrado:
        // Tipo de error: lógico
        // Corrección realizada:
        // Se cambió + por *
        // Explicación:
        // El área de un rectángulo es base multiplicada por altura.

        double resultado = baseRectangulo * alturaRectangulo;

        return resultado;
    }




    // MÉTODO DE VALIDACIÓN


    static double LeerNumeroPositivo(string mensaje)
    {
        double numero;
        bool valido = false;

        do
        {
            Console.WriteLine(mensaje);

            if (double.TryParse(Console.ReadLine(), out numero))
            {
                if (numero > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("El valor debe ser mayor que cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número.");
            }

        } while (!valido);

        return numero;
    }
}



/*

PREGUNTA FINAL DE REFLEXIÓN


// ¿Por qué una solución generada por Inteligencia Artificial
// debe ser revisada, probada y validada por una persona
// antes de considerarse correcta?

// Respuesta:
// Porque la Inteligencia Artificial puede generar código
// con errores de sintaxis, lógica o ejecución.
// Aunque el programa parezca correcto, puede producir
// resultados incorrectos o fallar durante la ejecución.
// La IA no siempre entiende completamente el contexto
// ni todas las reglas del problema.
// Además, muchas veces no incluye validaciones adecuadas.
// Por esa razón, un programador debe revisar,
// probar y validar el código antes de utilizarlo.
*/