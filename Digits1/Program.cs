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
        static IEnumerable<int> GetDigits(int x)
        {
            int divisor = 1000_000_000;
            while (x < divisor)
            {
                divisor /= 10;
            }

            while (divisor > 0)
            {
                yield return x / divisor;
                x %= divisor;
                divisor /= 10;
            }
        }


        private static void Main(string[] args)
        {
            try
            {
                foreach (var d in GetDigits(12345))
                {
                    Console.WriteLine(d);
                }
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
