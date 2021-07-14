using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using MvcUploadFile.Models;
using System;
using System.Diagnostics;

namespace MvcUploadFile.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var employeeEntity = modelBuilder.Entity<Employee>();
            employeeEntity.HasKey(x => x.EmployeeId);
            employeeEntity.Property(x => x.Name).HasColumnType("VARCHAR(200)");
            employeeEntity.Property(x => x.Role).HasColumnType("VARCHAR(100)");
            employeeEntity
                .HasMany(x=>x.EmployeeAttachments)
                .WithOne(x => x.Employee)
                .HasForeignKey(s => s.EmployeeId)
                .HasConstraintName("FK_EmployeeAttachment_EmployeeId");

            var employeeAttachmentEntity = modelBuilder.Entity<EmployeeAttachment>();
            employeeAttachmentEntity.HasKey(x => x.EmployeeAttachmentId);
            employeeAttachmentEntity.Property(x => x.EmployeeId).HasColumnName("EmployeeId");
            employeeAttachmentEntity.Property(x => x.AttachmentName);
            employeeAttachmentEntity.Property(x => x.ContentType);
            employeeAttachmentEntity.Property(x => x.ContentLenght);
            employeeAttachmentEntity.Property(x => x.Bytes);
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmployeeAttachment> EmployeeAttachment { get; set; }


    }
}
