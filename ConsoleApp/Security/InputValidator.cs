using System.Text.RegularExpressions;

public static class InputValidator
{
    public static bool IsValidUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
            return false;

        return Regex.IsMatch(username, "^[a-zA-Z0-9_]{3,20}$");
    }

    public static bool IsValidPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            return false;

        if (password.Length < 8)
            return false;

        return true;
    }
}