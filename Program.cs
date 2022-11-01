using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boot2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //boot kopiujący zawartość stron internetowych do pliku txt

            Console.WriteLine("Podaj adres strony internetowej");
            string adres = Console.ReadLine();
            Console.WriteLine("Podaj nazwę pliku");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj rozszerzenie pliku");
            string rozszerzenie = Console.ReadLine();
            string nazwaPliku = nazwa + "." + rozszerzenie;
            string sciezka = "D:\\" + nazwaPliku;
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.DownloadFile(adres, sciezka);
            Console.WriteLine("Plik został zapisany na pulpicie");
            Console.ReadKey();
            
        }
    }
}
