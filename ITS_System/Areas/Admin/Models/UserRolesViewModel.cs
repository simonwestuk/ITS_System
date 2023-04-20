namespace ITS_System.Areas.Admin.Models
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; } //Change to IdentityUser
        public IEnumerable<string> Roles { get; set; }
    }
}
