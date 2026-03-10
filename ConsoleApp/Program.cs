using System;

class Program
{
    static void Main()
    {
        AuthController authController = new AuthController();

        Console.WriteLine("SafeVault Login");

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        string result = authController.Login(username, password);

        Console.WriteLine(result);
    }
}