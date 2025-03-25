namespace CasePan.Exceptions
{
    // Custom exception for user validation errors
    public class UserValidationException : Exception
    {
        public UserValidationException(string message) : base(message) { }
    }
}