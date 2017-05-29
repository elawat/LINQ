
using System.Linq;
using static System.Console;

namespace Ch09_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Pamela", "Jimmy", "Toby", "Ala", "Kurt", "Ola", "Ewa", "Tonia" };
            var query = names
                .ProcessSequence()
                .Where(name => name.Length > 3)
                .OrderBy(name => name.Length)
                .ThenBy(name => name);
            foreach (var item in query)
            {
                WriteLine(item);
            }
        }

        static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }
    }
}
