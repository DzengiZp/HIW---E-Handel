namespace Grupparbete;

class Program : Menu
{
    static void Main(string[] args)
    {
        LoginCommand loginCommand = new LoginCommand();
        loginCommand.Execute();
    }

    public override void Display()
    {
        throw new NotImplementedException();
    }
}

/*

Account
    -Login
    -Register
Product
Cart

*/
