using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Level3Handler : Handler
    {
        public override bool IsAllowed(Request request)
        {
            return request.priority < 20;
        }
        public override void processRequest(Request request)
        {
            if (IsAllowed(request))
            {
                Console.WriteLine($"Level 3 Handler processed request with priority {request.priority}");
            }
            else
            {
                Console.WriteLine($"Level 3 passed priority {request.priority} to the next handler.");
                PassToNext(request);
            }
        }
    }
}
