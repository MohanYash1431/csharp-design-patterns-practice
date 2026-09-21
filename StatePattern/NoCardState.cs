using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoCardState : IATMMachineState
    {
        private readonly ATMMachine _atmMachine;

        public NoCardState(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }
        public void InsertCard()
        {
            Console.WriteLine("Card inserted successfully.");

            _atmMachine.SetState(_atmMachine.GetCardInsertedState());    
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Please insert your card first.");
        }

        public void RemoveCard()
        {
            Console.WriteLine("No card to remove.");
        }

        public void PressCancel()
        {
            Console.WriteLine("No operation to cancel.");
        }       
    }
}
