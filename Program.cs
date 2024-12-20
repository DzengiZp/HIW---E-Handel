using System.Reflection.Metadata;

namespace Grupparbete;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();

        mainMenu.Display();

        while (true)
        {
            _ = int.TryParse(Console.ReadLine(), out int input);
            mainMenu.ExecuteCommand(input);
        }
    }
}
