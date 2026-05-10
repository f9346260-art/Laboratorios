using System;
using System.Linq;
using System.Security.AccessControl;

namespace L14_JP2026
{
   
    // EJERCICIO 1 - LIBRO
    
    class Libro
    {
        

        private string titulo;
        private string autor;
        private int anioPublicacion;
        private bool disponible;


        public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            this.disponible = disponible;
        }


        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Año de publicación: " + anioPublicacion);
            Console.WriteLine("Disponible: " + (disponible ? "Sí" : "No"));
            Console.WriteLine();
        }

       
        public void PrestarLibro()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine("El libro fue prestado.");
            }
            else
            {
                Console.WriteLine("El libro no está disponible.");
            }
        }


        public void DevolverLibro()
        {
            disponible = true;
            Console.WriteLine("El libro fue devuelto.");
        }
    }


    // EJERCICIO 2 - MASCOTA

    class Mascota
    {

        private string nombre;
        private string especie;
        private int edad;
        private bool vacunado;

  
        public Mascota(string nombre, string especie, int edad, bool vacunado)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
            this.vacunado = vacunado;
        }


        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Vacunado: " + (vacunado ? "Sí" : "No"));
            Console.WriteLine();
        }


        public void Vacunar()
        {
            vacunado = true;
            Console.WriteLine(nombre + " ha sido vacunado.");
        }


        public void CumplirAnios()
        {
            edad++;
            Console.WriteLine(nombre + " ahora tiene " + edad + " años.");
        }
    }


    // EJERCICIO 3 - ESTUDIANTE

    class Estudiante
    {

        private string nombre;
        private int edad;
        private string grado;
        private double[] notas;


        public Estudiante(string nombre, int edad, string grado, double[] notas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notas;
        }


        public double CalcularPromedio()
        {
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }

            return suma / notas.Length;
        }


        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);

            Console.Write("Notas: ");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Promedio: " + CalcularPromedio().ToString("0.00"));
            Console.WriteLine();
        }


        public void Aprobar()
        {
            if (CalcularPromedio() >= 61)
            {
                Console.WriteLine(nombre + " aprobó.");
            }
            else
            {
                Console.WriteLine(nombre + " reprobó.");
            }
        }


        public void AgregarNota(double nuevaNota)
        {
            Array.Resize(ref notas, notas.Length + 1);
            notas[notas.Length - 1] = nuevaNota;

            Console.WriteLine("Nueva nota agregada: " + nuevaNota);
        }
    }


    // PROGRAMA PRINCIPAL

    class Program
    {
        static void Main(string[] args)
        {

            // EJERCICIO 1
            Console.WriteLine("");
            Console.Write("========= EJERCICIO 1 =========\n");
            Console.WriteLine("");

            Libro libro1 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1967, true);
            Libro libro2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605, true);

            libro1.MostrarInformacion();
            libro2.MostrarInformacion();

            Console.WriteLine("Prestando libro 1...");
            libro1.PrestarLibro();
            libro1.MostrarInformacion();

            Console.WriteLine("Devolviendo libro 1...");
            libro1.DevolverLibro();
            libro1.MostrarInformacion();


            // EJERCICIO 2
            Console.WriteLine("");
            Console.WriteLine("========= EJERCICIO 2 =========\n");
            Console.WriteLine("");

            Mascota mascota1 = new Mascota("Max", "Perro", 3, false);
            Mascota mascota2 = new Mascota("Michi", "Gato", 2, false);

            mascota1.MostrarInformacion();
            mascota2.MostrarInformacion();

            Console.WriteLine("Vacunando mascota 1...");
            mascota1.Vacunar();
            mascota1.MostrarInformacion();

            Console.WriteLine("Incrementando edad...");
            mascota1.CumplirAnios();
            mascota1.MostrarInformacion();


            // EJERCICIO 3
            Console.WriteLine("");
            Console.WriteLine("========= EJERCICIO 3 =========\n");
            Console.WriteLine("");

            double[] notas1 = { 70, 80, 90 };
            double[] notas2 = { 50, 55, 60 };

            Estudiante estudiante1 = new Estudiante("Juan", 16, "5to Bach", notas1);
            Estudiante estudiante2 = new Estudiante("María", 17, "5to Bach", notas2);

            estudiante1.MostrarInformacion();
            estudiante1.Aprobar();

            Console.WriteLine();

            estudiante2.MostrarInformacion();
            estudiante2.Aprobar();

            Console.WriteLine("\nAgregando nueva nota a Juan...\n");

            estudiante1.AgregarNota(100);

            estudiante1.MostrarInformacion();
            estudiante1.Aprobar();

            Console.ReadKey();
        }
    }
}