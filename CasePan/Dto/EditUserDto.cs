namespace CasePan.Dto
{
    // Data Transfer Object (DTO) for editing an existing user
    public class EditUserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
