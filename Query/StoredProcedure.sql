------------JobTitle------------------------

-- Insert JobTitle
create proc sp_InsertJobTitle
@codeJob nvarchar(25),
@JobTitle nvarchar(25)
as
insert into JobTitles values(@codeJob, @JobTitle);

-- update JobTitle
create proc sp_UpdateJobTitle
@id int,
@codeJob nvarchar(25),
@JobTitle nvarchar(25)
as
update JobTitles set  code_jobTitle = @codeJob, JobTitle = @JobTitle where id = @id ;


-- Delete JobTitle
create proc sp_DeleteJobTitle
@id int
as
Delete from JobTitles where id = @id ;

drop proc  sp_DeleteJobTitle
--select JobTitle
create proc sp_SelectJobTitle
as
Select * from JobTitles


--Search JobTitle
create proc sp_SearchJobTitle
@Job nvarchar(25)
as
Select * from JobTitles
where JobTitle like concat('%', @Job,'%')

select * from Jobtitles

------------Departament------------------------

-- Insert Departament
create proc sp_InsertDepartament
@codeDepartament nvarchar(15),
@name nvarchar(50),
@id_employee int null
as
insert into departaments values(@codeDepartament, @name, @id_employee);

drop proc sp_InsertDepartament

-- update Departament
create proc sp_UpdateDepartament
@id int,
@codeDepartament nvarchar(15),
@name nvarchar(50),
@id_employee int
as
update  departaments set  code_departament = @codeDepartament , name = @name,  id_employee = @id_employee  where id = @id ;


-- Delete departaments
create proc sp_Deletedepartament
@id int
as
Delete from departaments where id = @id ;

drop proc  sp_DeleteDepartament
--select JobTitle
create proc sp_SelectDepartamentJoin
as
Select d.id,d.code_departament, d.id_employee, d.name, e.code_employee
from Departaments d
left join employees e
on e.id = d.id_employee

drop proc sp_SelectDepartamentJoin

--Search JobTitle
create proc sp_SearchDepartament
@name nvarchar(25)
as
Select * from Departaments
where name like concat('%', @name,'%')


---- search departament for id
create proc sp_SelectDepartamentForId
@id int
as
select * from Departaments where id = @id; 


------------Employees------------------------

-- Insert Employee
create proc sp_InsertEmployee
@name nvarchar(25),
@codeDEmployee nvarchar(15),
@LastName nvarchar(25),
@Phone nvarchar(20),
@DateEntry date,
@Salary decimal,
@StatusEmployee nvarchar(25),
@IdDepartament int null,
@IdJobTitle int null
as
insert into employees 
values(@codeDEmployee, @name, @LastName, @Phone, @DateEntry, @salary, @StatusEmployee, @IdDepartament, @IdJobTitle);

drop proc sp_InsertEmployee

-- update Employee
create proc sp_UpdateEmployee
@id int,
@name nvarchar(25),
@LastName nvarchar(25),
@Phone nvarchar(20),
@DateEntry date,
@Salary decimal,
@IdDepartament int null,
@IdJobTitle int null
as
update  employees set  name = @name , last_Name = @LastName,  phone = @phone, 
salary = @Salary,  Id_departament = @IdDepartament, id_job_title = @IdJobTitle  where id = @id ;


--select Employee
 exec sp_SelectEmployee '', 'Activos', '', '';
create proc sp_SelectEmployee
@Name nvarchar(25),
@Status nvarchar(25),
@Month nvarchar(25), 
@Departament nvarchar(25)
as
begin 
	Select e.id, e.code_employee, e.name, e.last_Name, e.Phone,
	e.date_entry, e.salary, e.Status_employee,
	d.id 'id_departament', d.name 'name_departament', 
	j.id 'id_jobTitle', j.JobTitle
	from Employees e
	left Join Departaments d
	on  e.Id_departament = d.id
	left join JobTitles j
	on e.id_job_title = j.id 
	where e.Status_employee like concat('%', @Status ,'%') --@Status
	and d.name  like concat('%',@Departament ,'%') -- @Departament
	and DATENAME(m, e.date_entry) like concat('%', @Month ,'%') --@Month 
	and e.name like concat('%',@Name,'%') --@Name
	or e.Id_departament is null

