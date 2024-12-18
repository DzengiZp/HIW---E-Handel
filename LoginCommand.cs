class LoginCommand : Command
{
    static string email = "";
    static string password = "";

    public LoginCommand()
        : base(1, "Login", "Description: Login with username and password") { }

    public override void Execute()
    {
        Console.WriteLine("Email");
        email = Console.ReadLine()!;

        Console.WriteLine("Password");
        password = Console.ReadLine()!;

        // Verifierar correct information

        // Hoppa till nästa meny utan switch
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }
}
