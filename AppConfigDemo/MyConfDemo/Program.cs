using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            string site = ConfigurationManager.AppSettings["site-url"];

            Console.WriteLine($"our company web site {site}");

            Console.WriteLine("======================= Menu : ");
            Console.WriteLine(ConfigurationManager.AppSettings["option1"]);
            Console.WriteLine(ConfigurationManager.AppSettings["option2"]);
            Console.WriteLine(ConfigurationManager.AppSettings["option3"]);

            int maxAge = Convert.ToInt32(ConfigurationManager.AppSettings["maxAge"]);

            int age = -1;
            do
            {
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
            }
            while (age <= 0 || age > maxAge);

        }
    }
}
