
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using SPA.Utility.Templates.Models;

public class ProfileService : IProfileService
{
    protected UserManager<ApplicationUser> mUserManager;

    public ProfileService(UserManager<ApplicationUser> userManager)
    {
        mUserManager = userManager;
    }

    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    {
        ApplicationUser user = await mUserManager.GetUserAsync(context.Subject);

        IList<string> roles = await mUserManager.GetRolesAsync(user);

        IList<Claim> roleClaims = new List<Claim>();
        foreach (string role in roles)
        {
            roleClaims.Add(new Claim(JwtClaimTypes.Role, role));
        }
        context.IssuedClaims.Add(new Claim(JwtClaimTypes.Name, user.UserName));
        context.IssuedClaims.AddRange(roleClaims);
        //Add more claims as you need
    }

    public Task IsActiveAsync(IsActiveContext context)
    {
        return Task.CompletedTask;
    }
}