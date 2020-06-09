using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite_FileTree
{
    class Directory : FileSystemItem
    {
        public List<FileSystemItem> items { get; } = new List<FileSystemItem>();

        public Directory(string name) : base(name)
        {

        }
        public override decimal GetSizeinKB()
        {
            try
            {
                return this.items.Sum(x => x.GetSizeinKB());
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public void Add(FileSystemItem newItem)
        {
            this.items.Add(newItem);
        }
        public void Remove(FileSystemItem deleteItem)
        {
            this.items.Remove(deleteItem);
        }
    }
}
