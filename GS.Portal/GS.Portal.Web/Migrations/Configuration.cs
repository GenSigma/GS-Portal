namespace GS.Portal.Web.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GS.Portal.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GS.Portal.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "Admin", "HumanResource", "Employee" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                if (!roleManager.RoleExists(roleName))
                {
                    roleResult = roleManager.Create(new IdentityRole(roleName));
                }
            }

            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //userManager.AddToRole("e952afc5-aa5c-426d-9b4d-a69158c53c79", "Admin");
        }
    }
}
