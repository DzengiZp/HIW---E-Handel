using System.Xml.Serialization;

public class RegisterAdminCommand : Command
{
    public RegisterAdminCommand()
        : base(0, "Admin Register", "Super admin can user this command to register new admins.") { }

    public override void Execute()
    {
        Console.Clear();

        Console.WriteLine("Admin registration menu:\n");

        Console.Write("Enter first name: ");
        string? firstName = Console.ReadLine();

        if (string.IsNullOrEmpty(firstName))
        {
            return;
        }

        firstName = firstName[..1].ToUpper() + firstName[1..].ToLower();

        Console.WriteLine();

        Console.Write("Enter surname: ");
        string? surname = Console.ReadLine();

        if (string.IsNullOrEmpty(surname))
        {
            return;
        }

        surname = surname[..1].ToUpper() + surname[1..].ToLower();

        Console.WriteLine();

        Console.Write("Enter social security: ");
        string? socialSecurity = Console.ReadLine();

        if (string.IsNullOrEmpty(socialSecurity))
        {
            return;
        }

        // 1920-08-08-5555 read/write
        // 90-08-08-5555 read/write
        // 199008085555 write
        // 9008085555 write

        if (
            socialSecurity.Contains('-')
            || socialSecurity.Contains('/')
            || socialSecurity.Contains(' ')
        )
        {
            if (socialSecurity.Length == 15)
            {
                socialSecurity = socialSecurity.Replace('/', '-');
                socialSecurity = socialSecurity.Replace(' ', '-');
            }

            if (socialSecurity.Length == 13)
            {
                socialSecurity = socialSecurity.Replace('/', '-');
                socialSecurity = socialSecurity.Replace(' ', '-');

                // Use DateTime to check if admin is more or less than 24 years old
                // To determine if they are born in a 19xx or 20xx year

                int number = DateTime.Now.Year;
            }

            if (socialSecurity.Length == 12)
            {
                socialSecurity = socialSecurity.Replace('/', '-');
                socialSecurity = socialSecurity.Replace(' ', '-');
            }
        }

        Console.WriteLine();

        Console.Write("Enter password: ");
        string? password = Console.ReadLine();

        if (string.IsNullOrEmpty(password))
        {
            return;
        }

        Console.Write("Verify password: ");
        string? passwordVerification = Console.ReadLine();

        if (string.IsNullOrEmpty(passwordVerification))
        {
            return;
        }

        if (!password.Equals(passwordVerification))
        {
            Console.WriteLine("Password does not match.");
            Console.ReadKey();
            return;
        }

        AdminAccount adminAccount = new AdminAccount
        {
            FirstName = firstName,
            Surname = surname,
            SocialSecurity = socialSecurity,
            Password = password,
        };

        AccountService accountService = new AccountService();

        accountService.RegisterAdmin(adminAccount);

        Console.WriteLine("Admin account successfully registered.");

        return;
    }

    public override void Undo()
    {
        throw new NotImplementedException();
    }
}
