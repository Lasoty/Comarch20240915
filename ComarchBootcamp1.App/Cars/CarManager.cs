using ComarchBootcamp1.App.Cars.Model;
using ComarchBootcamp1.App.Cars.Repositories;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchBootcamp1.App.Cars;

internal class CarManager
{
    public void Start()
    {
        int choise;
        do
        {
            ShowMenu();

            Console.Write("Wybierz pozycję: ");
            if (int.TryParse(Console.ReadLine(), out choise))
            {
                switch (choise)
                {
                    case 1:
                        ShowCars();
                        break;
                    case 2:
                        AddNewCar();
                        break;
                    case 3:
                        DeleteCar();
                        break;
                    case 4:
                        BorrowCar();
                        break;
                    default:
                        break;
                }
            }
        } while (choise != 0);
        Console.WriteLine("Koniec programu.");
    }

    private void DeleteCar()
    {
        throw new NotImplementedException();
    }

    private void AddNewCar()
    {
        Console.WriteLine("Tworzenie nowego pojazdu.");
        Console.WriteLine("Wybierz typ auta: ");
        Console.WriteLine(" 1. Car");
        Console.WriteLine(" 2. Bus");
        Console.WriteLine(" 3. Truck");
        int carTypeUser = int.Parse(Console.ReadLine());
        CarTypes carType = (CarTypes)carTypeUser;

        Vehicle? vehicle = null;

        switch (carType)
        {
            case CarTypes.Car:
                vehicle = new Car();
                break;
            case CarTypes.Bus:
                vehicle = new Bus();
                break;
            case CarTypes.Truck:
                vehicle = new Truck();
                break;
            default:
                Console.WriteLine("Nieprawidłowa opcja");
                break;
        }

        if (vehicle == null) return;

        Console.Write("Podaj markę: ");
        vehicle.Maker = Console.ReadLine();

    }

    private void ShowCars()
    {
        var repository = new VehicleRepository();
        var carList = repository.GetAll();

        ConsoleTable
            .From(carList)
            .Write(Format.Default);
    }

    private void BorrowCar()
    {
        Vehicle vehicle = new Car();
        vehicle.Borrow("");

        Car car = new Car();
        car.Borrow("");
    }

    private void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("CAR MANAGER 1.0");
        Console.WriteLine("  1. Lista aut");
        Console.WriteLine("  2. Dodaj auto");
        Console.WriteLine("  3. Usuń auto");
        Console.WriteLine("  4. Wypożycz");
        Console.WriteLine("  0. Zakończ");
    }
}
