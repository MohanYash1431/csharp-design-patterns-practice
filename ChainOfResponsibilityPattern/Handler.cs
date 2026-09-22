using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        private Handler? nextHandler;

        public Handler SetNextHandler(Handler handler)
        {
            nextHandler = handler;

            return handler;
        }

        public abstract bool IsAllowed(Request request);

        public abstract void processRequest(Request request);

        protected void PassToNext(Request request)
        {
            if (nextHandler is not null)
            {
                nextHandler.processRequest(request);
            }
            else
            {
                Console.WriteLine($"No Handler could handle the request.{request.priority}");
            }
        }   
    }
}
