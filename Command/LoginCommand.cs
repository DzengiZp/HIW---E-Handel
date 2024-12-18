class LoginCommand : Command
{
    public LoginCommand()
        : base(2, "Login", "Description: Login with username and password") { }

    public override void Execute()
    {
        Console.Clear();
        Console.WriteLine("Login Menu\n");

        Console.WriteLine("Email");
        string email = Console.ReadLine()!;

        Console.WriteLine("Password");
        string password = Console.ReadLine()!;

        // Verifierar correct information

        // Hoppa till nästa meny utan switch

        ProductMenu prodMenu = new();

        prodMenu.Display();
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }
}
