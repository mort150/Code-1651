using System;

namespace GameProject
{
    public class Player
    {
        protected string name;
        protected int number;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid name!!!");
                else name = value;
            }
        }
        public int Number
        {
            get { return number; }
        }

        public Player()
        {
            name = "Player";
            number = 0;
        }
        public Player(string name)
        {
            Name = name;
            number = 0;

        }
        public virtual int GenNumber()
        {
            Random a = new Random();
            return a.Next(1, 10);
        }
        public virtual int GuessNumber()
        {
            Random a = new Random();
            return a.Next(1, 10);
        }

    }
}