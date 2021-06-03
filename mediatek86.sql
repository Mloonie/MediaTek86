-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 25 mai 2021 à 13:46
-- Version du serveur :  8.0.21
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--
CREATE DATABASE IF NOT EXISTS `mediatek86` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `mediatek86`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `idmotif` int NOT NULL,
  `datefin` datetime NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `i_fk_absence_motif1` (`idmotif`),
  KEY `i_fk_absence_personnel1` (`idpersonnel`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `idmotif`, `datefin`) VALUES
(1, '2020-03-29 16:35:42', 2, '2021-10-22 16:35:42'),
(1, '2020-08-23 06:12:18', 4, '2020-11-17 06:12:18'),
(1, '2020-09-22 17:31:03', 4, '2020-06-26 17:31:03'),
(1, '2020-10-04 18:20:15', 2, '2021-01-17 18:20:15'),
(1, '2020-11-07 05:16:39', 1, '2020-05-30 05:16:39'),
(1, '2020-12-15 11:21:09', 2, '2020-04-03 11:21:09'),
(2, '2020-05-12 22:13:24', 2, '2021-03-09 22:13:24'),
(2, '2020-05-15 01:38:28', 1, '2020-03-23 01:38:28'),
(2, '2020-07-20 00:52:08', 4, '2020-10-17 00:52:08'),
(2, '2020-10-07 22:57:20', 1, '2021-06-07 22:57:20'),
(2, '2020-10-10 02:37:47', 4, '2022-01-03 02:37:47'),
(2, '2020-11-19 23:41:33', 2, '2021-08-29 23:41:33'),
(2, '2021-02-04 02:22:35', 1, '2020-03-29 02:22:35'),
(2, '2021-03-05 18:15:11', 4, '2021-11-14 18:15:11'),
(3, '2020-04-02 14:47:24', 2, '2020-06-16 14:47:24'),
(3, '2020-04-18 07:17:20', 1, '2020-10-05 07:17:20'),
(3, '2020-04-19 10:01:19', 2, '2020-07-08 10:01:19'),
(3, '2020-04-30 08:25:22', 4, '2021-06-04 08:25:22'),
(3, '2020-11-29 06:22:36', 1, '2021-02-16 06:22:36'),
(3, '2020-12-13 17:48:14', 3, '2021-09-19 17:48:14'),
(4, '2020-06-07 19:25:19', 2, '2022-01-26 19:25:19'),
(4, '2020-10-08 21:45:02', 3, '2021-07-10 21:45:02'),
(4, '2021-02-20 07:35:58', 4, '2020-12-20 07:35:58'),
(5, '2020-04-17 16:38:14', 1, '2020-08-08 16:38:14'),
(5, '2020-07-19 07:20:12', 1, '2020-10-11 07:20:12'),
(5, '2020-07-19 13:17:26', 2, '2021-11-30 13:17:26'),
(5, '2020-10-26 04:40:00', 1, '2021-10-15 04:40:00'),
(5, '2020-11-25 23:34:16', 1, '2020-05-10 23:34:16'),
(5, '2020-12-06 12:23:39', 3, '2021-06-12 12:23:39'),
(6, '2020-05-14 13:19:41', 4, '2020-03-23 13:19:41'),
(6, '2020-06-11 14:37:32', 4, '2020-07-31 14:37:32'),
(6, '2020-06-21 10:07:00', 3, '2021-04-21 10:07:00'),
(6, '2020-07-25 04:14:01', 1, '2020-12-15 04:14:01'),
(6, '2020-10-14 18:56:08', 4, '2020-10-05 18:56:08'),
(6, '2021-02-01 22:45:16', 2, '2020-09-22 22:45:16'),
(7, '2020-03-13 22:54:58', 4, '2020-05-28 22:54:58'),
(7, '2020-12-12 11:35:22', 3, '2020-11-29 11:35:22'),
(8, '2020-06-26 02:40:04', 1, '2021-06-28 02:40:04'),
(8, '2020-07-14 15:16:49', 3, '2020-12-07 15:16:49'),
(8, '2020-12-08 01:02:50', 4, '2021-04-12 01:02:50'),
(8, '2020-12-27 20:49:47', 2, '2020-04-17 20:49:47'),
(8, '2021-02-28 04:02:41', 2, '2022-03-09 04:02:41'),
(9, '2020-07-24 21:12:20', 4, '2020-09-02 21:12:20'),
(9, '2020-08-22 17:38:38', 1, '2021-09-15 17:38:38'),
(9, '2021-01-08 02:18:33', 2, '2020-04-28 02:18:33'),
(10, '2020-05-13 11:17:17', 3, '2021-11-15 11:17:17'),
(10, '2020-05-21 11:58:58', 2, '2020-12-11 11:58:58'),
(10, '2021-01-11 12:55:08', 4, '2021-02-02 12:55:08'),
(10, '2021-03-04 02:16:38', 3, '2020-05-22 02:16:38');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `idservice` int NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `i_fk_personnel_service1` (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 3, 'Hale', 'Reese', '0516687454', 'dolor@Morbiquis.net'),
(2, 1, 'Coleman', 'Rhea', '0993503553', 'vitae@maurisaliquameu.edu'),
(3, 1, 'Christensen', 'Hayden', '0846093985', 'ultrices.Duis.volutpat@tellus.org'),
(4, 2, 'Mills', 'Blaze', '0870395599', 'quis@ligula.net'),
(5, 3, 'Phillips', 'Odette', '0253244541', 'eu@tellusAeneanegestas.ca'),
(6, 1, 'Woods', 'Karen', '0738025771', 'In.tincidunt.congue@et.ca'),
(7, 3, 'Larsen', 'Chaim', '0848120702', 'turpis.Aliquam.adipiscing@Maecenasmalesuada.net'),
(8, 2, 'Saline', 'Herrodis', '0498295825', 'et.malesuada@sem.com'),
(9, 1, 'Cooley', 'Gray', '0434513006', 'in.faucibus.orci@sitametdapibus.org'),
(10, 2, 'Gay', 'Lucas', '0783165705', 'Duis@maurisanunc.ca');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '09e4739655765e31a5c40bb2a685aa21eaf415cf4dfabe7580565aa8cbefe9e4');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'mediation culturelle'),
(3, 'pret');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
