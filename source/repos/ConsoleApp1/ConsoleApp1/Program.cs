using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            IControl ctrl = new SampleClass();
            ISurface srfc = new SampleClass();

            sc.Paint();
            ctrl.Paint();
            srfc.Paint();
            Console.ReadKey();
        }
        interface IControl
        {
            void Paint();
        }
        interface ISurface
        {
            void Paint();
        }
        class SampleClass : IControl, ISurface
        {
            public void Paint()
            {
                Console.WriteLine("Paint method in SampleClass");

            }
            void IControl.Paint()
            {
                Console.WriteLine("Paint method in IControl");
                
            }

            void ISurface.Paint()
            {
                Console.WriteLine("Paint method in ISurface");
             
            }
        }
    }
}
