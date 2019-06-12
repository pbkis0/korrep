-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Jún 10. 16:21
-- Kiszolgáló verziója: 10.1.38-MariaDB
-- PHP verzió: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `beer`
--

DROP DATABASE IF EXISTS `beer`;
CREATE DATABASE IF NOT EXISTS `beer` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `beer`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
CREATE TABLE IF NOT EXISTS `manufacturer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `manufacturer`
--

INSERT INTO `manufacturer` (`ID`, `Name`) VALUES
(1, 'Borsodi Sörgyár Kft.'),
(2, 'Heineken Hungária Sörgyárak Zrt.'),
(3, 'Dreher Sörgyárak Zrt.'),
(4, 'Pécsi Sörfőzde Zrt.');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Brand` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Alcohol` float NOT NULL,
  `Price` int(11) NOT NULL,
  `ManufacturerID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Brand` (`Brand`),
  KEY `manufacturerid` (`ManufacturerID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `products`
--

INSERT INTO `products` (`ID`, `Brand`, `Alcohol`, `Price`, `ManufacturerID`) VALUES
(1, 'Borsodi Világos', 4.5, 180, 1),
(2, 'Borsodi Bivaly', 6.5, 250, 1),
(3, 'Soproni 1895', 5.3, 300, 2),
(4, 'Soproni', 4.5, 230, 2),
(5, 'Arany Ászok', 4.3, 230, 3),
(6, 'Dreher Bak', 7.3, 450, 3),
(7, 'Balatoni Világos', 3, 300, 3),
(8, 'Miller Genuine Draft', 4.7, 350, 3),
(9, 'Szalon Barna', 5.8, 250, 4),
(10, 'Radler', 2.5, 480, 4),
(11, 'Heineken', 5, 260, 2),
(12, 'Soproni Fekete Démon', 5.2, 340, 2),
(13, 'Dreher Alkoholmentes', 0.5, 200, 3),
(14, 'Pilsner Urquell', 4.4, 220, 3),
(15, 'Dreher Classic', 5.2, 320, 3);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `manufacturerid` FOREIGN KEY (`ManufacturerID`) REFERENCES `manufacturer` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
