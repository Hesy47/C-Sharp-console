class Messenger
{
    public static void EndMessage()
    {
        Console.WriteLine("Message: The End of Program");
    }
}

class Functions
{
    public static string Capitalizer(string value)
    {
        string newValue = value[..2].ToUpper() + value[1..];
        return newValue;
    }
}

class ConsoleApp
{
    private static void Entry()
    {
        Console.WriteLine("Message: Please inter your username:");
        var username = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(username))
        {
            username = Functions.Capitalizer(username);

            if (username == "Amir" || username == "Amin")
            {
                Console.WriteLine($"Message: Welcome Back {username}");
            }
            else
            {
                Console.WriteLine("Message: Access Denied!");
            }
        }
        else
        {
            Console.WriteLine("Message: username must be a string and can not be null!");
        }
    }

    protected static void Main()
    {
        Entry();
        Messenger.EndMessage();
    }
}
