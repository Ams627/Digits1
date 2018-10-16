using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits1
{
    internal class Program
    {
        static int GetDigits(int x)
        {
            if (x > 9)
            {
                return GetDigits(x / 10);
            }
            Console.WriteLine($"{x}");
            return 0;
        }

        private static void Main(string[] args)
        {
            try
            {
                GetDigits(12345);
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
