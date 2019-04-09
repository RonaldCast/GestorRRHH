-- creata departaments
create table departaments(
id int identity primary key,
code_departament nvarchar(15),
name nvarchar(50),
id_employee int

);
alter table departaments 
add constraint FK_dep_employee foreign key (id_employee) references employees(id)

-- create jobtitles (check)
create table JobTitles(
 id int identity primary key,
 code_jobTitle nvarchar(15),
 JobTitle nvarchar(25)
);


-- create paysheets (check)
create table paysheets (
id int identity primary key,
year_pay nvarchar(10),
month_pay nvarchar(15),
amount_pay decimal
);

-- create employees (check)
create table employees (
id int identity primary key,
code_employee nvarchar(25),
name nvarchar(25),
last_Name nvarchar(25),
phone nvarchar(20),
date_entry date,
salary decimal,
Status_employee nvarchar(25),
Id_departament int,
id_job_title int, 
constraint CK_Status_employee check(Status_employee in ('Activo','Inactivo')),
constraint FK_departament_employee foreign key (Id_departament) references departaments(id),
constraint FK_job_title_employee foreign key (id_job_title) references JobTitles(id),
 
);

alter table employees
add constraint FK_job_title_employee foreign key (id_job_title) references JobTitles(id)
on delete set Null

alter table employees 
add constraint FK_departament_employee foreign key (Id_departament) references departaments(id)
on delete set null

select * from employees

alter table employees 
add constraint CK_Status_employee check(Status_employee in ('Activos','Inactivo')),

-- create table permission
create table permission(
id int identity primary key,
date_since_hour datetime,
date_until_hour datetime,
commentary nvarchar(100),
id_employee int, 
constraint FK_permission_employee foreign key (id_employee) references employees(id),

);

-- create table vacation 
create table vacations(
id int identity primary key,
date_since date,
date_until date,
commentary nvarchar(100),
year_vacation nvarchar(10),
id_employee int,
constraint FK_vacation_employee foreign key (id_employee) references employees(id),
 
);
drop table vacation

-- create table licenses 

create table  licenses(
id int identity primary key,
date_since date,
date_until date,
reason nvarchar(100),
commentary nvarchar(100),
id_employee int,
constraint FK_licenses_employee foreign key (id_employee) references employees(id),
);


-- create table employees_exists 
create table employees_exists(
id int identity primary key,
type_exist nvarchar(25),
reason nvarchar(100),
id_employee int,
constraint CK_type_exist check ( type_exist IN ('Renuncia', 'Despido', 'Desahucio')),
constraint FK_employees_exists_employee foreign key (id_employee) references employees(id),
);
Alter table employees_exists
add  date_exist date
-- create table user; 
create table users(
id int identity primary key,
name_user nvarchar(25),
password_user nvarchar(100),
id_employee int, 
constraint FK_users_employee foreign key (id_employee) references employees(id),

);

alter table users
add constraint UQ_user_Name unique(name_user);






