using System.Text.Json;
using System.IO;
using ComarchBootcamp1.App.Model;

namespace ComarchBootcamp1.App
{
    public class Program
    {
        protected short zmienna2 = 2;
        //Jakiś komentarz

        /*
        Jakiś komentarz
        Jakiś komentarz
        Jakiś komentarz
        Jakiś komentarz
        */

        /// <summary>
        /// Metoda Main <see cref="decimal"/>
        /// </summary>
        /// <remarks>
        /// <example>
        /// <code></code>
        /// </example>
        /// </remarks>
        /// <param name="args">Parametr args</param>
        public static void Main(string[] args)
        {
            //Console.WriteLine("Witaj, jak masz na imię?");
            //string imie = Console.ReadLine();
            //Console.Write("Podaj wiek: ");
            //string sWiek = Console.ReadLine();
            //int wiek = Convert.ToInt32(sWiek);
            //int wiek2 = int.Parse(sWiek);

            //Console.WriteLine("Witaj " + imie + ", masz " + wiek2 + " lat");
            //Console.WriteLine(string.Concat("Witaj ", imie, ", masz ", wiek, " lat"));
            //Console.WriteLine("Witaj {0}, masz {1} lat", imie, wiek2);
            //Console.WriteLine($"Witaj {imie}, masz {wiek} lat");
            //int rok = DateTime.Now.Year - wiek;

            //Console.WriteLine($"Urodziłeś się w {rok} roku");

            Console.WriteLine("Sortowanie bąbęlkowe");
            Console.WriteLine("Podaj elementy tablicy oddzielone przerwą: ");
            string line = Console.ReadLine();
            string[] elements = line.Split([' ', ',', ';'], StringSplitOptions.RemoveEmptyEntries);
            int[] tab = new int[elements.Length];

            // konwersja tablicy stringów na tablicę intów
            for (int i = 0; i < elements.Length; i++)
            {
                tab[i] = int.Parse(elements[i]);
            }

            // sortowanie bąbelkowe
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Posortowana tablica: ");
            foreach (int item in tab)
            {
                Console.Write(item + " ");
            }

        }
    }
}
