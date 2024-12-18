public class MainMenu : Menu
{
    public MainMenu()
    {
        AddCommand(new RegisterCommand());
        AddCommand(new LoginCommand());
        AddCommand(new ExitCommand());
    }

    public override void Display()
    {
        Console.Clear();

        Console.WriteLine("Main Menu:\n");

        Console.WriteLine("\t1. Register");
        Console.WriteLine("\t2. Login");
        Console.WriteLine("\t3. Exit");

        Console.Write("Choice: ");
    }
}
