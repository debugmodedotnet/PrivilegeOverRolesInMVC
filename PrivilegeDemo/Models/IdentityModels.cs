using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace PrivelegeDemo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        

       
    }

    //public class ApplicationDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    //{
    //    protected override void Seed(ApplicationDbContext context)
    //    {
    //        //var store = new RoleStore<IdentityRole>(context);
    //        //var manager = new RoleManager<IdentityRole>(store);
    //        //var role = new IdentityRole { Name = "AppAdmin" };
    //        //manager.Create(role);
    //        //var store1 = new UserStore<ApplicationUser>(context);
    //        //var manager1 = new UserManager<ApplicationUser>(store1);
    //        //var user = new ApplicationUser { UserName = "dj@dj.com" };

    //        //manager1.Create(user, "password");
    //        //manager1.AddToRole(user.Id, "AppAdmin");
    //        base.Seed(context);
    //    }

    }
