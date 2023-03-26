using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FluentApi.Entities;

public partial class AppointmentDbContext : DbContext
{
    public AppointmentDbContext()
    {
    }

    public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.ToTable("appointment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acceptance).HasColumnName("acceptance");
            entity.Property(e => e.Date)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PhysicianEmail)
                .IsUnicode(false)
                .HasColumnName("physician_email");
            entity.Property(e => e.Reason)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.SubmissionDate)
                .IsUnicode(false)
                .HasColumnName("submission_date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
