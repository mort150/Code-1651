using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class BiometricAttendanceSystem
    {
        public void TakeAttendance()
        {
            System.Console.WriteLine("System time: " + DateTime.Now.ToString());
            System.Console.WriteLine("Pls choose type of attendance machine: ");
            System.Console.WriteLine("1. FingerPrint Machine");
            System.Console.WriteLine("2. Face Machine");
            System.Console.WriteLine("3. Swipe Machine");
            System.Console.WriteLine("4. Exit");
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            BiometricMachine machine = null;
            if (choice == 1) machine = new FingerPrintMachine();
            else if (choice == 2) machine = new FaceMachine();
            else if (choice == 3) machine = new AttendanceAdapter(new AttendanceMachine());
            else if (choice == 4) return;
            else System.Console.WriteLine("Ivalid choice!!!");

            if(machine != null) machine.Detect();
        }
        public void Detect(BiometricMachine machine)
        {
            System.Console.WriteLine("Starting detect ... ");
            machine.Detect();
            System.Console.WriteLine("Detecting completed ... ");
        }
    }
}