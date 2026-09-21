using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IATMMachineState
    {
        void InsertCard();

        void WithdrawCash();

        void RemoveCard();

        void PressCancel();

    }
}
