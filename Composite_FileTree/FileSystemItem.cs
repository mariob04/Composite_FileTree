using System;
using System.Collections.Generic;
using System.Text;

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
}
