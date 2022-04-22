using System;
using System.Collections.Generic;

namespace DemoComposite
{
    public class Folder : LinuxFile
    {
        private List<LinuxFile> children;

        public List<LinuxFile> Children
        {
            get { return children; }
        }

        public Folder()
        {
            children = new List<LinuxFile>();
        }

        public Folder(int id, string name) : base(id, name)
        {
            children = new List<LinuxFile>();
        }

        public void Add(LinuxFile f)
        {
            children.Add(f);
        }

        public void Remove(LinuxFile f)
        {
            children.Remove(f);
        }

        public LinuxFile Get(int id)
        {
            foreach(LinuxFile f in children)
            {
                if (f.ID == id) return f;
            }

            foreach(LinuxFile f in children)
            {
                if (f is Folder)
                {
                    LinuxFile found = ((Folder)f).Get(id);
                    if (found != null) return found;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            LinuxFile delFile = Get(id);
            if (delFile == null)
            {
                Console.WriteLine("File not found! Cannot delete");
            }
            else
            {
                if (delFile is File)
                {
                    children.Remove(delFile);
                }
                else // delFile is a folder
                {
                    ((Folder)delFile).children.Clear();
                    children.Remove(delFile);
                }
            }
        }

        public override void ShowInfo(int level)
        {
            for (int i = 0; i < level; i++) Console.Write("\t");
            Console.WriteLine("drwxrw-rw- " + ID + " " + Name);

            foreach (LinuxFile f in children)
            {
                f.ShowInfo(level + 1);
            }
        }

        //internal void Delete(int id)
        //{
           //throw new NotImplementedException();
        //}
    }
}
