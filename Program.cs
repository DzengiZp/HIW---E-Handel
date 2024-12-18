namespace Grupparbete;

class Program : Menu
{
    static void Main(string[] args)
    {
        while (true)
        {
            MainMenu mainMenu = new();

            mainMenu.Display();
            _ = int.TryParse(Console.ReadLine(), out int input);

            mainMenu.ExecuteCommand(input);
        }
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
