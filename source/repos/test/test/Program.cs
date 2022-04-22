using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            //AbsSimpleClass absSimpleClass = new AbsSimpleClass(); // Error here

            sc.Paint();
            Console.ReadKey();

            //Output:
            //--> AbsSimpleClass constructor here
            //--> Paint method here
        }
        public abstract class AbsSimpleClass
        {


            public abstract void DoSomething();

            public virtual void Paint()
            {
                Console.WriteLine("Paint method here");
            }

            public AbsSimpleClass()
            {
                Console.WriteLine("AbsSimpleClass constructor here");
            }
        }

        public class SampleClass : AbsSimpleClass
        {
            public override void DoSomething()
            {
                Console.WriteLine("Do something here");
            }
        }
    }
}
