# HRMS (Human Resources Management System)

Payroll and Salary Management Web Application

Note: the repository was started for learning purposes only. Now I've decided not to develop further. Currently I'm working for AP Clients. So after completed that It's may resume further.

## What is the next?

1) MSSQL 2016 Developer to 2022 Express
2) NET 6 to NET 8

* Setup
  * Business
  * Department
  * Sections
* Employee
  * Employee
  * Employee Educations
  * Document List
    * Employee Document
  * Salary Head
  * Payment Cycle
* Payroll
  * Salary Head List
  * Payroll 
  * Daily Attendance
    * Attendace Application
    * Attendance No
  * Pay Slip
  * Pay Slip Detail
  * Payment Cycle
  * Leave Application
  * Duty Roster

Business -
Multiple business can be added, each business hold a maximum number of employees and maximum total salary

Departments -
Department is the child entity of a business. Multiple departments can be added, total salary and no of employees of all the departments not more then parent entity (business) and not less then own child sections

Sections-
Sections are the child entities of a department. Multiple sections can be added, total salary and no of employees of the sections not more then parent entity (department).

Employee -
An employee may have many properties. ID, Employee No, Name, Contact No, Email Address, National ID, DOB, Father Name, Mother Name, Present Address, Permanent Address, Join Date, Total Salary

Emp Educations -
Title Name, Institute Name, Passing Year, Grade, Learning Areas

Employee Document List-
NID, Picture, Passport, Driving License

Emp Salary Head -
Employee, Salary Head

Emp Payment Cycle-
Employee, Payment Cycle No

Salary Head List-
Addition [Basic, House Rent, Health Allownce]
Deduction [Penalty, Lunch Bill]

Daily Attendance -
Id, Attendance No, Emp No, Date, In Time, Out Time, Total Duration, Over Time, Net Duration, Notes, Attendance Application

Attendance Application -
Present, Late present, Weekend, Half leave with pay, Leave with pay, Leave without pay, Sick leave, Earned leave, Absense

Attendance No-
Attendance No, Emp No , Present, Absense, Total Days, Over Time

Pay Slip -
Slip No, Payment Cycle No , Employee, Attendance No, Total Amount, Slip Date

Pay Slip Detail -
Slip No, Salary Head, Amount

Payment Cycle -
Cycle Name, Start Date, End Date

Leave Application -
Id, Emp No, Attendance No, From Date, To Date, Total Days, Approver Id

Duty Roster -
...