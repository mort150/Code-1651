using System;
namespace GameProject
{
    public class Human : Player
    {
        public Human() : base("Human")
        {

        }
        public Human(string name) : base(name)
        {

        }

        public override int GenNumber()
        {
            int a = AskNumber("What numbet do you think: ");
            return a;
        }
        public override int GuessNumber()
        {
            int a = AskNumber("What number do you guess: ");
            return a;
        }
        private int AskNumber(string prompt)
        {
            bool invalidInput = true;
            int a = -1;
            while (invalidInput)
            {
                System.Console.WriteLine(prompt);
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 1 || a > 10) System.Console.WriteLine("The number must be in 1 to 10");
                else invalidInput = false;
            }
            return a;
        }
    }
}