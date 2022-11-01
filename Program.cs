// boot do pobierania adresów mailowych ze stron internetowych

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.onet.pl";
            string html = GetHtml(url);
            List<string> emails = GetEmails(html);
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("koniec");
            Console.ReadLine();
        }

        static string GetHtml(string url)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            string html = reader.ReadToEnd();
            return html;
        }

        static List<string> GetEmails(string html)
        {
            List<string> emails = new List<string>();
            Regex regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            MatchCollection matches = regex.Matches(html);
            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }
            return emails;
        }
    }
}
