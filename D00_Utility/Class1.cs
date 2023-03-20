using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public static class Utility
    {
        // preparar a consola para receber caracteres especiais
        public static void SetUnicodeConsole()
        {
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
            Console.OutputEncoding = Encoding.UTF8;
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
        }

        public static void WriteTitle(string title)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"\t{title.ToUpper()}");
            Console.WriteLine(new string('-', 50));
        }

        public static void TerminateConsole()
        {
            Console.WriteLine("\n\nPrime qualquer tecla para saíres.");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool ValidateNumber0(double number)
        {
            return number == 0;
            //return number == 0 ? true : false;
        }

        public static bool NumberDifferent0(double number)
        {
            return number != 0;       
        }

        public static bool ValidateNumberDouble(string read)
        {
            return double.TryParse(read, out double number) && NumberDifferent0(double.Parse(read));
        }


    }
}
