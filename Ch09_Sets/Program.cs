﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09_Sets
{
    class Program
    {

        private static void Output(IEnumerable<string> cohort, string description = "")
        {
            WriteLine(description);
            WriteLine(string.Join(", ", cohort.ToArray()));
        }
        static void Main(string[] args)
        {
            var cohort1 = new string[] { "Rachel", "Gareth", "Jonathan", "George" };
            var cohort2 = new string[] { "Jack", "Stephen", "Daniel", "Jack", "Jared" };
            var cohort3 = new string[] { "Declan", "Jack", "Jack", "Jasmine", "Conor" };
            Output(cohort1, "Cohort 1");
            Output(cohort2, "Cohort 2");
            Output(cohort3, "Cohort 3");
            WriteLine();
            Output(cohort2.Distinct(), "cohort2.Distinct removes duplicates");
            Output(cohort2.Union(cohort3), "cohort2.Union(cohort3) combines two sequences and removed dubicates");
            Output(cohort2.Concat(cohort3), "cohort2.Concat(cohort3) combines two sequences but leaves in any dubicates");
            Output(cohort2.Intersect(cohort3), "cohort2.Intersect(cohort3) returns items which are in both sequences");
            Output(cohort2.Except(cohort3), "cohort2.Except(cohort3) removes items from the first sequence that are in the second");
            Output(cohort1.Zip(cohort2,(c1,c2) => $"{c1} matched with {c2}"), "cohort1.Zip(cohort2, (c1, c2) => $\"{c1} matched with {c2}\"): matches items based on position in the sequence");
        }
    }
}
