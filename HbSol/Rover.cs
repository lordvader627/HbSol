using System.Collections.Generic;

namespace HbSol
{
    class Rover
    {
        private Direction direction = new Direction();
        private List<Work> workList = new List<Work>();
        private int queue = 0;


        public void Move(string[] input)
        {
            Work work = new RoverWork(direction);
            work.Do(input);
            workList.Add(work);
            queue++;
        }
    }
}

