using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CardInsertedState : IATMMachineState
    {
        private readonly ATMMachine _atmMachine;

        public CardInsertedState(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card is already inserted.");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Cash withdrawn successfully.");
            _atmMachine.SetState(_atmMachine.GetNoCardState());
        }

        public void RemoveCard()
        {
            Console.WriteLine("Card removed successfully.");
            _atmMachine.SetState(_atmMachine.GetNoCardState());
        }

        public void PressCancel()
        {
            Console.WriteLine("Operation cancelled.");
            _atmMachine.SetState(_atmMachine.GetNoCardState());

            RemoveCard();
        }
    }
}
