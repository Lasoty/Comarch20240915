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
