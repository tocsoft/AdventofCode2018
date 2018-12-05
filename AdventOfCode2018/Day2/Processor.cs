using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day2
{
    static class Processor
    {
        public static void RunPuzzle1()
        {
            var lines = File.ReadAllLines("Day2/input.txt");
            var wordStats = lines.Select(x=>{
                var counts = x.GroupBy(c=>c).Select(c=>c.Count()).ToList();
                return (two : counts.Contains(2), three : counts.Contains(3) );
            }).ToList();

           var cs =  wordStats.Count(w=>w.two) *            wordStats.Count(w=>w.three) ;

            Console.WriteLine($"Day 2 Puzzle 1 - {cs}");
        }

        public static void RunPuzzle2()
        {
            var lines = File.ReadAllLines("Day2/input.txt");

            var length = lines.First().Length-1;
            for(var i = 0; i<= length; i++){
                var list = lines.GroupBy(x=> (i == 0 ? "" : x.Substring(0, i-1)) + (i == length ? "" : x.Substring(i, length - i + 1)) )
                .Where(g=>g.Count() > 1)
                .ToList();
                if(list.Any()){
                    foreach(var l in list)
                    {
                        Console.WriteLine($"Day 2 Puzzle 2 - {l.Key}");
                    }
                }
            }
        }
    }
}
