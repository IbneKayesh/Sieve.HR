HR Management
Development Start Date: 09-01-2023
Development End Date: 29-01-2023


Add Migration =>  add-migration 'migrationName'
Update Database =>  update-database
Add Migration Seed Only => add-migration SeedOnly

Scaffold-DbContext "Server=172.17.107.209; Database=SieveHR; User Id=sa; Password=123; Trusted_Connection=False; MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

1. Company Profile
------------------------------
1.1 Company<br/>
1.2 Department<br/>
1.3 Section<br/>

2. Employee Profile
------------------------------
2.1 Employee Information<br/>
2.2 Duty Roster and Weekend Setup<br/>


3. Duty Profile
------------------------------
3.1 Duty Roster