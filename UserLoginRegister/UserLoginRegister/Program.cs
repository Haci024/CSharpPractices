using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> users = new Dictionary<string, string>();
    static bool loggedIn = false;
    static string loggedInUser = "";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("3.Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void Login()
    {
        if (loggedIn)
        {
            Console.WriteLine("You are already logged in as " + loggedInUser);
            return;
        }

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        string storedPassword;
       
        
        
        
        if (users.TryGetValue(username, out storedPassword) && storedPassword == password)
        {
            loggedIn = true;
            loggedInUser = username;
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }

    static void Register()
    {
        Console.Write("Username:");
        string username = Console.ReadLine();

        Console.Write("Password:");
        string password = Console.ReadLine();

        Console.Write("ConfirmPassword: ");
        string confirmPassword = Console.ReadLine();

        if (users.ContainsKey(username)) { 
      
            Console.WriteLine("Username already taken!");
        }
        else
        {
            users[username] = password;
            users[username] = confirmPassword;
            if (confirmPassword == password)
            {
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("Password are not the same!");
            }
          
        }
    }
}
