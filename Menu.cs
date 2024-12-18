public abstract class Menu
{
    List<Command> commands = new List<Command>();

    public void AddCommand(Command command)
    {
        commands.Add(command);
    }

    public void ExecuteCommand(string input)
    {
        foreach (Command c in commands)
        {
            if (input.Equals(c.Choice))
            {
                c.Execute();
                return;
            }
        }
    }

    public abstract void Display();
}




/*

    Display menu
    Execute commands

*/
