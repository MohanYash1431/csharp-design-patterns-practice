using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class CacheProxy : IDocument
    {
        private RealDocument _realDocument;
        private Dictionary<string, string> _cache;

        public CacheProxy(RealDocument realDocument)
        {
            _realDocument = new RealDocument();
            _cache = new Dictionary<string, string>();
            _realDocument = realDocument;
        }

        public string ReadDocument(string docId)
        {
            if (_cache.ContainsKey(docId))
            {
                Console.WriteLine($"CacheProxy: Returning cached document with ID: {docId}");
                return _cache[docId];
            }

            string content = _realDocument.ReadDocument(docId);
            _cache[docId] = content;
            return content;
        }
    }
}
