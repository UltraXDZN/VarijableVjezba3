using System;

namespace VarijableVjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] brojevi = { 0, 0, 0, 0 }; //deklaracija varijable koja sluzi kao a, b, c, d

            brojevi = unos(brojevi); //unos
            double x = izracunaj_izraz(brojevi); //izracun izraza
            Console.WriteLine($"Izracunati izraz unesenih brojeva jest {x}."); //ispis rijesenja
            Console.ReadKey();
        }

        static double[] unos(double[] unos_brojeva)
        {
            for (int broj = 0; broj <= 3; broj++)
            {
                Console.Write($"Unesite {broj + 1}. broj: ");
                unos_brojeva[broj] = double.Parse(Console.ReadLine());
            }
            return unos_brojeva;
        }

        static double izracunaj_izraz(double[] unos_brojeva)
        {
            return (Math.Pow(unos_brojeva[0], 2) + Math.Pow(unos_brojeva[1], 2) + Math.Pow(unos_brojeva[2], 2) + Math.Pow(unos_brojeva[3], 2)) /
                (Math.Pow(unos_brojeva[0] + unos_brojeva[1], 2) + Math.Pow(unos_brojeva[2] + unos_brojeva[3], 2));
        }
    }
}
