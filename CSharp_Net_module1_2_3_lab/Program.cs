using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money m1 = new Money(1000.76m, EnumCurrencyTypes.UAH);
            Money m2 = new Money(1500.45m, EnumCurrencyTypes.UAH);
            //Money m2 = new Money(1500, EnumCurrencyTypes.EU);

            // 11) do operations
            // add 2 objects of Money
            Console.WriteLine($"m1 + m2={m1 + m2}");

            // add 1st object of Money and double
            m1 = m1 + 105.45m;
            Console.WriteLine($"m1 + 105={m1.Amount}");

            // decrease 2nd object of Money by 1 
            m2 = --m2;
            Console.WriteLine($"m2--={m2.Amount}");

            // increase 1st object of Money
            Console.WriteLine($"m1={m1.Amount}");
            m1 = m1++;
            Console.WriteLine($"m1++={m1.Amount}");

            // compare 2 objects of Money
            if (m1 > m2) { Console.WriteLine("m1>m2"); }
            else
            if (m1 < m2) { Console.WriteLine("m1<m2"); }
            else
            if (m1 == m2) { Console.WriteLine("m1=m2"); } 

            // compare 2nd object of Money and string
            if (m2 > "200,45") { Console.WriteLine("m2 > 200,45"); }

            // check CurrencyType of every object
            if (m1) { Console.WriteLine("m1 is UAH"); }
            if (m2) { Console.WriteLine("m2 is UAH"); }

            // convert 1st object of Money to string
            Console.WriteLine($"m1={(string)m1}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
