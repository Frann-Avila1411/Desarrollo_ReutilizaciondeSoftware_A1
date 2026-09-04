using System;

public class Empleado
{
    private string nombre = string.Empty;
    private int edad;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value ?? string.Empty; }
    }

    public int Edad
    {
        get { return edad; }
        set
        {
            if (value > 0 && value < 100)
            {
                edad = value;
            }
            else
            {
                Console.WriteLine("Error: La edad debe ser mayor que 0 y menor que 100.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado();

        Console.Write("Ingrese el nombre del empleado: ");
        empleado.Nombre = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese la edad del empleado: ");
        if (int.TryParse(Console.ReadLine(), out int edadIngresada))
        {
            empleado.Edad = edadIngresada;
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }

        Console.WriteLine($"\nDatos registrados -> Nombre: {empleado.Nombre}, Edad: {empleado.Edad}");
    }
}