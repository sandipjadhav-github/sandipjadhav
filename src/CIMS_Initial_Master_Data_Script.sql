
--select * from [CI].[ContactType]
--select * from [CI].[Person]
--select * from [CI].[PersonContact]

insert into [CI].[ContactType]
values(
'Email'
)

insert into [CI].[ContactType]
values(
'PhoneNumber'
)

insert into [CI].[Person]
values(
'Sandip',
'Jadhav'
)

insert into [CI].[Person]
values(
'Bhagyashree',
'Jadhav'
)


insert into [CI].[PersonContact]
values(
1000,
1,
'sandipjadhav.job@gmail.com'
)


insert into [CI].[PersonContact]
values(
1001,
2,
'9822244649'
)