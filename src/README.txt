
These are the rest API created for  Contact information management system, those can be consumed in any front end application to manage contact information.

To run this application follow below steps

1> Create empty DB with name "ContactInformation" in local SQL server

2> Run script present in folder in sequence mentioned below to create initial DB structure for application

	a>CIMS_Initial_Script.sql
	b>CIMS_Initial_Master_Data_Script.sql

3> Open the solution file "ContactInformationManagement.sln" in VS studio 2017 or above

4> Set this project "ContactInformationManagement.Api" (Asp.net Rest api project) as start up prject

5> Build solution

6> Update the connection string created of DB created in step number 1 and 2 in data access layer project "ContactInfoManagement.DataAccess"
  and rest api start up project "ContactInformationManagement.Api"

7> Run the application and use swagger to test the API's
	for e.g. http://localhost:50437/swagger/ui/index
	
8> Best of luck and contact me for any help need to set this up 
	Mob: 9822244649

DB schema excel is also in this folder