using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class FileSystemNode
    {
        protected string Name;
        protected int Size;

        public FileSystemNode(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public abstract int GetSize();

    }
}
