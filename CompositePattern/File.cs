using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class File : FileSystemNode
    {
        public File(string name, int size) 
                             : base(name, size)
        {
        }

        public override int GetSize()
        {
            return Size;
        }
    }
}
    