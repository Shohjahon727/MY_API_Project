namespace MY_API_Project.Service.DTOs.Users;

public class UserResultDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool IsMale { get; set; }
    public DateTime DateOfBirth { get; set; }
}