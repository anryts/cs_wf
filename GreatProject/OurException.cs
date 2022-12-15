using System;

namespace GreatProject;

public class ZeroLenghtException : Exception
{
    public ZeroLenghtException(string message, object temp) : base(message)
    {
        Value = temp;
    }

    public object Value { get; }
}

public class CapacityException : Exception
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