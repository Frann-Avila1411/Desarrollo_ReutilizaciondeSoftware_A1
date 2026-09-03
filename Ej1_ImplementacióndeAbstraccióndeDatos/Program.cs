using System;

public class CuentaBancaria
{
    private decimal saldo;

    public CuentaBancaria()
    {
        saldo = 0m;
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Error: El monto a depositar debe ser mayor a cero.");
            return;
        }
        
        saldo += monto;
        Console.WriteLine($"Depósito exitoso. Se agregaron ${monto}.");
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Error: El monto a retirar debe ser mayor a cero.");
            return;
        }

        if (monto > saldo)
        {
            Console.WriteLine("Error: Fondos insuficientes para el retiro.");
            return;
        }

        saldo -= monto;
        Console.WriteLine($"Retiro exitoso. Se retiraron ${monto}.");
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}