end; 

drop proc sp_SelectEmployee
update employees set Status_employee = 'Activos' where Status_employee = 'Activo'

drop proc sp_SelectEmployee

select * from employees

Select * from employees

--Search JobTitle
create proc sp_SearchDepartament
@name nvarchar(25)
as
Select * from Departaments
where name like concat('%', @name,'%')

select * from Departaments

select * from employees

select DATENAME(mm, getdate())


----------------------permission-------------------------

----Insert permission
create proc sp_InsertPermission
@CodeEmployee int,
@DateSince date,
@DateUntil date,
@Comment nvarchar(100)
as
begin 
	insert into permission 
	values(@DateSince, @DateUntil, @Comment, @CodeEmployee)
end;

--- sp_UpdatePermission
create proc sp_UpdatePermission
@id int,
@CodeEmployee int,
@DateSince date,
@DateUntil date,
@Comment nvarchar(100)
as
begin
	update permission set date_since_hour = @DateSince, 
	date_until_hour = @DateUntil, commentary = @Comment, 
	id_employee = @CodeEmployee where id = @id
end

--- sp_SelectPermission
create proc sp_SelectPermission
as
begin
	select p.id, p.id_employee, p.date_since_hour,
	p.date_until_hour, p.commentary, 
	e.code_employee
	from permission p
	join employees e
	on p.id_employee = e.id
end

Drop proc sp_SelectPermission

--- sp_DeletePermission
create proc sp_DeletePermission
@id int
as
begin
	delete from permission where id = @id
end


----------------------License-------------------------

----Insert License
create proc sp_InsertLicense
@CodeEmployee int,
@DateSince date,
@DateUntil date,
@Comment nvarchar(100),
@Reason nvarchar(100)
as
begin 
	insert into licenses 
	values(@DateSince, @DateUntil,@Reason ,@Comment, @CodeEmployee)
end;

--- sp_UpdateLicense
create proc sp_UpdateLicense
@id int,
@CodeEmployee int,
@DateSince date,
@DateUntil date,
@Comment nvarchar(100),
@Reason nvarchar(100)
as
begin
	update licenses set date_since = @DateSince, 
	date_until = @DateUntil, commentary = @Comment, 
	id_employee = @CodeEmployee, reason = @Reason where id = @id
end

--- sp_SelectLicense
create proc sp_SelectLicense
as
begin
	select p.id, p.id_employee, p.date_since,
	p.date_until, p.commentary, p.reason,  
	e.code_employee
	from licenses p
	join employees e
	on p.id_employee = e.id
end

Drop proc sp_SelectPermission

--- sp_DeleteLicense
create proc sp_DeleteLicense
@id int
as
begin
	delete from licenses where id = @id
end




----------------------Vacations-------------------------

----Insert Vacations
create proc sp_InsertVacation
@CodeEmployee int,
@DateSince date,
@DateUntil date,
@Comment nvarchar(100),
@year nvarchar(100)
as
begin 
	insert into vacations 
	values(@DateSince, @DateUntil ,@Comment, @year, @CodeEmployee)
end;

--- sp_UpdateVacation
create proc sp_UpdateVacation
@id int,
@CodeEmployee int,
@DateSince date,
@DateUntil date,
@Comment nvarchar(100),
@Year nvarchar(10)
as
begin
	update vacations set date_since = @DateSince, 
	date_until = @DateUntil, commentary = @Comment, 
	id_employee = @CodeEmployee, year_vacation = @Year where id = @id
end

