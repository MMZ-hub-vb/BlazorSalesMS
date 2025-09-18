using Microsoft.AspNetCore.Identity;

namespace BlazorSalesMS.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
    }
    public class ApplicationRole : IdentityRole
    {
        // Add custom properties here if needed
    }

}
