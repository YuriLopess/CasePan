using System.Text.RegularExpressions;
using System.Xml.Linq;
using CasePan.Exceptions;

namespace CasePan.Validators
{
    public class UserValidator
    {
        // Validates password according to security requirements
        public void validatorPassword(string password)
        {
            if (password.Length < 8)
            {
                throw new UserValidationException("Password must be at least 8 characters long.");
            }

            if (!password.Any(char.IsUpper))
            {
                throw new UserValidationException("Password must contain at least one uppercase letter.");
            }

            if (!password.Any(char.IsLower))
            {
                throw new UserValidationException("Password must contain at least one lowercase letter.");
            }

            if (!password.Any(char.IsDigit))
            {
                throw new UserValidationException("Password must contain at least one digit.");
            }

            if (!password.Any(c => "!@#$%^&*()".Contains(c)))
            {
                throw new UserValidationException("Password must include at least one special character.");
            }
        }

        // Validates name to ensure it meets character and length constraints
        public void validatorName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 8 || name.Length > 50)
            {
                throw new UserValidationException("Name must be between 8 and 50 characters long and cannot be empty.");
            }

            if (!Regex.IsMatch(name, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$"))
            {
                throw new UserValidationException("Name can only contain letters and spaces.");
            }
        }

        // Validates email format and length
        public void validatorEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new UserValidationException("Invalid email format.");
            }

            if (email.Length > 320)
            {
                throw new UserValidationException("Email must not exceed 320 characters.");
            }
        }
    }
}