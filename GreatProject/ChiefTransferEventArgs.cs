using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatProject
{
    class ChiefTransferEventArgs : EventArgs
    {

        public Chief GiveChief { get;}

        public ChiefTransferEventArgs(Chief some_other)
        {
                 GiveChief = some_other;
        }

        public override string ToString()
        {
            return $"Був викликаний івент, для об'єкту{nameof(this.GiveChief)}\nІм'я{this.GiveChief.Name_of_person}";
        }

    }

    class TransferChief
    {
        public event EventHandler<ChiefTransferEventArgs> example_event;

        void OnMethodExample( ChiefTransferEventArgs e)
        {
            example_event?.Invoke(this, e);
        }

        public void SimulateTransfer (Chief example)
        {
            var e = new ChiefTransferEventArgs(example);
            OnMethodExample(e);
        }
    }
}
