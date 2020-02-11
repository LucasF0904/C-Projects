drop database work1;
create database work1;
use work1;

create table usuario(
id_usuario INT UNSIGNED AUTO_INCREMENT NOT NULL,
nome VARCHAR(30) NOT NULL,
email VARCHAR(50) UNIQUE NOT NULL,
senha VARCHAR(16)NULL,
tipo_usuario INT UNSIGNED NOT NULL,
PRIMARY KEY(id_usuario)
);
create table paciente(
id_paciente INT UNSIGNED AUTO_INCREMENT NOT NULL,
usuario_id INT UNSIGNED NOT NULL,
PRIMARY KEY(id_paciente),
FOREIGN KEY(usuario_id) REFERENCES usuario(id_usuario)
);
create table medico(
crm INT UNSIGNED AUTO_INCREMENT NOT NULL,
usuario_id INT UNSIGNED NOT NULL,
PRIMARY KEY(crm),
FOREIGN KEY(usuario_id) REFERENCES usuario(id_usuario)
);
create table agenda(
id_consulta INT UNSIGNED AUTO_INCREMENT NOT NULL,
medico_crm INT UNSIGNED NOT NULL,
paciente_id INT UNSIGNED NOT NULL,
horario DATETIME NULL,
PRIMARY KEY(id_consulta),
FOREIGN KEY(paciente_id) REFERENCES paciente(id_paciente),
FOREIGN KEY(medico_crm) REFERENCES medico(crm)
);
insert into usuario values(null,'thiago','thiago@mail.com','',1);
insert into usuario values(null,'dias','thiago2@mail.com','',1);
insert into usuario values(null,'thiagoaa','thiago3@mail.com','',1);
insert into usuario values(null,'medico','thiago4@mail.com','',2);
insert into paciente values(1,1);
insert into paciente values(2,2);
insert into paciente values(3,3);
insert into medico values(4,4);
insert into agenda values(null, 4,1, '2014/02/0/08 00:01:00');
