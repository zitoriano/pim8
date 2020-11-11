CREATE DATABASE `pim8`;

use `pim8`;

CREATE TABLE `Pessoa` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `nome` varchar(256),
  `cpf` bigint,
  `enderecoId` int
);

CREATE TABLE `Endereco` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `logradouro` varchar(256),
  `numero` int,
  `cep` int,
  `bairro` varchar(50),
  `cidade` varchar(30),
  `estado` varchar(20)
);

CREATE TABLE `Pessoa_Telefone` (
  `pessoaId` int,
  `telefoneId` int,
  PRIMARY KEY (`pessoaId`, `telefoneId`)
);

CREATE TABLE `Telefone` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `numero` int,
  `ddd` int,
  `tipoId` int
);

CREATE TABLE `Telefone_Tipo` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `tipo` varchar(30)
);

INSERT INTO `Telefone_Tipo` (`tipo`) VALUES ('Fixo Residencial');
INSERT INTO `Telefone_Tipo` (`tipo`) VALUES ('Celular');

ALTER TABLE `Pessoa` ADD FOREIGN KEY (`enderecoId`) REFERENCES `Endereco` (`id`);
ALTER TABLE `Pessoa_Telefone` ADD FOREIGN KEY (`pessoaId`) REFERENCES `Pessoa` (`id`);
ALTER TABLE `Pessoa_Telefone` ADD FOREIGN KEY (`telefoneId`) REFERENCES `Telefone` (`id`);
ALTER TABLE `Telefone` ADD FOREIGN KEY (`tipoId`) REFERENCES `Telefone_Tipo` (`id`);