create database sistema;
use sistema;
create table usuario(
id int primary key auto_increment,
nome varchar(60),
email varchar(60),
senha varchar(50)
);