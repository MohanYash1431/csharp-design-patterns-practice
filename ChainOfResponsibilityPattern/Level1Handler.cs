using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Level1Handler : Handler
    {
        public override bool IsAllowed(Request request)
        {
            return request.priority < 8;
        }

        public override void processRequest(Request request)
        {
            if (IsAllowed(request))
            {
                Console.WriteLine($"Request with priority {request.priority} is handled by Level1Handler.");
            }
            else
            {
                Console.WriteLine($"Request with priority {request.priority} is not handled by Level1Handler. Passing to next handler.");
                PassToNext(request);
            }
        }
    }
}
