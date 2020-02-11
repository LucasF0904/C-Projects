CREATE DATABASE bd_curso;
USE bd_curso;

CREATE TABLE tbl_conteudo(
cod_cont INT(11) UNSIGNED AUTO_INCREMENT NOT NULL,
descricao_cont VARCHAR(60) NOT NULL,
cargahoraria_cont INT(11) UNSIGNED NOT NULL,
PRIMARY KEY (cod_cont));

CREATE TABLE tbl_curso(
cod_curso INT(11) UNSIGNED AUTO_INCREMENT NOT NULL,
cod_conteudo INT(11) UNSIGNED  NOT NULL,
dataInicio_curso DATE NOT NULL,
duracao_curso DOUBLE NOT NULL,
valor_curso DECIMAL NOT NULL,
PRIMARY KEY(cod_curso),
FOREIGN KEY (cod_conteudo) REFERENCES tbl_conteudo(cod_cont));