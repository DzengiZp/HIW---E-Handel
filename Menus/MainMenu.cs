public class MainMenu : Menu
{
    public MainMenu()
    {
        AddCommand(new RegisterCommand());
        AddCommand(new LoginCommand());
        AddCommand(new ExitCommand());
        AddCommand(new RegisterAdminCommand());
    }

    public override void Title()
    {
        Console.WriteLine("Main Menu:\n");
    }
}
