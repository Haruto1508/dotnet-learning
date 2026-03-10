public class AuthController
{
    private AuthService authService = new AuthService();

    public string Login(string username, string password)
    {
        if (!InputValidator.IsValidUsername(username))
        {
            return "Invalid username format";
        }

        if (!InputValidator.IsValidPassword(password))
        {
            return "Invalid password format";
        }

        bool authenticated = authService.Login(username, password);

        if (authenticated)
        {
            return "Login successful";
        }

        return "Invalid credentials";
    }
}