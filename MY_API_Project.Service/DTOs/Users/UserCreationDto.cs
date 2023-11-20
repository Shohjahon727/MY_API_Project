﻿namespace MY_API_Project.Service.DTOs.Users;

public class UserCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool IsMale { get; set; }
    public DateTime DateOfBirth { get; set; }
}
