using System;
namespace DemoComposite
{
    public class File : LinuxFile
    {
        public string Content { get; set; }

        public File()
        {
            Content = "";
        }

        public File(int id, string name, string content) : base(id, name)
        {
            Content = content;
        }

        public override void ShowInfo(int level)
        {
            for (int i = 0; i < level; i++) Console.Write("\t");
            Console.WriteLine("-rw-rw-rw- " + ID + " " + Name);
        }
    }
}
