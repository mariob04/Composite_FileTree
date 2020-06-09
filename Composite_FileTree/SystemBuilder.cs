using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite_FileTree
{
    public class SystemBuilder
    {
        internal Directory Root { get; }
        internal Directory CurrentDir { get; set; }

        public SystemBuilder(string rootDirectory)
        {
            this.Root = new Directory(rootDirectory);
            this.CurrentDir = Root;
        }
        internal FileItem AddFile(string name, int size)
        {
            var file = new FileItem(name, size);
            CurrentDir.Add(file);
            return file;
        }
        internal Directory SetCurrentDirectory(string currentDirName)
        {
            var dirStack = new Stack<Directory>();
            dirStack.Push(this.Root);

            while (dirStack.Any())
            {
                //prvi element
                var current_dir = dirStack.Pop();

                if(currentDirName == current_dir.Name)
                {
                    this.CurrentDir = current_dir;
                    return current_dir;
                }
                //iteriranje kroz iteme
                foreach(var item in current_dir.items.OfType<Directory>())
                {
                    dirStack.Push(item);
                }
            }
            throw new InvalidOperationException($"Directory name: '{ currentDirName }'");
        }
        internal Directory AddDirectory(string name)
        {
            var dir = new Directory(name);
            this.CurrentDir.Add(dir);
            this.CurrentDir = dir;
            return dir;
        }
    }
}
