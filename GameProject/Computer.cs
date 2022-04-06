namespace GameProject
{
    public class Computer : Player
    {
        private int lastNumber;
        private int lastGuess;
        public int LastGuess
        {
            set
            {
                lastGuess = value;
            }
        }
        private int lower;
        private int upper;
        public const int LESS_THAN = 1;
        public const int GREATER_THAN = 2;

        public Computer()
        {
            lastNumber = 0;
            lastGuess = LESS_THAN;
            lower = 1;
            upper = 10;
            Name = "Computer";
        }
        public Computer(string name) : base(name)
        {
            lastNumber = 0;
            lastGuess = LESS_THAN;
            lower = 1;
            upper = 10;
            // Name = name;
        }

        public override int GuessNumber()
        {
            if (lastGuess == LESS_THAN)
            {
                lower = lastNumber + 1;
            }
            else //GREATER_THAN
            {
                upper = lastNumber - 1;
            }
            lastNumber = (lower + upper) / 2;
            return lastNumber;
        }
    }
}