using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что перевести:");
            Console.WriteLine("1) Метры");
            Console.WriteLine("2) Мили");
            Console.WriteLine("3)Футы");
            int value;
            do
            {
                value = Int32.Parse(Console.ReadKey(true).KeyChar.ToString());
            }
            while (!(value == (1) || value == (2) || value == (3)));
            Console.WriteLine("Во что перевести:");
            Console.WriteLine("1) Метры");
            Console.WriteLine("2) Мили");
            Console.WriteLine("3)Футы");
            int value1;
            do
            {
                value1 = Int32.Parse(Console.ReadKey(true).KeyChar.ToString());
            }

            while (!(value1 == (1) || value1 == (2) || value1 == (3)));
            Console.WriteLine("Значение:");
             double x = Double.Parse(Console.ReadLine());
            Converter c = new Converter();
            if (value == 1)//meters
            {
                if (value1 == 1)//to meters
                    Console.WriteLine("Результат: {0}", x);
                else if (value1 == 2)//to Miles
                    Console.WriteLine("Результат: {0}", c.MetrToMile(x));
                else if (value1 == 3)//to Ft
                    Console.WriteLine("Результат: {0}", c.MileToFt(x));
            }
            else if (value ==2)// miles
            {
                if (value1 == 1)//to meters
                    Console.WriteLine("Результат: {0}", c.MileToMetr(x));
                else if (value1 == 2)//to Miles
                    Console.WriteLine("Результат: {0}", x);
                else if (value1 == 3)//to Ft
                    Console.WriteLine("Результат: {0}", c.MileToFt(x));
            }
            else if (value == 3)// ft
            {
                if (value1 == 1)//to meters
                    Console.WriteLine("Результат: {0}", c.FtToMetr(x));
                else if (value1 == 2)//to Miles
                    Console.WriteLine("Результат: {0}", c.FtToMile(x));
                else if (value1 == 3)//to Ft
                    Console.WriteLine("Результат: {0}", x);

            }
            Console.Read();


        }
    }
}
