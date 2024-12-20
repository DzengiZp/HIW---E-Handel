namespace Grupparbete;

class Program
{
    static void Main(string[] args)
    {
        Initialize.Database();

        MainMenu mainMenu = new MainMenu();

        mainMenu.Display();

        while (true)
        {
            _ = int.TryParse(Console.ReadLine(), out int input);
            mainMenu.ExecuteCommand(input);
        }
    }
}
