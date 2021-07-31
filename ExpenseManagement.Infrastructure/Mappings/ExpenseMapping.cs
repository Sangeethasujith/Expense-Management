using ExpenseManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseManagement.Infrastructure.Mappings
{
    public class ExpenseMapping : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasColumnType("varchar(150");
            builder.Property(b => b.Amount).IsRequired();
            builder.Property(b => b.ExpenseDate).IsRequired();
            builder.Property(b => b.CategoryId).IsRequired();

            builder.ToTable("Expenses");
        }
    }
}
