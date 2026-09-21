using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ATMMachine
    {
        private IATMMachineState _noCardState;
        private IATMMachineState _cardInsertedState;
        private IATMMachineState _currentState;

        public ATMMachine()
        {
            _noCardState = new NoCardState(this);
            _cardInsertedState = new CardInsertedState(this);
            _currentState = _noCardState;
        }

        public void SetState(IATMMachineState state)
        {
            _currentState = state;
        }

        public IATMMachineState GetNoCardState()
        {
            return _noCardState;
        }

        public IATMMachineState GetCardInsertedState()
        {
            return _cardInsertedState;
        }

        public void InsertCard()
        {
            _currentState.InsertCard();
        }

        public void WithdrawCash()
        {
            _currentState.WithdrawCash();
        }

        public void RemoveCard()
        {
            _currentState.RemoveCard();
        }

        public void PressCancel()
        {
            _currentState.PressCancel();
        }
    }
}
