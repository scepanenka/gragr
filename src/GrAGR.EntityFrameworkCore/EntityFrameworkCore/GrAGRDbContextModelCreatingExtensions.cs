using GrAGR.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace GrAGR.EntityFrameworkCore
{
    public static class GrAGRDbContextModelCreatingExtensions
    {
        public static void ConfigureGrAGR(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Organization>(b =>
            {
                b.ToTable(GrAGRConsts.DbTablePrefix + "Organizations", GrAGRConsts.DbSchema);
                b.ConfigureAuditedAggregateRoot();
            });
            
            builder.Entity<Position>(b =>
            {
                b.ToTable(GrAGRConsts.DbTablePrefix + "Positions", GrAGRConsts.DbSchema);
                b.ConfigureAuditedAggregateRoot();
            });
            builder.Entity<ClientOrders>(b =>
            {
                b.ToTable(GrAGRConsts.DbTablePrefix + "ClientOrders", GrAGRConsts.DbSchema); 
                b.ConfigureAuditedAggregateRoot();
            });
            builder.Entity<Client>(b =>
            {
                b.ToTable(GrAGRConsts.DbTablePrefix + "Clients", GrAGRConsts.DbSchema);
                b.ConfigureAuditedAggregateRoot();
            });
            builder.Entity<Employee>(b =>
            {
                b.ToTable(GrAGRConsts.DbTablePrefix + "Employees", GrAGRConsts.DbSchema);
                b.ConfigureAuditedAggregateRoot();
            });
            builder.Entity<Order>(b =>
            {
                b.ToTable(GrAGRConsts.DbTablePrefix + "Organizations", GrAGRConsts.DbSchema);
                b.ConfigureAuditedAggregateRoot();
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}