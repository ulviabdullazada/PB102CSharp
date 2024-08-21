namespace PB102Exception.Exceptions
{
    internal class PasswordInvalidException : BaseException
    {
        public PasswordInvalidException() : base("Password duzgun daxil edilmeyib")
        {
        }

        public PasswordInvalidException(string? message) : base(message)
        {
        }
    }
}
