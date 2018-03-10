using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace task3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CodeReuse(new CultureInfo("ru-Ru"), new CultureInfo ("en-US"));
      }
        static public void CodeReuse(CultureInfo cultures,CultureInfo cultures2)
            
        {
            double variable = 10.97;
            DateTime date = new DateTime();
            Console.WriteLine(cultures.DisplayName+"Название языков");
            Console.WriteLine(cultures2.DisplayName + "Название языков");
            Console.WriteLine(variable.ToString( cultures.NumberFormat.CurrencySymbol) );
            Console.WriteLine(variable.ToString( cultures2.NumberFormat.CurrencySymbol));
            Console.WriteLine(cultures.DisplayName + "  "+cultures.NumberFormat.CurrencyDecimalSeparator);
            Console.WriteLine(cultures2.DisplayName+ "  " + cultures2.NumberFormat.CurrencyDecimalSeparator);
            Console.WriteLine((cultures.DisplayName + "  " + cultures.NumberFormat.CurrencyGroupSeparator));
            Console.WriteLine(cultures2.DisplayName + "  " + (cultures2.NumberFormat.CurrencyGroupSeparator));
            Console.ReadKey();
        
        }
    }
}
