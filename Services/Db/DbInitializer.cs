using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;

namespace Sieve.HR.Services.Db
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<HR_COMPANY>().HasData(
                  new HR_COMPANY() { ID = 1, COMP_NAME = "Sieve Org", COMP_ADDR = "Dhaka, Bangladesh", MAX_EMP_NO = 1000, MAX_SALARY = 100000000 }
            );

            modelBuilder.Entity<HR_DEPARTMENT>().HasData(
                  new HR_DEPARTMENT() { ID = 1, COMP_ID = 1, DEPT_NAME = "Admin", DEPT_ADDR = "First Floor, Mail Branch", HEAD_EMP_ID = 1, MAX_EMP_NO = 10, MAX_SALARY = 1000000 },
                  new HR_DEPARTMENT() { ID = 2, COMP_ID = 1, DEPT_NAME = "Sales", DEPT_ADDR = "Second Floor, Mail Branch", HEAD_EMP_ID = 2, MAX_EMP_NO = 10, MAX_SALARY = 1000000 }
            );
            modelBuilder.Entity<HR_DESIGNATIONS>().HasData(
                  new HR_DESIGNATIONS() { ID = 1, SHORT_FORM = "CEO", FULL_FORM = "Cheif Executive Officer", PARENT_ID = 0, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 2, SHORT_FORM = "ED", FULL_FORM = "Executive Director", PARENT_ID = 1, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 3, SHORT_FORM = "COO", FULL_FORM = "Cheif Operating Director", PARENT_ID = 2, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 4, SHORT_FORM = "GM", FULL_FORM = "General Manager", PARENT_ID = 3, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 5, SHORT_FORM = "DGM", FULL_FORM = "Deputy General Manager", PARENT_ID = 4, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 6, SHORT_FORM = "AGM", FULL_FORM = "Assistant General Manager", PARENT_ID = 5, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 7, SHORT_FORM = "SM", FULL_FORM = "Senior Manager", PARENT_ID = 6, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 8, SHORT_FORM = "M", FULL_FORM = "Manager", PARENT_ID = 7, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 9, SHORT_FORM = "Dym", FULL_FORM = "Deputy Manager", PARENT_ID = 8, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 10, SHORT_FORM = "AM", FULL_FORM = "Assistant Manager", PARENT_ID = 9, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 11, SHORT_FORM = "SAM", FULL_FORM = "Sub Assistant Manager", PARENT_ID = 10, MIN_SALARY = 100000, MAX_SALARY = 9999999 },
                  new HR_DESIGNATIONS() { ID = 12, SHORT_FORM = "TE", FULL_FORM = "Trainee Executive", PARENT_ID = 11, MIN_SALARY = 100000, MAX_SALARY = 9999999 }
             );


            modelBuilder.Entity<HR_DUTY_ROSTER>().HasData(
                  new HR_DUTY_ROSTER() { ID = 1, DUTY_ROSTER_NAME = "General Shift", IN_TIME = "0900", OUT_TIME = "1700", MAX_OT_HOUR = 0 },
                  new HR_DUTY_ROSTER() { ID = 2, DUTY_ROSTER_NAME = "Morning Shift", IN_TIME = "0600", OUT_TIME = "1800", MAX_OT_HOUR = 2 },
                  new HR_DUTY_ROSTER() { ID = 3, DUTY_ROSTER_NAME = "Evening Shift", IN_TIME = "1800", OUT_TIME = "0600", MAX_OT_HOUR = 2 }
            );

            modelBuilder.Entity<HR_EDU_TYPE>().HasData(
                   new HR_EDU_TYPE() { ID = 1, TYPE_NAME = "Institution" },
                   new HR_EDU_TYPE() { ID = 2, TYPE_NAME = "Training" }
            );

            modelBuilder.Entity<HR_LEAVE_TYPE>().HasData(
                  new HR_LEAVE_TYPE() { ID = 1, TYPE_NAME = "Casual", TYPE_QTY = 10 },
                  new HR_LEAVE_TYPE() { ID = 2, TYPE_NAME = "Sick", TYPE_QTY = 14 },
                  new HR_LEAVE_TYPE() { ID = 3, TYPE_NAME = "Earned", TYPE_QTY = 0 }
            );

            modelBuilder.Entity<HR_SALARY_TYPE>().HasData(
                  new HR_SALARY_TYPE() { ID = 1, TYPE_NAME = "Salary", TYPE_EFFECT = 0 },
                  new HR_SALARY_TYPE() { ID = 2, TYPE_NAME = "House Rent", TYPE_EFFECT = 0 },
                  new HR_SALARY_TYPE() { ID = 3, TYPE_NAME = "Medical", TYPE_EFFECT = 0 },
                  new HR_SALARY_TYPE() { ID = 4, TYPE_NAME = "Transport", TYPE_EFFECT = 0 },
                  new HR_SALARY_TYPE() { ID = 5, TYPE_NAME = "Mobile", TYPE_EFFECT = 0 },
                  new HR_SALARY_TYPE() { ID = 6, TYPE_NAME = "Deposit", TYPE_EFFECT = 1 },
                  new HR_SALARY_TYPE() { ID = 7, TYPE_NAME = "Loan", TYPE_EFFECT = 1 }
            );

            modelBuilder.Entity<HR_SECTIONS>().HasData(
                  new HR_SECTIONS() { ID = 1, DEPT_ID = 1, SECT_NAME = "Admin", SECT_ADDR = "First Floor, Mail Branch", HEAD_EMP_ID = 1, MAX_EMP_NO = 10, MAX_SALARY = 1000000 },
                  new HR_SECTIONS() { ID = 2, DEPT_ID = 2, SECT_NAME = "IT Product", SECT_ADDR = "Second Floor, Mail Branch", HEAD_EMP_ID = 2, MAX_EMP_NO = 10, MAX_SALARY = 1000000 }
            );
        }
    }
}
