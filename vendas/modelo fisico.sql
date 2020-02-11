drop DATABASE venda;
CREATE DATABASE venda;
USE venda;

create table tbl_vendedor (
matricula int unsigned auto_increment not null,
nome varchar (45) not null,
sexo char(2) not null,
telefone char (11) not null,
datanasc date not null,
logradouro varchar(15) not null,
bairro varchar(15)not null,
cep char(8) not null,
cidade varchar(10) not null,
complemento char(5) null,
numero int not null,
comissao decimal not null,
primary key (matricula)
);

create table tbl_produtos (
cb varchar(255)  not null,
nomeprod varchar(255) not null,
valorvenda decimal not null,
qtdprod decimal not null,
qtdminprod decimal not null,
datavalidade date not null,
lote varchar (255) not null,
prazogarantia varchar(255) not null,
primary key (cb)
);

create table tbl_venda (
cod_venda int unsigned auto_increment not null,
status_venda varchar(255) not null,
total_venda decimal not null,
data_venda date not null,
endereço varchar(20) null,
tbl_vendedor_matricula int unsigned not null,
primary key (cod_venda),
foreign key (tbl_vendedor_matricula) references tbl_vendedor(matricula) 
);

create table tbl_itens (
id_itens int unsigned auto_increment not null,
valor_item decimal not null,
qnteitem decimal not null,
tbl_produtos_cb varchar(255)  not null,
tbl_venda_cod_venda int unsigned not null,
primary key (id_itens),
FOREIGN KEY(tbl_produtos_cb) REFERENCES tbl_produtos(cb),
FOREIGN KEY(tbl_venda_cod_venda)REFERENCES tbl_venda(cod_venda) 
);

