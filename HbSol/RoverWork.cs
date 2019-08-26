namespace HbSol
{
    class RoverWork : Work
    {
        private Direction direction;

        public RoverWork(Direction direction)
        {
            this.direction = direction;
        }
   
        public override void Do(string[] input)
        {
            direction.Operation(input);
        }
    }
}
