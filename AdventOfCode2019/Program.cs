using AdventOfCode2019.day_01;
using AdventOfCode2019.day_02;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new MemcodeRunner();
            using var fileStream = new FileStream("./day_02/data.txt", FileMode.Open);
            using var streamReader = new StreamReader(fileStream);
            string text = streamReader.ReadToEnd();

            const int target = 19690720;
            int result = 0;
            for (var noun = 0; noun <= 99; noun++)
            {
                for (var verb = 0; verb <= 99; verb++)
                {
                    var codes = text.Split(',').Select(int.Parse).ToArray();
                    codes[1] = noun;
                    codes[2] = verb;
                    var finalCodes = calculator.RunCode(codes);
                    if (finalCodes[0] == target)
                    {
                        result = 100 * noun + verb;
                        break;
                    }
                }

                if (result != 0)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
