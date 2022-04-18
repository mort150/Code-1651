using System;

namespace DemoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BiometricAttendanceSystem system = new BiometricAttendanceSystem();
            while(true)
            {
                system.TakeAttendance();
            }
        }
    }
}
