using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using OrderPayment.Models;

namespace OrderPayment.Context;

public partial class OrderPaymentDbContext : DbContext
{
    public OrderPaymentDbContext()
    {
    }

    public OrderPaymentDbContext(DbContextOptions<OrderPaymentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MoneyArrival> MoneyArrivals { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MoneyArrival>(entity =>
        {
            entity.HasKey(e => e.IdMoneyArrival);

            entity.ToTable("MoneyArrival");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Sum).HasColumnType("money");
            entity.Property(e => e.SumRemaining).HasColumnType("money");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Sum).HasColumnType("money");
            entity.Property(e => e.SumPaid).HasColumnType("money");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.IdPayment);

            entity.ToTable("Payment", tb => tb.HasTrigger("UpdatingSums"));

            entity.Property(e => e.Sum).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
