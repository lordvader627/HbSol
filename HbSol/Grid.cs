using System;
using System.Linq;

namespace HbSol
{
    class Grid
    {
        public Grid(string[] input)
        {
            var area = input[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
            Console.WriteLine($"Grid has been created with area size {area[0]}, {area[1]}");
        }
    }
}
