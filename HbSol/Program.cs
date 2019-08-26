using System;

namespace HbSol
{
    public class Program
    {
        public static void Main()
        {
            var input = @"5 5
                        1 2 N
                        LMLMLMLMM
                        3 3 E
                        MMRMMRMRRM".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var grid = new Grid(input);

            Rover rover = new Rover();

            rover.Move(input);
        }

        public static string GetResult()
        {
            var input = @"5 5
                        1 2 N
                        LMLMLMLMM
                        3 3 E
                        MMRMMRMRRM".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Direction obj = new Direction();
            obj.Operation(input);

            return obj.result;
        }
    }
}
