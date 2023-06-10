Create database farmacia
go
use farmacia
go

create table pacientes(
Id int identity (1,1) primary key,
Nombre nvarchar(30),
Edad int,
Telefono int,
direccion nvarchar(60),

)
go

create table empleados(
Id int identity (1,1) primary key,
Idpasciente int,
Nombre nvarchar(30),
Cargo varchar(30),
Area_trabajo varchar(30),
sexo nvarchar(20),
CONSTRAINT RELACION_A_PACIENTES FOREIGN KEY (Idpasciente) REFERENCES pacientes (Id),

)
go

create table vacunas(
Id int identity (1,1) primary key,
IdEmpleados int,
Nombre nvarchar(30),
Tipo nvarchar(30),
Dosis int,
Fecha_ven varchar(15),
Edad_paciente int,
descripcion nvarchar(60),
Efectos_secun nvarchar(30)

CONSTRAINT RELACION_A_EMPLEADOS FOREIGN KEY (IdEmpleados) REFERENCES  empleados (Id),


)
go

create table registro(
Id int identity (1,1) primary key,
Idvacuna int,
Fecha int,
Tipo nvarchar(30),
Rango int,
Fecha_adm int,
Prox_vacuna int,
Inf_paciente nvarchar(70)

CONSTRAINT RELACION_A_VACUNAS FOREIGN KEY (Idvacuna) REFERENCES  vacunas (Id),
)
go


create table campaña(
Id int identity (1,1) primary key,
Idregistro int,
Fecha int,
Tipo nvarchar(30),
Rango int,
Barrio nvarchar(30),
Personal nvarchar(30)

CONSTRAINT RELACION_A_REGISTRO FOREIGN KEY (Idregistro) REFERENCES registro (Id),

)
go


---ListarPacientes
create proc ListarPacientes
as
select Id AS ID, Nombre,Edad,Telefono,direccion
 from pacientes 

go
update pacientes set Nombre = 'Carlos', Edad = 23, Telefono = 789, direccion = 'hjhjh' where Id = 1
select *from pacientes

insert into pacientes values
('Diego',30,78946354,'valle de los naranjos')
go

----AGREGAR PACIENTE
create proc AgregarPaciente
@nombre nvarchar (100),
@edad int,
@telefono int,
@direccion nvarchar(100)

as
insert into pacientes values (@nombre,@edad,@telefono,@direccion)
go
---listar empleados
create proc ListarEmpleados
as
select Id AS ID, Nombre,Cargo,Area_trabajo,sexo
 from empleados

go

----AGREGAR Empleado
create proc AgregarEmpleado
@nombre nvarchar (100),
@cargo nvarchar(100),
@area nvarchar(100),
@sexo nvarchar(100)

as
insert into empleados values (@nombre,@cargo,@area,@sexo)
go

-----listar vacunas
create proc Listaracunas
as
select Id AS ID,nombre,tipo,dosis,fecha_ven,Edad_paciente,descripcion,efectos_secun 
from vacunas
go

------Agregar vacunas
create proc Agregaracunas
@Nombre nvarchar (30),
@Tipo nvarchar (30),
@Dosis int,
@Fecha_ven varchar (15),
@Edad_paciente int,
@descripcion nvarchar (60),
@Efectos_secun nvarchar (30)

as
insert into vacunas values (@Nombre,@Tipo,@Dosis,@Fecha_ven,@Edad_paciente,@descripcion,@Efectos_secun)
go
