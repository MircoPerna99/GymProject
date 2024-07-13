using GymProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymProject.DAL.Mappings
{
    public class UserDetailsMap : BaseEntityTypeConfiguration<UserDetails>
    {
        public override void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            base.Configure(builder);
            builder.ToTable("Users_Details");

            builder.HasOne(x => x.UserOwner)
                   .WithOne(y => y.Details)
                   .HasForeignKey<UserDetails>(x => x.UserId)
                   .HasPrincipalKey<User>(y => y.Id)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
