-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 17-Ago-2015 às 18:19
-- Versão do servidor: 5.6.17-log
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bd_farmacia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_laboratorio`
--

CREATE TABLE IF NOT EXISTS `tbl_laboratorio` (
  `cod_laboratorio` int(11) NOT NULL,
  `nome_laboratorio` varchar(45) DEFAULT NULL,
  `cod_tecnico_laboratorio` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_laboratorio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_remedio`
--

CREATE TABLE IF NOT EXISTS `tbl_remedio` (
  `cod_remedio` int(11) NOT NULL,
  `nome_remedio` varchar(45) DEFAULT NULL,
  `descricao_remedio` varchar(45) DEFAULT NULL,
  `principioativo_remedio` varchar(45) DEFAULT NULL,
  `cod_laboratorio` int(11) NOT NULL,
  `quantidade_remedio` int(11) DEFAULT NULL,
  `valor_remedio` double DEFAULT NULL,
  PRIMARY KEY (`cod_remedio`,`cod_laboratorio`),
  KEY `fk_tbl_Remedio_tbl_Laboratorio_idx` (`cod_laboratorio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tbl_remedio`
--
ALTER TABLE `tbl_remedio`
  ADD CONSTRAINT `fk_tbl_Remedio_tbl_Laboratorio` FOREIGN KEY (`cod_laboratorio`) REFERENCES `tbl_laboratorio` (`cod_laboratorio`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
