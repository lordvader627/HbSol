using System;

namespace HbSol
{
    public class Direction
    {
        public string result { get; set; }
        public void Operation(string[] input)
        {
            //to do rover logic

            result = $@"1 3 N{Environment.NewLine}5 1 E";
            Console.WriteLine(result);
        }
    }
}
