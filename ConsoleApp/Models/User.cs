public class User
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [EmailAddress]
    public string Email { get; set; }
}