---יצירת טבלת עובדים

create table Employees(code int primary key identity,
id varchar(10) UNIQUE NOT NULL,
full_name varchar(20))

-- יצירת טבלת סיסמאות

create table Passwords(code int primary key identity,
-- (קישור לטבלת העובדים (טבלה חיצונית
employee_code int foreign key references Employees(code),
password_string varchar(12),
password_expiry_date date,
has_access bit)

-- יצירת טבלת זמנים

create table Clock_Time(code int primary key identity,
employee_code int foreign key references Employees(code),
entry_time datetime,
exit_time datetime)

select * from Employees
select * from Passwords
select entry_time, exit_time from Clock_Time


declare @fullName VARCHAR(20)='Shmuel Yaffe', @id VARCHAR(10)='444999222', @code int;
declare @password VARCHAR(12)= '1234', @answer VARCHAR(250);

IF exists (select * from Employees where id= @id)
	begin
		--find the code from the exists employee
		select @code = (select code from Employees where id=@id)
	end
else
	begin
			-- הוספת עובד לטבלה
			INSERT into Employees values ( @id, @fullName);
			select @code=@@IDENTITY;
		end
IF exists (select * from Passwords WHERE employee_code=@code)
	begin
		if exists (select password_string From Passwords
					WHERE employee_code=@code AND password_string=@password
					AND has_access=1 )
				begin
					if exists (select password_string From Passwords
					WHERE employee_code=@code AND password_string=@password
					AND has_access=1 AND  password_expiry_date>=getdate())
						begin
							if  exists (select * from Clock_Time
							where employee_code=@code AND exit_time is null)
								begin
									update Clock_Time set exit_time= GETDATE()
									where employee_code=@code AND exit_time is null
									select @answer = 'Exit time: ' + convert (NVARCHAR, GETDATE(), 121);
								end
							else
								begin
									insert into Clock_Time values (@code, GETDATE(), null);	
									select @answer = 'Entry time: ' + convert (NVARCHAR, GETDATE(), 121);
								end
						end
						else
							begin
								select @answer ='You need to update your password';
							end
				 end
					else
						begin
							select @answer= 'wrong password';
						end
	end
else
	begin
		insert into Passwords values (@code, @password,DATEADD(day, 180, GETDATE()),
		1)
		select @answer = 'You created a worker and password';
	end

select  Employees.*, password_string, Clock_Time.* from Employees  inner join Clock_Time on Employees.code = Clock_Time.employee_code 
inner join Passwords on Passwords.employee_code = Employees.code



declare @id int=123,@oldPass int=123,@newPass=1234,@confirmPass=1234
-- change Password
declare @code int, @answer varchar(250);

IF exists (select * from Employees where id= @id)
	begin
		--find the code from the exists employee
		select @code = (select code from Employees where id=@id)
	end
else
	begin
		select @answer = 'Employee was not found!'
	end
       if exists (select password_string From Passwords
			WHERE employee_code=@code AND password_string=@oldPass
			AND has_access=1)
			begin
				if not exists (select password_string From Passwords
				WHERE employee_code=@code AND password_string=@newPass)
					begin						
						if @confirmPass=@newPass
							begin
								update Passwords set has_access=0 where employee_code=@code AND password_string=@oldPass
								insert into passwords values(@code, @newPass,
										DATEADD(day, 180, GETDATE()), 1)
										select @answer = 'you have updated your password!'
							end
						else
							begin
								select @answer = 'confirm password doesnt match new pasword!'
							end
					end
				else
					begin
						select answer = 'you already used this pasword!'
					end
			end
		else
			begin
				select @answer = 'current password in incorrect!'
			end


 