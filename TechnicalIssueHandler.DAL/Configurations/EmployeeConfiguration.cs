using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechnicalIssueHandler.Core.Entities;

namespace TechnicalIssueHandler.DAL.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(26);
        builder.Property(x => x.Surname).HasMaxLength(32);
    }
}