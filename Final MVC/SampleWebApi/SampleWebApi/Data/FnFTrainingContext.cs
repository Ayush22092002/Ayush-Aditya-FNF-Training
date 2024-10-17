using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleWebApi.Data;

public partial class FnFTrainingContext : DbContext
{
    public FnFTrainingContext()
    {
    }

    public FnFTrainingContext(DbContextOptions<FnFTrainingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookTable> BookTables { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAudit> CustomerAudits { get; set; }

    public virtual DbSet<DeptTable> DeptTables { get; set; }

    public virtual DbSet<EmpTable> EmpTables { get; set; }

    public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }

    public virtual DbSet<MovieTable> MovieTables { get; set; }

    public virtual DbSet<StockTable> StockTables { get; set; }

    public virtual DbSet<StudentTable> StudentTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=FNFIDVPRE20531; Database=FnF Training; Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookTable>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("BookTable");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Cstid).HasName("PK__customer__A99D588438398D84");

            entity.ToTable("customer", tb => tb.HasTrigger("onUpdateCustomer"));

            entity.Property(e => e.Cstid).HasColumnName("cstid");
            entity.Property(e => e.Billamount)
                .HasColumnType("money")
                .HasColumnName("billamount");
            entity.Property(e => e.Billdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("billdate");
            entity.Property(e => e.Cstaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cstaddress");
            entity.Property(e => e.Cstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cstname");
        });

        modelBuilder.Entity<CustomerAudit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F57321EBD");

            entity.ToTable("customer_Audit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        modelBuilder.Entity<DeptTable>(entity =>
        {
            entity.HasKey(e => e.DepId).HasName("PK__DeptTabl__00D7A2B35BFCFE20");

            entity.ToTable("DeptTable");

            entity.Property(e => e.DepId).HasColumnName("depId");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .HasColumnName("deptName");
        });

        modelBuilder.Entity<EmpTable>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__EmpTable__AFB3EC0DDE9CE8F0");

            entity.ToTable("EmpTable");

            entity.Property(e => e.EmpId).HasColumnName("empId");
            entity.Property(e => e.DepId).HasColumnName("depId");
            entity.Property(e => e.EmpAddress)
                .HasMaxLength(200)
                .HasColumnName("empAddress");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary)
                .HasColumnType("money")
                .HasColumnName("empSalary");

            entity.HasOne(d => d.Dep).WithMany(p => p.EmpTables)
                .HasForeignKey(d => d.DepId)
                .HasConstraintName("FK__EmpTable__depId__49C3F6B7");
        });

        modelBuilder.Entity<EmployeeTable>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EmployeeTable");
        });

        modelBuilder.Entity<MovieTable>(entity =>
        {
            entity.HasKey(e => e.MovieId);

            entity.ToTable("MovieTable");
        });

        modelBuilder.Entity<StockTable>(entity =>
        {
            entity.HasKey(e => e.StockId).HasName("PK__StockTab__2C83A9C275388862");

            entity.ToTable("StockTable");

            entity.Property(e => e.StockDescription).IsUnicode(false);
            entity.Property(e => e.StockName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentTable>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("StudentTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
