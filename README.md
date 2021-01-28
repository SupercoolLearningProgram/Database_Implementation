# Database_Implementation_Using Dapper


Window forms application which already connected to databases


Input LastName that already exist in database will display the infomation ( Name , Lastname , Email , Phone number) in the ListBox to the screen.


Azure Connection String Standard Template: 


		Server=tcp:azure-myserver-database.database.windows.net,1433;Initial Catalog=myDataBase;Persist Security Info=False;User ID=serverid;Password=serverpassword;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

Rename colums name in table : 

EXEC sp_rename 'dbo.People.OldColumnName', 'NewColumnName', 'COLUMN';
