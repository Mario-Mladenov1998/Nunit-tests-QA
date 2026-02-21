using System.Linq;

namespace TestApp;

public class EmailValidator
{
    public bool IsValid(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        email = email.Trim();

        if (email.Length < 5)
            return false;

        int atIndex = email.IndexOf('@');

        if (atIndex <= 0)
            return false;

        if (atIndex != email.LastIndexOf('@'))
            return false;

        string local = email.Substring(0, atIndex);
        string domain = email[(atIndex + 1)..];

        if (string.IsNullOrWhiteSpace(local) || string.IsNullOrWhiteSpace(domain))
            return false;

        if (!domain.Contains('.'))
            return false;

        if (domain.StartsWith('.') || domain.EndsWith('.'))
            return false;

        string tld = domain.Split('.').Last();
        if (tld.Length < 2)
            return false;

        if (email.Contains(' '))
            return false;

        return true;
    }
}