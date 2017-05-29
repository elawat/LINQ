using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace Ch09_PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            Write("Press ENTER to start.");
            ReadLine();
            watch.Start();
            IEnumerable<int> numbers = Enumerable.Range(1, 200000000);
            var squares = numbers.AsParallel().Select(number => number * 2).ToArray();
            watch.Stop();
            WriteLine($"{watch.ElapsedMilliseconds:#,##0} ellapsed milliseconds.");

        }
    }
}
