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

            if (int.TryParse(Console.ReadLine(), out choise))
            {
                switch (choise)
                {
                    default:
                        break;
                }
            }
        } while (choise != 0);
        Console.WriteLine("Koniec programu.");
    }

    private void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("CAR MANAGER 1.0");
        Console.WriteLine("  1. Lista aut");
        Console.WriteLine("  2. Dodaj auto");
        Console.WriteLine("  3. Usuń auto");
        Console.WriteLine("  0. Zakończ");
    }
}
