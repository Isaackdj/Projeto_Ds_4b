DROP DATABASE IF EXISTS ConsultVetDB;
CREATE DATABASE ConsultVetDB;
USE ConsultVetDB;

CREATE TABLE Clientes(
	id_cliente INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(60) NOT NULL,
    telefone CHAR(11) NOT NULL,
    email VARCHAR(20),
    endereco VARCHAR(60) NOT NULL
);

CREATE TABLE Animais (
	id_animal INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(20) NOT NULL,
    raca VARCHAR(30),
    especie VARCHAR(30) NOT NULL,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
);

CREATE TABLE Veterinarios (
	id_vet INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(60) NOT NULL,
    telefone CHAR(11),
    email VARCHAR(20),
    especialidade VARCHAR(60) NOT NULL
);

CREATE TABLE Consultas (
	id_consulta INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    data_consulta DATE NOT NULL,
    status VARCHAR(15) NOT NULL,
    id_animal INT NOT NULL,
    id_vet INT NOT NULL,
    FOREIGN KEY (id_animal) REFERENCES animais(id_animal),
    FOREIGN KEY (id_vet) REFERENCES veterinarios(id_vet)
);

CREATE TABLE Tratamentos (
	id_trat INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    descricao VARCHAR(200),
    preco DECIMAL(10, 2) NOT NULL,
    id_consulta INT NOT NULL,
	FOREIGN KEY (id_consulta) REFERENCES consultas(id_consulta)
);