
Use ContactInformation
Go

create schema CI
Go

create table CI.Person
( Id int primary key identity(1000,1),
FirstName varchar(50) not null,
LastName varchar(50) not null
)
Go

create table CI.ContactType
(Id int primary key identity(1,1),
TypeName varchar(20) not null
)
Go

create table CI.PersonContact
(PersonId int not null,
ContactTypeId int not null,
ContactTypeValue nvarchar(50),
constraint PK_PersonContact primary key (PersonId, ContactTypeId),
constraint FK_PersonContact_Person foreign key(PersonId) references CI.Person(Id),
constraint FK_PersonContact_ContactType foreign key(ContactTypeId) references CI.ContactType(Id),
)
Go