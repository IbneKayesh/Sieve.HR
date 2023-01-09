using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;

namespace Sieve.HR.Services.Db
{
    public partial class HRDbContext : DbContext
    {
        public HRDbContext()
        {

        }
        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HR_ATTENDANCE_SHEET>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HR_DEPARTMENT>(entity =>
            {
                entity.HasOne(d => d.HR_COMPANY)
                    .WithMany(p => p.HR_DEPARTMENT_NAV)
                    .HasForeignKey(d => d.COMP_ID);
            });

            modelBuilder.Entity<HR_SECTIONS>(entity =>
            {
                entity.HasOne(d => d.HR_DEPARTMENT)
                    .WithMany(p => p.HR_SECTIONS_NAV)
                    .HasForeignKey(d => d.DEPT_ID);
            });

            modelBuilder.Entity<HR_EMP_ROSTER>(entity =>
            {
                entity.HasOne(d => d.EMP)
                    .WithOne(p => p.HR_EMP_ROSTER_EMP)
                    .HasForeignKey<HR_EMP_ROSTER>(d => d.EMP_ID)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_HR_EMP_ROSTER_HR_EMP_DETAIL");

                entity.HasOne(d => d.HEAD)
                    .WithMany(p => p.HR_EMP_ROSTER_HEAD)
                    .HasForeignKey(d => d.HEAD_ID)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_HR_EMP_ROSTER_HR_EMP_HEAD");

                entity.HasOne(d => d.ROSTER)
                    .WithMany(p => p.HR_EMP_ROSTERS)
                    .HasForeignKey(d => d.ROSTER_ID)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_HR_EMP_ROSTER_HR_DUTY_ROSTER");

                entity.HasOne(d => d.SUPERVISOR)
                    .WithMany(p => p.HR_EMP_ROSTER_SUPERVISOR)
                    .HasForeignKey(d => d.SUPERVISOR_ID)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_HR_EMP_ROSTER_HR_EMP_SUPERVISOR");
            });

            modelBuilder.Entity<HR_HOLIDAY_CALENDER>()
                .HasKey(p => new { p.YEAR_ID, p.MONTH_ID, p.DAY_ID });

            new DbInitializer(modelBuilder).Seed();
        }


        public virtual DbSet<HR_ATTENDANCE_SHEET> HR_ATTENDANCE_SHEET { get; set; }

        //public virtual DbSet<HR_ATTENDANCE_STATUS> HR_ATTENDANCE_STATUS { get; set; }
        public virtual DbSet<HR_COMPANY> HR_COMPANY { get; set; }
        public virtual DbSet<HR_DEPARTMENT> HR_DEPARTMENT { get; set; }
        public virtual DbSet<HR_DESIGNATIONS> HR_DESIGNATIONS { get; set; }
        public virtual DbSet<HR_DUTY_ROSTER> HR_DUTY_ROSTER { get; set; }
        public virtual DbSet<HR_EDU_TYPE> HR_EDU_TYPE { get; set; }
        public virtual DbSet<HR_EMP_DETAIL> HR_EMP_DETAIL { get; set; }
        public virtual DbSet<HR_EMP_ROSTER> HR_EMP_ROSTER { get; set; }
        public virtual DbSet<HR_EMP_SALARY> HR_EMP_SALARY { get; set; }
        public virtual DbSet<HR_HOLIDAY_CALENDER> HR_HOLIDAY_CALENDER { get; set; }
        public virtual DbSet<HR_LEAVE_TYPE> HR_LEAVE_TYPE { get; set; }
        public virtual DbSet<HR_SALARY_TYPE> HR_SALARY_TYPE { get; set; }
        public virtual DbSet<HR_SECTIONS> HR_SECTIONS { get; set; }

    }
}
