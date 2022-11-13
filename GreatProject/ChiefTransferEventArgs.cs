using System;

namespace GreatProject;

internal class ChiefTransferEventArgs : EventArgs
{
    public ChiefTransferEventArgs(Chief someOther)
    {
        GiveChief = someOther;
    }

    public Chief GiveChief { get; }

    public override string ToString()
    {
        return $"Був викликаний івент, для об'єкту{nameof(GiveChief)}\nІм'я{GiveChief.NameOfPerson}";
    }
}

internal class TransferChief
{
    public event EventHandler<ChiefTransferEventArgs> ExampleEvent;

    private void OnMethodExample(ChiefTransferEventArgs e)
    {
        ExampleEvent?.Invoke(this, e);
    }

    public void SimulateTransfer(Chief example)
    {
        var e = new ChiefTransferEventArgs(example);
        OnMethodExample(e);
    }
}