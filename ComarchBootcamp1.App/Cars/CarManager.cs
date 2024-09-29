using ComarchBootcamp1.App.Cars.Model;
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
