using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class PasswordValidator
    {
        public bool IsValid(string? password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;
            if (password.Length < 8) return false;

            bool hasUpper =
                password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            return hasUpper && hasDigit;
        }
    }
}
    

