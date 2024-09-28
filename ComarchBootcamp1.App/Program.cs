namespace ComarchBootcamp1.App;

public class Program
{
    public static void Main(string[] args)
    {
        ConsoleKeyInfo yesNo;
        do
        {
            Console.Clear();
            Console.WriteLine("KALCULATOR 1.0)");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Reszta z dzielenia");
            Console.WriteLine("0. Wyjście z programu");
            Console.Write("Wybierz opcję: ");

            if (int.TryParse(Console.ReadLine(), out int choise))
            {
                if (choise == 0) Environment.Exit(0);

                Console.Clear();
                Console.Write("Podaj X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Podaj Y: ");
                int y = int.Parse(Console.ReadLine()!);

                Calculator calc = new Calculator();
                float result = 0;

                switch (choise)
                {
                    case 1:
                        result = calc.Add(x, y);
                        Console.WriteLine($"Wynik dodawania {x} oraz {y} to {result:0}");
                        break;
                    case 2:
                        result = calc.Subtract(x, y);
                        Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {result:0}");
                        break;
                    case 3:
                        result = calc.Multiply(x, y);
                        Console.WriteLine($"Wynik mnożenia {x} oraz {y} to {result:0}");
                        break;
                    case 4:
                        result = calc.Dividy(x, y);
                        Console.WriteLine($"Wynik dzielenia {x} oraz {y} to {result:f}");
                        break;
                    case 5:
                        result = calc.Modulo(x, y);
                        Console.WriteLine($"Reszta z dzielenia {x} oraz {y} to {result:f}");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wprowadzona wartość jest poza zakresem.");
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadzona wartość jest nieprawidłowa.");
                Console.ResetColor();
            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("Czy chcesz wykonać kolejną operację? [T|n]");
            yesNo = Console.ReadKey();

        } while (yesNo.Key != ConsoleKey.N);

    }
}
