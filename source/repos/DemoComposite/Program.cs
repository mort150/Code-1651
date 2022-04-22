using System;

namespace DemoComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder root = new Folder(1, "/");
            Folder system = new Folder(2, "system");
            Folder documents = new Folder(3, "documents");

            root.Add(system);
            root.Add(documents);

            File logs = new File(4, "logs.txt", "System log");
            File socket = new File(5, "socket", "");

            system.Add(logs); system.Add(socket);

            Folder assignments = new Folder(6, "Assignments");
            File asm1 = new File(7, "Asm1.docx", "Done");
            File asm2 = new File(8, "Asm2.docx", "Working");

            assignments.Add(asm1); assignments.Add(asm2);

            File test = new File(9, "test.txt", "hello world");

            documents.Add(assignments); documents.Add(test);

            File config = new File(10, "config", "System configuration");
            root.Add(config);

            root.ShowInfo(0);

            Console.Write("Enter file id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            LinuxFile f = root.Get(id);
            if (f == null) Console.WriteLine("File not found!");
            else
            {
                if (f is File)
                {
                    Console.WriteLine("Found file! Here is file content");
                    Console.WriteLine(((File)f).Content);
                }
                else
                {
                    Console.WriteLine("Found folder! Here is folder content");
                    ((Folder)f).ShowInfo(0);
                }

                // delete file with id
                root.Delete(id);

                Console.ReadKey();
            }
        }
    }
}
