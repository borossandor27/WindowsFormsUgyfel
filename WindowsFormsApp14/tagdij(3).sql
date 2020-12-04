-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 04. 19:51
-- Kiszolgáló verziója: 10.1.36-MariaDB
-- PHP verzió: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `tagdij`
--
CREATE DATABASE IF NOT EXISTS `tagdij` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `tagdij`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `befiz`
--

DROP TABLE IF EXISTS `befiz`;
CREATE TABLE `befiz` (
  `azon` int(10) UNSIGNED NOT NULL,
  `datum` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `osszeg` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `befiz`
--

INSERT INTO `befiz` (`azon`, `datum`, `osszeg`) VALUES
(1001, '2019-01-11 16:25:03', 60000),
(1002, '2019-01-17 11:01:19', 5000),
(1004, '2019-01-21 15:40:25', 18000),
(1005, '2019-02-02 09:26:54', 24000),
(1004, '2019-02-04 11:47:08', 30000),
(1006, '2019-02-20 16:36:12', 9000),
(1007, '2019-02-21 13:44:02', 12000),
(1005, '2019-03-01 10:49:41', 8000),
(1007, '2019-03-06 14:52:44', 15000),
(1009, '2019-04-12 20:21:57', 20000),
(1004, '2019-05-10 12:00:29', 8000),
(1006, '2019-06-08 11:10:26', 4000),
(1010, '2019-06-22 17:22:43', 7000),
(1010, '2019-07-14 03:35:02', 8500),
(1012, '2019-07-19 12:48:51', 41000),
(1004, '2019-09-02 16:51:25', 11000),
(1006, '2019-09-05 14:34:48', 15000),
(1007, '2019-09-25 21:16:38', 4000),
(1012, '2019-10-01 13:13:34', 10000),
(1010, '2019-10-01 14:29:37', 5000),
(1012, '2019-10-12 16:54:15', 6000),
(1007, '2019-11-24 11:02:52', 14000),
(1009, '2019-11-25 10:48:31', 19000),
(1007, '2019-11-25 16:01:24', 17000),
(1002, '2019-11-29 13:34:08', 10000),
(1010, '2019-11-30 08:27:50', 12000),
(1004, '2019-12-12 22:02:20', 20000),
(1009, '2019-12-15 12:28:44', 25000),
(1002, '2019-12-23 19:42:20', 3000),
(1005, '2019-12-23 20:33:28', 7500),
(1002, '2019-12-29 10:00:47', 18000),
(1001, '2020-11-24 00:00:00', 222),
(1001, '2020-11-24 00:00:00', 2000),
(1001, '2020-11-26 16:03:35', 1500),
(1001, '2020-11-26 16:22:37', 2500),
(1001, '2020-11-26 16:22:37', 2600),
(1001, '2020-11-26 16:22:37', 2700),
(1001, '2020-11-26 16:22:37', 2800),
(1001, '2020-11-27 16:17:24', 5000),
(1001, '2020-11-27 16:17:24', 5001),
(1001, '2020-11-27 16:17:24', 5002);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ugyfel`
--

DROP TABLE IF EXISTS `ugyfel`;
CREATE TABLE `ugyfel` (
  `azon` int(10) UNSIGNED NOT NULL,
  `nev` varchar(30) NOT NULL,
  `szulev` smallint(4) UNSIGNED NOT NULL,
  `irszam` smallint(4) UNSIGNED NOT NULL,
  `orsz` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `ugyfel`
--

INSERT INTO `ugyfel` (`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES
(1001, 'Buda Jenõ', 1982, 1026, 'H'),
(1002, 'Makkos Mária', 1970, 1128, 'H'),
(1003, 'Pilis Csaba', 1995, 2442, 'H'),
(1004, 'Török Bálint', 1988, 2128, 'H'),
(1005, 'Szent Endre', 1962, 2000, 'H'),
(1006, 'Kis Marton', 1991, 9999, 'A'),
(1007, 'Békés Csaba', 1989, 4400, 'H'),
(1009, 'Dráva Szabolcs', 1985, 7520, 'H'),
(1010, 'Nagy Károly', 1975, 9999, 'RO'),
(1012, 'Boros Jenõ', 1982, 9999, 'RO'),
(1013, 'Száva Magdolna', 1987, 9999, 'HR');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `befiz`
--
ALTER TABLE `befiz`
  ADD KEY `befiz_ibfk_1` (`azon`);

--
-- A tábla indexei `ugyfel`
--
ALTER TABLE `ugyfel`
  ADD PRIMARY KEY (`azon`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ugyfel`
--
ALTER TABLE `ugyfel`
  MODIFY `azon` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1017;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `befiz`
--
ALTER TABLE `befiz`
  ADD CONSTRAINT `befiz_ibfk_1` FOREIGN KEY (`azon`) REFERENCES `ugyfel` (`azon`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
