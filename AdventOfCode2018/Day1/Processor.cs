using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day1
{
    static class Processor
    {
        public static void RunPuzzle1()
        {
            var lines = File.ReadAllLines("Day1/input.txt");
            var frequancies = lines.Select(x => int.Parse(x));
            var final = frequancies.Sum(x => x);

            Console.WriteLine($"Day 1 Puzzle 1 - {final}");
        }

        public static void RunPuzzle2()
        {
            var lines = File.ReadAllLines("Day1/input.txt");
            var frequancies = lines.Select(x => int.Parse(x)).ToList();

            List<int> frequancyTracker = new List<int>();
            int final = 0;
            while (true)
            {
                foreach(var f in frequancies)
                {
                    final += f;

                    if (frequancyTracker.Contains(final))
                    {
                        // found twice 
                        Console.WriteLine($"Day 1 Puzzle 2 - {final}");
                        return;
                    }
                    frequancyTracker.Add(final);
                }
            }
        }
    }
}
