using System;

namespace Composite_FileTree
{
    public abstract class FileSystemItem
    {
        public string Name { get; }  
        public FileSystemItem(string name)  //konstruktor
        {
            this.Name = name;
        }  
        public abstract decimal GetSizeinKB();
    }
    public class FileItem : FileSystemItem
    {
        public int fileBytes { get; }
        public FileItem(string name, int FileBytes) : base(name)
        {
            this.fileBytes = FileBytes;
        }

        public override decimal GetSizeinKB()
        {
            try
            {
                return decimal.Divide(this.fileBytes, 1000);
            }
            catch
            {
                throw new NotImplementedException();
            } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
