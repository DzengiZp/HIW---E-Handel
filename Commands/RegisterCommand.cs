public class RegisterCommand : Command
{
    public RegisterCommand()
        : base(1, "Register", "Register an account.") { }

    public override void Execute()
    {
        MainMenu mainMenu = new();

        Console.Clear();
        Console.WriteLine("Register Menu\n");

        Console.Write("Email: ");
        string email = Console.ReadLine()!;

        Console.Write("Password: ");
        string password = Console.ReadLine()!;

        mainMenu.Display();
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }
}
