using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;

    }
}
