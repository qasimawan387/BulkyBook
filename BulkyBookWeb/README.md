# docker imgae for MS SQL Sever 
sudo docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -p 1433:1433 -d -v sqlvolume:/var/opt/mssql --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
# for stop docker
sudo docker stop mssql
# add extention SQL Server (mssql)
# for update database
dotnet ef database update
# for add migrations
dotnet ef migrations add MyDemoMigration
# DROP DATABASE
-- Drop the database 'DatabaseName'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Uncomment the ALTER DATABASE statement below to set the database to SINGLE_USER mode if the drop database command fails because the database is in use.
-- ALTER DATABASE DatabaseName SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- Drop the database if it exists
IF EXISTS (
  SELECT name
   FROM sys.databases
   WHERE name = N'BulkyBook'
)
DROP DATABASE BulkyBook
GO
# for add migrations while you have multiple projects under same solution
dotnet ef migrations add AddCategoryToDbAndSeedTable \
  --startup-project BulkyBookWeb \
  --project BulkyBook.DataAccess
# for update database 
dotnet ef database update \
  --startup-project BulkyBookWeb \
  --project BulkyBook.DataAccess
# add area 
dotnet-aspnet-codegenerator area AreaNameToGenerate
# add package
dotnet add package Microsoft.AspNetCore.Mvc.ViewFeatures
# for up-to-date packages 
dotnet restore
