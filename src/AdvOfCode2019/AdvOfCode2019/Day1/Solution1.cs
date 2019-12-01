using System;
using System.IO;

namespace AdvOfCode2019.Day1
{
    public static class Solution1
    {
        public static void Day1() {

            var input = File.ReadAllLines("Day1/input.in");

            decimal fsum = 0;
            decimal ssum = 0;
            foreach (var i in input)
            {
                var mass = decimal.Parse(i);

                var f = CountFuell(mass);
                fsum += f;
                do
                {
                    ssum += f;
                    f = CountFuell(f);
                } while (f >= 0);
            }

            Console.WriteLine("part one: " + fsum);
            Console.WriteLine("part two: " + ssum);
        }

        private static decimal CountFuell(decimal mass) {
            return Math.Floor(mass / 3.0m) - 2;
        }
    }
}
