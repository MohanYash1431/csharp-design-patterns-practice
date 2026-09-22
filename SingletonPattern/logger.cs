using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Logger  
    {
        private static Logger? _instance;
        private static readonly object _lock = new object();
        public string filePath { get; }

        private Logger(string filePath)
        {
            this.filePath = filePath;
            Console.WriteLine($"Logger initialized with file path: {filePath}");
        }

        public static Logger GetInstance(string filePath)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger(filePath);
                }
                return _instance;
            }                       
        }
    }
}
                                                                                                                                     