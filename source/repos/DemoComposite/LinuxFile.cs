using System;
namespace DemoComposite
{
    public abstract class LinuxFile
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public LinuxFile()
        {
            ID = 0;
            Name = "New file";
        }

        public LinuxFile(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract void ShowInfo(int level);
        
    }
}
