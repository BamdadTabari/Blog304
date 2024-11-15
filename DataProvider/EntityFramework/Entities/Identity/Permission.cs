﻿using DataProvider.Certain.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataProvider.EntityFramework.Entities.Identity;

public class Permission : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Value { get; set; }

    #region Navigations

    public ICollection<RolePermission> Roles { get; set; }

    #endregion
}

public class PermissionEntityConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.HasKey(x => x.Id);

        #region Mappings

        builder.Property(b => b.Value)
            .IsRequired();

        builder.Property(b => b.Title)
            .HasMaxLength(Defaults.MaxTitleLength)
            .IsRequired();

        builder.Property(b => b.Name)
            .HasMaxLength(Defaults.MaxTitleLength)
            .IsRequired();

        #endregion
    }
}