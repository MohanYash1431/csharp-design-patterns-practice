using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealDocument : IDocument
    {
        public string ReadDocument(string docId)
        {
            Console.WriteLine($"RealDocument: Reading document with ID: {docId}");

            return $"Reading document with ID: {docId}";
        }
    }
}
