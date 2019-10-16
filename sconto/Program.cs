using System;

namespace sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto = 0;
            Console.Write("Inserisci l' importo della spesa: ");
            double importo = double.Parse(Console.ReadLine());
            if (importo < 500)
            {
                sconto = (importo / 100) * 10;
                importo = importo - sconto;
            }
            else if (importo >= 500)
            {
                sconto = (importo / 100) * 20;
                importo = importo - sconto;
            }
            Console.Write($"L'importo scontato è {importo:c} e lo sconto è {sconto:c}");
            Console.ReadLine();
        }
    }
}
