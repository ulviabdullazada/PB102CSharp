namespace PB102Exception.Exceptions
{
    internal class UsernameInvalidException : BaseException
    {
        public UsernameInvalidException() : base("Username yanlish daxil olunub") { }
        public UsernameInvalidException(string? message) : base(message) { }
    }
}
