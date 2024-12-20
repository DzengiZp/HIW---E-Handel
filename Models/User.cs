public class User
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public string SocialSecurityNumber { get; set; }

    public User(
        string email,
        string passwordHash,
        string firstName,
        string surname,
        string address,
        string city,
        string zipCode,
        string country,
        string socialSecurityNumber
    )
    {
        Email = email;
        PasswordHash = passwordHash;
        FirstName = firstName;
        Surname = surname;
        Address = address;
        City = city;
        ZipCode = zipCode;
        Country = country;
        SocialSecurityNumber = socialSecurityNumber;
    }
}
