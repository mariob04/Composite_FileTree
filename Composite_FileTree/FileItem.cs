using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_FileTree
{
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
}
