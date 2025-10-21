Create DataBase Proyecto_IS

use Proyecto_IS

Create table Hospital(
id_Hospital int primary key not null,
Direccion varchar(100) not null,
horario time,
Consultorios int not null,
num_Hospital int not null,
CP_Hospital int not null,
nom_Hospital varchar(50))

Create table Medico(
id_Medico int primary key not null,
Cedula_Medico int not null,
Especialidad_Medica varchar(50),
Edad_Medico int not null,
num_Consultorio varchar(3),
nom_Medico varchar(30),
apellido_Medico varchar(30),
id_Hospital int not null, 
constraint fk_id_Hospital foreign key (id_Hospital) references Hospital(id_Hospital))

Create table Farmaceutico(
id_Farmaceutico int primary key not null,
nom_Farmaceutico varchar(30),
Apellido_Farmaceutico varchar(30),
cedula_Farmaceutico int,
edad_Farmaceutico int not null,
id_Hospital int not null,
CONSTRAINT fk_id_Hospital_Farmaceutico foreign key (id_Hospital) REFERENCES Hospital(id_Hospital))

Create table Paciente(
id_Paciente int primary key not null,
nom_Paciente varchar (30),
apellido_Paciente varchar(30),
id_Medico int not null,
CONSTRAINT fk_id_Medico foreign key (id_Medico) REFERENCES Medico(id_Medico),
id_Hospital int not null,
CONSTRAINT fk_Hospital_Paciente foreign key (id_Hospital) REFERENCES Hospital(id_Hospital),
num_SeguroS int not null)


Create table Medicamento(
id_Medicamento int primary key not null,
nom_Medicamento varchar(30) not null,
contenido_Medicamento varchar(50),
dosis_Medicamento varchar(50),
disponibilidad_Medicamento int,
prox_Entrega datetime)

Create table Receta(
id_Receta int primary key not null,
id_Paciente int,
CONSTRAINT fk_id_Paciente_Receta foreign key (id_Paciente) REFERENCES Paciente(id_Paciente),
id_Medico int,
CONSTRAINT fk_id_Medico_Receta foreign key (id_Medico) REFERENCES Medico(id_Medico),
fecha_Receta datetime,
id_Medicamento int
CONSTRAINT fk_id_Medicamento_Recta foreign key (id_Medicamento) REFERENCES Medicamento(id_Medicamento))

Create table Cita(
id_Cita int primary key not null,
horario_Cita time not null,
fecha_Cita date not null,
num_Consultorio int not null,
id_Hospital int,
CONSTRAINT fk_id_Hospital_Cita foreign key (id_Hospital) REFERENCES Hospital(id_Hospital),
id_Paciente int,
CONSTRAINT fk_id_Paciente_Cita foreign key (id_Paciente) REFERENCES Paciente(id_Paciente),
id_Medico int,
CONSTRAINT fk_id_Medico_Cita foreign key (id_Medico) REFERENCES Medico(id_Medico))

Create table LogMedicos(
usuario varchar(30),
contraseña varchar(30),
id_Medico int,
CONSTRAINT fk_LogMedicos_id foreign key(id_Medico) REFERENCES Medico(id_Medico)
)

Select * from Medico
Select * from Hospital
Select * from Paciente
Select * from LogMedicos

Insert into Hospital values (1,'Av. Zapata','10:00', 11, 3,22111,'Hospital Quezada')
Insert into Medico values (1,1231,'Pediatria',30,10,'Mario','Mendez',1)
Insert into Paciente values(1,'Mereocrio', 'Menendez',1,1,12123123)
Insert into LogMedicos values('Admin','123',1)
delete from Paciente where id_Paciente like 1

drop database Proyecto_IS