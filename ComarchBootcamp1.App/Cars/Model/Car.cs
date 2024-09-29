using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBootcamp1.App.Cars.Model;

internal abstract class Vehicle
{
    public int Id { get; set; }

    public string Maker { get; set; }

    public string Model { get; set; }

    public string GasType { get; set; }

    public int Capacity { get; set; }

    public abstract void Refuel(int count);

    public virtual void Borrow(string Borrower)
    {
        Console.WriteLine("Metoda Borrow w klasie Vehicle");
    }
}

internal class Car : Vehicle, IDisposable
{
    public override void Refuel(int count)
    {
        throw new NotImplementedException();
    }

    public override void Borrow(string Borrower)
    {
        Console.WriteLine("Metoda Borrow w klasie Car");
    }


    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

internal class Bus
{
    public int Id { get; set; }

    public string Maker { get; set; }

    public string Model { get; set; }

    public string GasType { get; set; }

    public int Capacity { get; set; }

    public int SeatsCount { get; set; }

    public virtual void Refuel(int count)
    {
        Capacity += count;
    }
}

internal class Truck : Bus
{
    public int Id { get; set; }

    public string Maker { get; set; }

    public string Model { get; set; }

    public string GasType { get; set; }

    public int Capacity { get; set; }

    public int LoadCapacity { get; set; }

    public override void Refuel(int count)
    {
        Capacity += count;
    }
}
