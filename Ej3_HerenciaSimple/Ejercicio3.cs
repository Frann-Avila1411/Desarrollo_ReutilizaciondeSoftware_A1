using System;

public class Vehiculo
{
    public void Arrancar()
    {
        Console.WriteLine("El vehículo ha arrancado.");
    }

    public void Detener()
    {
        Console.WriteLine("El vehículo se ha detenido.");
    }
}

public class Coche : Vehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo el coche.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coche miCoche = new Coche();
        
        miCoche.Arrancar();
        miCoche.Conducir();
        miCoche.Detener();
    }
}
