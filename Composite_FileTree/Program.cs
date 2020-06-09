using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Composite_FileTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add root Dir, folders and files to make up a tree

            var builder = new SystemBuilder("root");
            builder.AddDirectory("Folder1");
            builder.AddFile("knjiga.txt", 18000);
            builder.AddFile("video.mkv", 520000);
            builder.AddDirectory("SubFolder");
            builder.AddFile("Music.mp3", 19000);
            builder.AddFile("Resume.pdf", 9000);
            builder.SetCurrentDirectory("root");
            builder.AddDirectory("Folder2");
            builder.AddFile("winfile.dll", 250000);
            builder.AddFile("WinApp.exe", 87000000);

            Console.WriteLine($"Total size of (root): { builder.Root.GetSizeinKB() } KB");

            Console.WriteLine(JsonConvert.SerializeObject(builder.Root, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
