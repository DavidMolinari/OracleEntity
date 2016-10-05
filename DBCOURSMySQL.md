```mysql


-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Jeu 20 Novembre 2014 à 11:14
-- Version du serveur: 5.6.12-log
-- Version de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `dbcours`
--
DROP DATABASE IF EXISTS `dbcours`;

CREATE DATABASE IF NOT EXISTS `dbcours` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbcours`;

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

DROP TABLE IF EXISTS `cours`;
CREATE TABLE IF NOT EXISTS `cours` (
  `CODECOURS` varchar(6) NOT NULL,
  `LIBELLECOURS` varchar(35) NOT NULL,
  `NBJOURS` int(11) NOT NULL DEFAULT '3',
  PRIMARY KEY (`CODECOURS`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vider la table avant d'insérer `cours`
--

TRUNCATE TABLE `cours`;
--
-- Contenu de la table `cours`
--

INSERT INTO `cours` (`CODECOURS`, `LIBELLECOURS`, `NBJOURS`) VALUES
('BR013', 'Administration BDR', 3),
('BR034', 'UML : Initiation', 2),
('BR035', 'UML : Perfectionnement', 5),
('BR056', 'SQL2 : La norme', 3),
('BR057', 'Conception BD relationnelle', 4),
('BR070', 'Administration d''une BD', 4);

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

DROP TABLE IF EXISTS `employe`;
CREATE TABLE IF NOT EXISTS `employe` (
  `NUMEMP` bigint(20) NOT NULL,
  `SUPERIEUR` bigint(20) DEFAULT NULL,
  `CODEPROJET` char(4) DEFAULT NULL,
  `NOMEMP` varchar(25) NOT NULL,
  `PRENOMEMP` varchar(25) NOT NULL,
  `POSTE` varchar(20) NOT NULL,
  `SALAIRE` decimal(8,2) NOT NULL,
  `PRIME` decimal(7,2) DEFAULT NULL,
  PRIMARY KEY (`NUMEMP`),
  KEY `FK_EMPLOYE_EMPLOYE` (`SUPERIEUR`),
  KEY `FK_EMPLOYE_PROJET` (`CODEPROJET`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vider la table avant d'insérer `employe`
--

TRUNCATE TABLE `employe`;
--
-- Contenu de la table `employe`
--

INSERT INTO `employe` (`NUMEMP`, `SUPERIEUR`, `CODEPROJET`, `NOMEMP`, `PRENOMEMP`, `POSTE`, `SALAIRE`, `PRIME`) VALUES
(1, 4, 'PR1', 'DUPONT', 'Pierre', 'A22', '8000.00', '1000.00'),
(2, 5, 'PR2', 'JOLIBOIS', 'Rolland', 'A12', '10500.00', '1500.00'),
(3, 6, 'PR1', 'BEAUMONT', 'Jean', 'A25', '12000.00', '2000.00'),
(4, 7, 'PR2', 'DUCHATEL', 'Mireille', 'B12', '11500.00', '3000.00'),
(5, 7, 'PR3', 'MARTIN', 'Robert', 'B21', '13000.00', '0.00'),
(6, 8, 'PR3', 'MAZAUD', 'Patricia', 'B14', '13000.00', '1500.00'),
(7, 15, NULL, 'GIMOND', 'Antoine', 'C17', '21000.00', NULL),
(8, 15, NULL, 'SAULT', 'Jean', 'C23', '21200.00', NULL),
(9, 5, 'PR2', 'GALLI', 'Jean Daniel', 'A25', '10000.00', '2000.00'),
(10, 20, 'PR5', 'JACONO', 'Marie', 'B14', '11500.00', '1500.00'),
(11, 10, 'PR2', 'ANTHONY', 'Henri', 'A15', '9500.00', '0.00'),
(12, 8, 'PR1', 'CANE', 'Michel', 'B15', '10800.00', '1400.00'),
(13, 12, 'PR3', 'GOMEZ', 'Joseph', 'A12', '7500.00', '2000.00'),
(14, 15, NULL, 'RIVIERE', 'Maurice', 'C18', '23000.00', NULL),
(15, NULL, NULL, 'RUSSOT', 'Eric', 'C23', '30000.00', NULL),
(16, 18, 'PR2', 'BERNARDI', 'Patrick', 'A14', '9800.00', '2500.00'),
(17, 14, 'PR1', 'BEUGNIES', 'Maurice', 'B12', '10800.00', '2400.00'),
(18, 8, 'PR5', 'FARNY', 'Daniel', 'B15', '11500.00', '1700.00'),
(19, 8, 'PR4', 'ESTIVAL', 'Sophie', 'B17', '12000.00', '1000.00'),
(20, 15, NULL, 'LUNEAU', 'Henri', 'C17', '22500.00', NULL),
(21, 15, NULL, 'BRESSON', 'Pierre', 'C23', '14000.00', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `inscrit`
--

DROP TABLE IF EXISTS `inscrit`;
CREATE TABLE IF NOT EXISTS `inscrit` (
  `NUMEMP` bigint(20) NOT NULL,
  `CODESEMI` varchar(10) NOT NULL,
  `DATEINSCRIT` date NOT NULL,
  PRIMARY KEY (`CODESEMI`,`NUMEMP`),
  KEY `FK_INSCRIT_EMPLOYE` (`NUMEMP`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vider la table avant d'insérer `inscrit`
--

TRUNCATE TABLE `inscrit`;
--
-- Contenu de la table `inscrit`
--

INSERT INTO `inscrit` (`NUMEMP`, `CODESEMI`, `DATEINSCRIT`) VALUES
(1, 'BR0130223', '2014-01-11'),
(2, 'BR0130223', '2014-01-11'),
(4, 'BR0130223', '2014-01-21'),
(8, 'BR0130223', '2014-02-21'),
(12, 'BR0130914', '2014-09-04'),
(15, 'BR0130914', '2014-08-21'),
(16, 'BR0130914', '2014-08-23'),
(17, 'BR0130914', '2014-09-02'),
(18, 'BR0130914', '2014-08-23'),
(1, 'BR0340413', '2014-04-08'),
(3, 'BR0340413', '2014-04-08'),
(4, 'BR0340413', '2014-04-10'),
(2, 'BR0340518', '2014-05-05'),
(5, 'BR0340518', '2014-05-16'),
(6, 'BR0340518', '2014-05-12'),
(7, 'BR0340518', '2014-05-07'),
(8, 'BR0340518', '2014-05-05'),
(9, 'BR0340921', '2014-09-01'),
(10, 'BR0340921', '2014-09-11'),
(12, 'BR0340921', '2014-09-08'),
(13, 'BR0340921', '2014-09-02'),
(14, 'BR0340921', '2014-09-02'),
(11, 'BR0341020', '2014-10-13'),
(16, 'BR0341020', '2014-10-06'),
(17, 'BR0341020', '2014-10-13'),
(15, 'BR0341207', '2014-07-02'),
(18, 'BR0341207', '2014-07-01'),
(19, 'BR0341207', '2014-07-03'),
(20, 'BR0341207', '2014-07-01'),
(1, 'BR0350216', '2014-01-27'),
(2, 'BR0350216', '2014-01-30'),
(3, 'BR0350216', '2014-01-30'),
(4, 'BR0350316', '2014-03-11'),
(5, 'BR0350316', '2014-03-03'),
(6, 'BR0350316', '2014-03-11'),
(7, 'BR0350316', '2014-03-03'),
(8, 'BR0350525', '2014-05-05'),
(9, 'BR0350525', '2014-05-06'),
(10, 'BR0350525', '2014-05-06'),
(11, 'BR0350525', '2014-05-14'),
(12, 'BR0350525', '2014-05-21'),
(13, 'BR0350907', '2014-07-28'),
(14, 'BR0350907', '2014-09-01'),
(16, 'BR0350907', '2014-08-28'),
(18, 'BR0350907', '2014-09-02'),
(15, 'BR0351019', '2014-10-02'),
(19, 'BR0351019', '2014-10-03'),
(20, 'BR0351019', '2014-10-08'),
(3, 'BR0560210', '2014-02-05'),
(5, 'BR0560210', '2014-01-27'),
(7, 'BR0560210', '2014-01-28'),
(9, 'BR0560210', '2014-02-06'),
(1, 'BR0560525', '2014-05-12'),
(2, 'BR0560525', '2014-05-13'),
(13, 'BR0560525', '2014-05-13'),
(14, 'BR0560525', '2014-05-14'),
(17, 'BR0560914', '2014-09-02'),
(18, 'BR0560914', '2014-09-08'),
(19, 'BR0560914', '2014-09-05'),
(20, 'BR0560914', '2014-09-09'),
(1, 'BR0570323', '2014-03-10'),
(4, 'BR0570323', '2014-03-12'),
(5, 'BR0570323', '2014-03-14'),
(10, 'BR0570928', '2014-09-15'),
(11, 'BR0570928', '2014-09-16'),
(13, 'BR0570928', '2014-09-22'),
(14, 'BR0570928', '2014-09-24'),
(15, 'BR0570928', '2014-09-22'),
(9, 'BR0571012', '2014-10-03'),
(16, 'BR0571012', '2014-10-03'),
(17, 'BR0571012', '2014-10-02');

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

DROP TABLE IF EXISTS `participer`;
CREATE TABLE IF NOT EXISTS `participer` (
  `CODEJOUR` char(2) NOT NULL,
  `CODESEMI` varchar(10) NOT NULL,
  `NUMEMP` bigint(20) NOT NULL,
  PRIMARY KEY (`NUMEMP`,`CODEJOUR`,`CODESEMI`),
  KEY `FK_PARTICIPER_INSCRIT` (`CODESEMI`,`NUMEMP`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vider la table avant d'insérer `participer`
--

TRUNCATE TABLE `participer`;
--
-- Contenu de la table `participer`
--

INSERT INTO `participer` (`CODEJOUR`, `CODESEMI`, `NUMEMP`) VALUES
('LU', 'BR0130223', 1),
('MA', 'BR0130223', 1),
('ME', 'BR0130223', 1),
('LU', 'BR0130223', 2),
('MA', 'BR0130223', 2),
('ME', 'BR0130223', 2),
('LU', 'BR0130223', 4),
('MA', 'BR0130223', 4),
('LU', 'BR0130223', 8),
('MA', 'BR0130223', 8),
('ME', 'BR0130223', 8),
('LU', 'BR0130914', 12),
('MA', 'BR0130914', 12),
('LU', 'BR0130914', 15),
('MA', 'BR0130914', 15),
('LU', 'BR0130914', 16),
('MA', 'BR0130914', 16),
('ME', 'BR0130914', 16),
('LU', 'BR0130914', 17),
('MA', 'BR0130914', 17),
('ME', 'BR0130914', 17),
('LU', 'BR0130914', 18),
('JE', 'BR0340413', 1),
('VE', 'BR0340413', 1),
('JE', 'BR0340413', 3),
('VE', 'BR0340413', 3),
('JE', 'BR0340413', 4),
('VE', 'BR0340413', 4),
('JE', 'BR0340518', 2),
('JE', 'BR0340518', 5),
('VE', 'BR0340518', 5),
('JE', 'BR0340518', 6),
('VE', 'BR0340518', 6),
('JE', 'BR0340518', 7),
('JE', 'BR0340518', 8),
('VE', 'BR0340518', 8),
('JE', 'BR0340921', 9),
('JE', 'BR0340921', 10),
('JE', 'BR0340921', 12),
('VE', 'BR0340921', 12),
('JE', 'BR0340921', 13),
('VE', 'BR0340921', 13),
('JE', 'BR0340921', 14),
('VE', 'BR0340921', 14),
('JE', 'BR0341020', 11),
('VE', 'BR0341020', 11),
('JE', 'BR0341020', 16),
('VE', 'BR0341020', 16),
('JE', 'BR0341020', 17),
('JE', 'BR0341207', 15),
('VE', 'BR0341207', 15),
('JE', 'BR0341207', 18),
('VE', 'BR0341207', 18),
('JE', 'BR0341207', 19),
('JE', 'BR0341207', 20),
('VE', 'BR0341207', 20),
('JE', 'BR0350216', 1),
('LU', 'BR0350216', 1),
('MA', 'BR0350216', 1),
('ME', 'BR0350216', 1),
('VE', 'BR0350216', 1),
('JE', 'BR0350216', 2),
('LU', 'BR0350216', 2),
('MA', 'BR0350216', 2),
('ME', 'BR0350216', 2),
('VE', 'BR0350216', 2),
('LU', 'BR0350216', 3),
('MA', 'BR0350216', 3),
('ME', 'BR0350216', 3),
('LU', 'BR0350316', 4),
('MA', 'BR0350316', 4),
('ME', 'BR0350316', 4),
('VE', 'BR0350316', 4),
('JE', 'BR0350316', 5),
('LU', 'BR0350316', 5),
('MA', 'BR0350316', 5),
('ME', 'BR0350316', 5),
('VE', 'BR0350316', 5),
('LU', 'BR0350316', 6),
('JE', 'BR0350316', 7),
('LU', 'BR0350316', 7),
('MA', 'BR0350316', 7),
('ME', 'BR0350316', 7),
('JE', 'BR0350525', 8),
('LU', 'BR0350525', 8),
('MA', 'BR0350525', 8),
('ME', 'BR0350525', 8),
('VE', 'BR0350525', 8),
('JE', 'BR0350525', 9),
('LU', 'BR0350525', 9),
('ME', 'BR0350525', 9),
('VE', 'BR0350525', 9),
('JE', 'BR0350525', 10),
('LU', 'BR0350525', 10),
('MA', 'BR0350525', 10),
('ME', 'BR0350525', 10),
('VE', 'BR0350525', 10),
('LU', 'BR0350525', 11),
('MA', 'BR0350525', 11),
('ME', 'BR0350525', 11),
('VE', 'BR0350525', 11),
('JE', 'BR0350525', 12),
('LU', 'BR0350525', 12),
('MA', 'BR0350525', 12),
('ME', 'BR0350525', 12),
('VE', 'BR0350525', 12),
('JE', 'BR0350907', 13),
('LU', 'BR0350907', 13),
('MA', 'BR0350907', 13),
('ME', 'BR0350907', 13),
('JE', 'BR0350907', 14),
('LU', 'BR0350907', 14),
('MA', 'BR0350907', 14),
('ME', 'BR0350907', 14),
('VE', 'BR0350907', 14),
('LU', 'BR0350907', 16),
('MA', 'BR0350907', 16),
('ME', 'BR0350907', 16),
('JE', 'BR0350907', 18),
('LU', 'BR0350907', 18),
('ME', 'BR0350907', 18),
('VE', 'BR0350907', 18),
('JE', 'BR0351019', 15),
('LU', 'BR0351019', 15),
('MA', 'BR0351019', 15),
('ME', 'BR0351019', 15),
('VE', 'BR0351019', 15),
('JE', 'BR0351019', 19),
('LU', 'BR0351019', 19),
('MA', 'BR0351019', 19),
('ME', 'BR0351019', 19),
('VE', 'BR0351019', 19),
('JE', 'BR0351019', 20),
('LU', 'BR0351019', 20),
('MA', 'BR0351019', 20),
('ME', 'BR0351019', 20),
('JE', 'BR0560210', 3),
('ME', 'BR0560210', 3),
('JE', 'BR0560210', 5),
('ME', 'BR0560210', 5),
('VE', 'BR0560210', 5),
('JE', 'BR0560210', 7),
('ME', 'BR0560210', 7),
('VE', 'BR0560210', 7),
('JE', 'BR0560210', 9),
('ME', 'BR0560210', 9),
('VE', 'BR0560210', 9),
('JE', 'BR0560525', 1),
('ME', 'BR0560525', 1),
('JE', 'BR0560525', 2),
('ME', 'BR0560525', 2),
('VE', 'BR0560525', 2),
('JE', 'BR0560525', 13),
('ME', 'BR0560525', 13),
('JE', 'BR0560525', 14),
('ME', 'BR0560525', 14),
('VE', 'BR0560525', 14),
('JE', 'BR0560914', 17),
('ME', 'BR0560914', 17),
('JE', 'BR0560914', 18),
('ME', 'BR0560914', 18),
('VE', 'BR0560914', 18),
('ME', 'BR0560914', 19),
('JE', 'BR0560914', 20),
('ME', 'BR0560914', 20),
('JE', 'BR0570323', 1),
('LU', 'BR0570323', 1),
('MA', 'BR0570323', 1),
('ME', 'BR0570323', 1),
('JE', 'BR0570323', 4),
('LU', 'BR0570323', 4),
('MA', 'BR0570323', 4),
('ME', 'BR0570323', 4),
('LU', 'BR0570323', 5),
('MA', 'BR0570323', 5),
('LU', 'BR0570928', 10),
('MA', 'BR0570928', 10),
('ME', 'BR0570928', 10),
('JE', 'BR0570928', 11),
('LU', 'BR0570928', 11),
('MA', 'BR0570928', 11),
('ME', 'BR0570928', 11),
('JE', 'BR0570928', 13),
('LU', 'BR0570928', 13),
('MA', 'BR0570928', 13),
('ME', 'BR0570928', 13),
('LU', 'BR0570928', 14),
('MA', 'BR0570928', 14),
('ME', 'BR0570928', 14),
('LU', 'BR0570928', 15),
('LU', 'BR0571012', 9),
('MA', 'BR0571012', 9),
('LU', 'BR0571012', 16),
('MA', 'BR0571012', 16),
('ME', 'BR0571012', 16),
('JE', 'BR0571012', 17),
('LU', 'BR0571012', 17),
('MA', 'BR0571012', 17),
('ME', 'BR0571012', 17);

-- --------------------------------------------------------

--
-- Structure de la table `projet`
--

DROP TABLE IF EXISTS `projet`;
CREATE TABLE IF NOT EXISTS `projet` (
  `CODEPROJET` char(4) NOT NULL,
  `NOMPROJET` varchar(20) NOT NULL,
  `DEBUTPROJ` date NOT NULL,
  `FINPREVUE` date NOT NULL,
  `NOMCONTACT` varchar(35) NOT NULL,
  PRIMARY KEY (`CODEPROJET`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vider la table avant d'insérer `projet`
--

TRUNCATE TABLE `projet`;
--
-- Contenu de la table `projet`
--

INSERT INTO `projet` (`CODEPROJET`, `NOMPROJET`, `DEBUTPROJ`, `FINPREVUE`, `NOMCONTACT`) VALUES
('PR1', 'Anciens combattants', '2014-01-13', '2014-07-01', 'Monsieur DUROI'),
('PR2', 'Paye ADCV', '2014-04-07', '2014-11-28', 'Monsieur MEYZANDIER'),
('PR3', 'Pensions', '2014-04-14', '2014-10-31', 'Madame MOULINIE'),
('PR4', 'Refonte base pieces', '2014-05-05', '2014-11-19', 'Monsieur BERTIN'),
('PR5', 'Miroiterie Bonnet', '2014-06-16', '2014-05-01', 'Monsieur BONNET');

-- --------------------------------------------------------

--
-- Structure de la table `seminaire`
--

DROP TABLE IF EXISTS `seminaire`;
CREATE TABLE IF NOT EXISTS `seminaire` (
  `CODESEMI` varchar(10) NOT NULL,
  `CODECOURS` varchar(6) NOT NULL,
  `DATEDEBUTSEM` date NOT NULL,
  PRIMARY KEY (`CODESEMI`),
  KEY `FK_SEMINAIRE_COURS` (`CODECOURS`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vider la table avant d'insérer `seminaire`
--

TRUNCATE TABLE `seminaire`;
--
-- Contenu de la table `seminaire`
--

INSERT INTO `seminaire` (`CODESEMI`, `CODECOURS`, `DATEDEBUTSEM`) VALUES
('BR0130223', 'BR013', '2014-02-24'),
('BR0130914', 'BR013', '2014-09-15'),
('BR0340413', 'BR034', '2014-04-14'),
('BR0340518', 'BR034', '2014-05-19'),
('BR0340921', 'BR034', '2014-09-25'),
('BR0341020', 'BR034', '2014-10-21'),
('BR0341207', 'BR034', '2014-12-08'),
('BR0350216', 'BR035', '2014-02-17'),
('BR0350316', 'BR035', '2014-03-17'),
('BR0350525', 'BR035', '2014-05-26'),
('BR0350907', 'BR035', '2014-09-08'),
('BR0351019', 'BR035', '2014-10-20'),
('BR0560210', 'BR056', '2014-02-12'),
('BR0560525', 'BR056', '2014-05-26'),
('BR0560914', 'BR056', '2014-09-15'),
('BR0570323', 'BR057', '2014-03-24'),
('BR0570928', 'BR057', '2014-09-29'),
('BR0571012', 'BR057', '2014-10-13'),
('BR0701012', 'BR070', '2014-10-13');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `employe`
--
ALTER TABLE `employe`
  ADD CONSTRAINT `employe_ibfk_1` FOREIGN KEY (`SUPERIEUR`) REFERENCES `employe` (`NUMEMP`),
  ADD CONSTRAINT `employe_ibfk_2` FOREIGN KEY (`CODEPROJET`) REFERENCES `projet` (`CODEPROJET`);

--
-- Contraintes pour la table `inscrit`
--
ALTER TABLE `inscrit`
  ADD CONSTRAINT `inscrit_ibfk_1` FOREIGN KEY (`CODESEMI`) REFERENCES `seminaire` (`CODESEMI`),
  ADD CONSTRAINT `inscrit_ibfk_2` FOREIGN KEY (`NUMEMP`) REFERENCES `employe` (`NUMEMP`);

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `participer_ibfk_1` FOREIGN KEY (`CODESEMI`, `NUMEMP`) REFERENCES `inscrit` (`CODESEMI`, `NUMEMP`);

--
-- Contraintes pour la table `seminaire`
--
ALTER TABLE `seminaire`
  ADD CONSTRAINT `seminaire_ibfk_1` FOREIGN KEY (`CODECOURS`) REFERENCES `cours` (`CODECOURS`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
```
