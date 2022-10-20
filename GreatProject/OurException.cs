using System;

namespace GreatProject;

internal class ZeroLenghtException : Exception
{
    public ZeroLenghtException(string message, Item temp) : base(message)
    {
        Value = temp;
    }

    public Item Value { get; }
}

internal class CapacityException : Exception
{
    public CapacityException(string message, Materials value) : base(message)
    {
    }
}

internal class ExpirationDateException : Exception
{
    public ExpirationDateException(string message, Food temp) : base(message)
    {
        TempForException = temp;
    }

    public ExpirationDateException(string message, Exception innerException) : base(message)
    {
    }

    public Food TempForException
    {
        get;

    }
}

internal class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }

    public AgeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}