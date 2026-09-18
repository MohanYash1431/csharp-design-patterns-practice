using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Folder : FileSystemNode
    {
        private List<FileSystemNode> _children;
        public Folder(string name) : base(name, 0)
        {
            _children = new List<FileSystemNode>();
        }

        public void AddChild(FileSystemNode child)
        {
            _children.Add(child);
        }

        public override int GetSize()
        {
            int totalSize = 0;
            foreach (var child in _children)
            {
                totalSize += child.GetSize();
            }
            return totalSize;
        }
    }
}