--- sp_SelectLicense
create proc sp_SelectVacation
as
begin
	select v.id, v.id_employee, v.date_since,
	v.date_until, v.commentary, v.year_vacation,  
	e.code_employee
	from vacations v
	join employees e
	on v.id_employee = e.id
end

---search vacation for year
create proc sp_SearchVacation
@name nvarchar(100)
as
begin
	select v.id, v.id_employee, v.date_since,
	v.date_until, v.commentary, v.year_vacation,  
	e.code_employee
	from vacations v
	join employees e
	on v.id_employee = e.id
	where v.year_vacation like CONCAT('%', @name , '%') 
end

drop proc sp_SearchVacation


----------------------Employee exist-------------------------

----Insert EmployeeExist
create proc sp_InsertEmployeeExist
@CodeEmployee int,
@DateExist date,
@TypeExist nvarchar(25),
@Reason nvarchar(100)
as
begin 
	insert into employees_exists
	values(@TypeExist, @Reason ,@CodeEmployee, @DateExist);
	update employees set Status_employee = 'Inactivo' where id = @CodeEmployee; 
end;

drop proc sp_InsertEmployeeExist

--- sp_UpdateEmployeeExist
create proc sp_UpdateEmployeeExist
@id int,
@CodeEmployee int,
@DateExist date,
@TypeExist nvarchar(25),
@Reason nvarchar(100)
as
begin
	update employees_exists set date_exist = @DateExist,  
	reason = @Reason, id_employee = @CodeEmployee, 
	type_exist = @TypeExist where id = @id
end;

--- sp_SelectEmployeeExist
create proc sp_SelectEmployeeExist
as
begin
	select ex.id, ex.id_employee, ex.date_exist,
	ex.reason, e.code_employee, ex.type_exist
	from  employees_exists ex
	join employees e
	on ex.id_employee = e.id
end
drop proc sp_SelectEmployeeExist

---search employeeExist for year
create proc sp_SearchEmployeeExist
@Month nvarchar(20)
as
begin
	select ex.id, ex.id_employee, ex.date_exist,
	ex.reason, e.code_employee, ex.type_exist
	from  employees_exists ex
	join employees e
	on ex.id_employee = e.id
	where DATENAME(m, ex.date_exist) like CONCAT('%',@Month ,'%')
end

select * from vacations

-------PaySheet

create proc sp_InsertPaySheet
@Year nvarchar(100),
@Month nvarchar(25)
as
begin 
	declare @amount decimal(18,0);
	set @amount = (select sum(salary) from employees where status_employee = 'Activos');
	
	insert into paysheets values(@Year, @Month, @amount); 
end

create proc  sp_SelectPaySheetForMonth
@Month nvarchar(25)
as
begin
select * from paysheets where month_pay  like   concat( '%',@Month,'%')
end
drop proc sp_SelectPaySheetForMonth

select * from permission

-----------------------User----------------------

--insert user
create proc sp_InsertUser
@NameUse nvarchar(25),
@Password nvarchar(100),
@idEmployee int 
as
begin 
	insert into users values(@NameUse, @Password, @idEmployee)
end 

--update user
create proc sp_UpdateUser
@id int,
@NameUse nvarchar(25),
@Password nvarchar(100),
@idEmployee int 
as
begin
	update users set name_user = @NameUse, password_user = @Password,
	id_employee = @idEmployee where id = @id
end

drop proc sp_updateUser
select * from users

--sp_DeleteUser
create proc sp_DeleteUser
@id int 
as
begin
	delete from users where id = @id;  
end

-- select user

create proc sp_SelectUser
as
begin 
	select u.id, u.name_user, u.id_employee , e.code_employee, u.password_user 
	from users u
	join employees e
	on u.id_employee = e.id
end

drop proc sp_SelectUser
--searchUser 
create proc sp_SearchUser
@name nvarchar(25)
as
begin 
	select u.id, u.name_user, u.id_employee , e.code_employee 
	from users u
	join employees e
	on u.id_employee = e.id
	where u.name_user like concat('%',@name,'%')
end







