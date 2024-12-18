public class ProductMenu : Menu
{
    public ProductMenu()
    {
        // AddCommand(new Cart());
    }

    public override void Display()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Prod1");
            Console.WriteLine("Prod2");
            Console.WriteLine("Prod3");
            Console.WriteLine("Prod4");

            Console.Write("Choice: ");
            Console.ReadKey();
        }
    }
}
