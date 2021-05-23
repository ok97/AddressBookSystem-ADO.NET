Create procedure dbo.AddressBookSystemProcedure
	@FirstName	varchar(150),		
	@LastName	varchar(150),	
	@Address	varchar(150),		
	@City	varchar(150),	
	@State	varchar(150),	
	@Zip	varchar(6),
    @PhoneNumber varchar(10),
	@EmailId	varchar(150),	
	@AddressBookType	varchar(150),
	@AddressBookName	varchar(150)
	as begin
	Insert into AddressBookSystem values(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@EmailId,@AddressBookType,@AddressBookName);
	End

	drop procedure AddressBookSystemProcedure;