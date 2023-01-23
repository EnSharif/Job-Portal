using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication1.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefaultRolesAndUser();
        }
        public void CreateDefaultRolesAndUser()
        {
            var roleManager= new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager =new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db)); 
            IdentityRole role = new IdentityRole();
            if(!roleManager.RoleExists("Admins"))
            {
                role.Name = "Admins";
                roleManager.Create(role);
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Enji";
                user.Email = "enji_84@hotmail.com";
                var Check = userManager.Create(user, "Enji8484");
                if(Check.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admins");

                }
            }
        }
    }
}
