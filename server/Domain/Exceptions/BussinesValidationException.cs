namespace Domain.Exceptions;

public class BussinesValidationException : Exception
{
    public BussinesValidationException(string message) : base(message)
    {
    }
}
