namespace My_Project.DTO;

public class CreateCustomerDto
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Address { get; set; } = "";
    public IFormFile? ProfilePicture { get; set; }
}