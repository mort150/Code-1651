using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public abstract class BiometricMachine
    {
        public abstract void Detect();
    }
    public class FingerPrintMachine : BiometricMachine
    {
        public override void Detect()
        {
            Console.WriteLine("Pls put your index finger on the sensor ... ");
            Console.ReadLine();
            System.Console.WriteLine("Scanning ...");
            Console.ReadLine();
            System.Console.WriteLine("Scanning succesfully ...");
            Console.ReadLine();
            System.Console.WriteLine("Welcome employee ... Have a great day!!!");
        }
    }

    public class FaceMachine : BiometricMachine
    {
        public override void Detect()
        {
            Console.WriteLine("Pls put your face oposite to camera ... ");
            Console.ReadLine();
            System.Console.WriteLine("Scanning ...");
            Console.ReadLine();
            System.Console.WriteLine("Scanning succesfully ...");
            Console.ReadLine();
            System.Console.WriteLine("Welcome employee ... Have a great day!!!");
        }
    }
    public class AttendanceAdapter : BiometricMachine
    {
        // private readonly AttendanceMachine Machine;
        private AttendanceMachine Machine
        {
            get;
            set;
        }
        public AttendanceAdapter(AttendanceMachine machine)
        {
            Machine = machine;
        }
        public override void Detect()
        {
            Machine.Swipe();
        }
    }
}