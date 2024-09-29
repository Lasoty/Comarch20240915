using ComarchBootcamp1.App.Cars;

namespace ComarchBootcamp1.App;

public class Program
{
    public static void Main(string[] args)
    {
        ConsoleKeyInfo yesNo;
        do
        {
            ShowMenu();
            Console.Write("Wybierz opcję: ");
            bool czyOk = int.TryParse(Console.ReadLine(), out int choise);
            if (czyOk)
            {
                if (choise == 0) Environment.Exit(0);

                Console.Clear();
                int x, y;

                Calculator calc = new Calculator();
                float result = 0;

                switch (choise)
                {
                    case 1:
                        GetXY(out x, out y);
                        result = calc.Add(x, y);
                        Console.WriteLine($"Wynik dodawania {x} oraz {y} to {result:0}");
                        break;
                    case 2:
                        GetXY(out x, out y);
                        result = calc.Subtract(x, y);
                        Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {result:0}");
                        break;
                    case 3:
                        GetXY(out x, out y);
                        result = calc.Multiply(x, y);
                        Console.WriteLine($"Wynik mnożenia {x} oraz {y} to {result:0}");
                        break;
                    case 4:
                        try
                        {
                            GetXY(out x, out y);
                            result = calc.Dividy(x, y);
                            Console.WriteLine($"Wynik dzielenia {x} oraz {y} to {result:f}");
                        }
                        catch (Exception ex)
                        {
                            ShowError(ex.Message);
                        }
                        finally
                        {
                            //
                        }
                        break;
                    case 5:
                        GetXY(out x, out y);
                        result = calc.Modulo(x, y);
                        Console.WriteLine($"Reszta z dzielenia {x} oraz {y} to {result:f}");
                        break;
                    case 6:
                        CarManager cm = new CarManager();
                        cm.Start();
                        break;
                    case 7:
                        Console.WriteLine("Wprowadź wartość do zapisania do pliku:");
                        string content = Console.ReadLine();
                        File.WriteAllText("file.txt", content);
                        Console.WriteLine("Zapisano.");
                        break;
                    case 8:
                        Console.WriteLine("Zawartość pliku file.txt");
                        string text = File.ReadAllText("file.txt");
                        Console.WriteLine(text);
                        break;
                    default:
                        ShowError("Wprowadzona wartość jest poza zakresem.");
                        break;
                }
            }
            else
            {
                ShowError("Wprowadzona wartość jest nieprawidłowa.");
            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("Czy chcesz wykonać kolejną operację? [T|n]");
            yesNo = Console.ReadKey();

        } while (yesNo.Key != ConsoleKey.N);

    }

    private static void GetXY(out int x, out int y)
    {
        Console.Write("Podaj X: ");
        x = int.Parse(Console.ReadLine()!);
        Console.Write("Podaj Y: ");
        y = int.Parse(Console.ReadLine()!);
    }

    private static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("KALCULATOR 1.0)");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        Console.WriteLine("5. Reszta z dzielenia");
        Console.WriteLine("6. Car manager");
        Console.WriteLine("7. Zapis do pliku");
        Console.WriteLine("8. Odczyt z pliku");
        Console.WriteLine("0. Wyjście z programu");
    }

    internal static void ShowError(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msg);
        Console.ResetColor();
    }
}
