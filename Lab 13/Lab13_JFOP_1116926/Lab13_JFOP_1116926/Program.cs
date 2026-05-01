using System;


// CLASE PERSONA

class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}


// CLASE VEHICULO

class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}


// CLASE PRODUCTO

class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}


// CLASE MASCOTA

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}


// PROGRAMA PRINCIPAL

class Program
{
    static void Main()
    {
        
        Console.WriteLine("");
        Console.Write("=== EJERCICIO 1: PERSONA ===");
        Console.WriteLine("");

        Persona persona1 = new Persona();
        persona1.nombre = "José";
        persona1.edad = 20;
        persona1.altura = 1.75;
        persona1.estudiante = true;

        Console.WriteLine("=== PERSONA ===");
        Console.WriteLine("Nombre: " + persona1.nombre);
        Console.WriteLine("Edad: " + persona1.edad);
        Console.WriteLine("Altura: " + persona1.altura);
        Console.WriteLine("Estudiante: " + persona1.estudiante);
        Console.WriteLine();

        
        Console.WriteLine("");
        Console.Write("=== EJERCICIO 2: VEHICULO ===");
        Console.WriteLine("");

        Vehiculo vehiculo1 = new Vehiculo();
        vehiculo1.marca = "Toyota";
        vehiculo1.modelo = "Corolla";
        vehiculo1.anio = 2022;
        vehiculo1.color = "Blanco";
        vehiculo1.placa = "P123ABC";

        Console.WriteLine("=== VEHICULO ===");
        Console.WriteLine("Marca: " + vehiculo1.marca);
        Console.WriteLine("Modelo: " + vehiculo1.modelo);
        Console.WriteLine("Año: " + vehiculo1.anio);
        Console.WriteLine("Color: " + vehiculo1.color);
        Console.WriteLine("Placa: " + vehiculo1.placa);
        Console.WriteLine();

       
        Console.WriteLine("");
        Console.Write("=== EJERCICIO 3: PRODUCTO ===");
        Console.WriteLine("");
        Producto producto1 = new Producto();
        producto1.codigo = "P001";
        producto1.nombre = "Laptop";
        producto1.precio = 5500.50;
        producto1.stock = 10;
        producto1.disponible = true;

        Producto producto2 = new Producto();
        producto2.codigo = "P002";
        producto2.nombre = "Mouse";
        producto2.precio = 150.75;
        producto2.stock = 0;
        producto2.disponible = false;

        Console.WriteLine("=== PRODUCTO 1 ===");
        Console.WriteLine("Código: " + producto1.codigo);
        Console.WriteLine("Nombre: " + producto1.nombre);
        Console.WriteLine("Precio: " + producto1.precio);
        Console.WriteLine("Stock: " + producto1.stock);
        Console.WriteLine("Disponible: " + producto1.disponible);
        Console.WriteLine();

        Console.WriteLine("=== PRODUCTO 2 ===");
        Console.WriteLine("Código: " + producto2.codigo);
        Console.WriteLine("Nombre: " + producto2.nombre);
        Console.WriteLine("Precio: " + producto2.precio);
        Console.WriteLine("Stock: " + producto2.stock);
        Console.WriteLine("Disponible: " + producto2.disponible);
        Console.WriteLine();

        
        Console.WriteLine("");
        Console.Write("=== EJERCICIO 4: MASCOTA ===");
        Console.WriteLine("");

        Mascota mascota1 = new Mascota();
        mascota1.nombre = "Max";
        mascota1.especie = "Perro";
        mascota1.edad = 3;
        mascota1.peso = 12.5;
        mascota1.vacunado = true;

        Console.WriteLine("=== MASCOTA ===");
        Console.WriteLine("Nombre: " + mascota1.nombre);
        Console.WriteLine("Especie: " + mascota1.especie);
        Console.WriteLine("Edad: " + mascota1.edad);
        Console.WriteLine("Peso: " + mascota1.peso);
        Console.WriteLine("Vacunado: " + mascota1.vacunado);
    }
}