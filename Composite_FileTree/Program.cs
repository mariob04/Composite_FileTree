using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite_FileTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add root Dir, folders and files to make up a tree
            var root = new Directory("Root");
            var folder1 = new Directory("Folder 1");
            var folder2 = new Directory("Folder 2");

            root.Add(folder1);
            root.Add(folder2);

            folder1.Add(new FileItem("Seminar.txt", 12000));
            folder1.Add(new FileItem("Film.mkv", 1200000));

            var subfolder1 = new Directory("Sub Folder 1");
            subfolder1.Add(new FileItem("Music.mp3", 40000));
            subfolder1.Add(new FileItem("Skripta.pdf", 12000));
            folder1.Add(subfolder1);

            folder2.Add(new FileItem("SystemFile.dll", 342099));
            folder2.Add(new FileItem("winfile.dll", 782099));

            Console.WriteLine($"Total size of (root): { root.GetSizeinKB() } KB");
            Console.WriteLine($"Total size of (folder 1): { folder1.GetSizeinKB() }KB");
            Console.WriteLine($"Total size of (folder 2): { folder2.GetSizeinKB() }KB");
        }
    }
}
