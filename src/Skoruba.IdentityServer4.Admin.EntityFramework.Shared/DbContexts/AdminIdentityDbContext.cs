using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD:src/Skoruba.IdentityServer4.Admin.EntityFramework.DbContexts/AdminIdentityDbContext.cs
using Skoruba.IdentityServer4.Admin.EntityFramework.Constants;
using Skoruba.IdentityServer4.Admin.EntityFramework.Identity.Entities.Identity;
using TableConsts = Skoruba.IdentityServer4.Admin.EntityFramework.Identity.Constants.TableConsts;
=======
using Skoruba.IdentityServer4.Admin.EntityFramework.Shared.Constants;
using Skoruba.IdentityServer4.Admin.EntityFramework.Shared.Entities.Identity;
>>>>>>> upstream/dev:src/Skoruba.IdentityServer4.Admin.EntityFramework.Shared/DbContexts/AdminIdentityDbContext.cs

namespace Skoruba.IdentityServer4.Admin.EntityFramework.Shared.DbContexts
{
    public class AdminIdentityDbContext : IdentityDbContext<UserIdentity, UserIdentityRole, string, UserIdentityUserClaim, UserIdentityUserRole, UserIdentityUserLogin, UserIdentityRoleClaim, UserIdentityUserToken>
    {
        public AdminIdentityDbContext(DbContextOptions<AdminIdentityDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {        
            builder.HasDefaultSchema(SchemaConsts.AdminIdentity);
            base.OnModelCreating(builder);

            ConfigureIdentityContext(builder);
        }

        private void ConfigureIdentityContext(ModelBuilder builder)
        {
            builder.Entity<UserIdentityRole>().ToTable(TableConsts.IdentityRoles);
            builder.Entity<UserIdentityRoleClaim>().ToTable(TableConsts.IdentityRoleClaims);
            builder.Entity<UserIdentityUserRole>().ToTable(TableConsts.IdentityUserRoles);

            builder.Entity<UserIdentity>().ToTable(TableConsts.IdentityUsers);
            builder.Entity<UserIdentityUserLogin>().ToTable(TableConsts.IdentityUserLogins);
            builder.Entity<UserIdentityUserClaim>().ToTable(TableConsts.IdentityUserClaims);
            builder.Entity<UserIdentityUserToken>().ToTable(TableConsts.IdentityUserTokens);
        }
    }
}