namespace InternshipTaskSolid.Users;

public class User(int id, string name, string email, string phoneNumber, string deviceToken)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public string Email { get; } = email;
    public string PhoneNumber { get; } = phoneNumber;
    public string DeviceToken { get; } = deviceToken;
}