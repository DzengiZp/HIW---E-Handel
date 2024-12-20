public class AccountService
{
    public void RegisterAdmin(AdminAccount adminDetails)
    {
        AdminAccount adminAccount = new AdminAccount
        {
            Password = adminDetails.Password,
            FirstName = adminDetails.FirstName,
            Surname = adminDetails.Surname,
            SocialSecurity = adminDetails.SocialSecurity,
        };

        using AppContext context = new AppContext();

        context.AdminAccounts.Add(adminAccount);
        int rowsAffected = context.SaveChanges();

        if (rowsAffected.Equals(0))
        {
            throw new Exception("Couldn't register admin account.");
        }
    }
}
