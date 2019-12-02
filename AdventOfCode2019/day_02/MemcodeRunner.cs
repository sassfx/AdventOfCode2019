namespace AdventOfCode2019.day_02
{
    public class MemcodeRunner
    {
        public int[] RunCode(int[] code)
        {
            var currentIndex = 0;

            while (currentIndex < code.Length)
            {
                var opCode = code[currentIndex];

                if (opCode == 99)
                {
                    break;
                }

                var firstArgument = code[code[currentIndex + 1]];
                var secondArgument = code[code[currentIndex + 2]];
                var targetIndex = code[currentIndex + 3];

                int result;
                if (opCode == 1)
                {
                    result = firstArgument + secondArgument;
                }
                else if (opCode == 2)
                {
                    result = firstArgument * secondArgument;
                }
                else
                {
                    throw new System.Exception();
                }

                code[targetIndex] = result;
                currentIndex += 4;
            }

            return code;
        }
    }
}
