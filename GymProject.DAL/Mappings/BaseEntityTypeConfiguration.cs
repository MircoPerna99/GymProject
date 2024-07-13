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
    public class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.CreatedByUser)
                   .WithMany()
                   .HasForeignKey(x => x.CreatedBy)
                   .HasPrincipalKey(x => x.Id);

            builder.HasOne(x => x.UpdatedByUser)
                   .WithMany()
                   .HasForeignKey(x => x.UpdatedBy)
                   .HasPrincipalKey(x => x.Id);
        }
    }
}
