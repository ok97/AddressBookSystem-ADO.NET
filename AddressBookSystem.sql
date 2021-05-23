
----Create table AddressBookSystem
Create table AddressBookSystem(FirstName varchar(50),LastName varchar(50),Address varchar(50),City varchar(50), State varchar(50),Zip varchar(6),PhoneNumber varchar(10),EmailId varchar(50),AddressBookType varchar(50),AddressBookName varchar(50) );
--insert record for table
insert into AddressBookSystem values('Omprakash','Khawshi','Alandi','Pune','Maharashtra','412105','8788616249','Omkhawshi0@gmail.com','Family','Omprakash');
select * from AddressBookSystem;

drop table AddressBookSystem