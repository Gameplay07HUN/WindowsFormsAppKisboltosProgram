-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Ápr 24. 09:17
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `kisbolt2`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `raktar`
--

CREATE TABLE `raktar` (
  `raktarkod` int(3) NOT NULL,
  `raktarnev` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `raktar`
--

INSERT INTO `raktar` (`raktarkod`, `raktarnev`) VALUES
(521, 'Bolt melletti'),
(522, 'Diószegi utca');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `raktarozas`
--

CREATE TABLE `raktarozas` (
  `cikkszam` int(6) NOT NULL,
  `raktarkod` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `raktarozas`
--

INSERT INTO `raktarozas` (`cikkszam`, `raktarkod`) VALUES
(246158, 521),
(427073, 521),
(1382006, 522);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles`
--

CREATE TABLE `rendeles` (
  `cikkszam` int(6) NOT NULL,
  `vevokod` varchar(7) DEFAULT NULL,
  `datum` datetime DEFAULT NULL,
  `mennyiseg` int(3) DEFAULT NULL,
  `beszerzesiar` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `rendeles`
--

INSERT INTO `rendeles` (`cikkszam`, `vevokod`, `datum`, `mennyiseg`, `beszerzesiar`) VALUES
(246158, 'RJ9ADKN', '2023-03-08 00:00:00', 100, 500),
(427073, 'AY4ZQPN', '2023-02-08 00:00:00', 150, 400);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termek`
--

CREATE TABLE `termek` (
  `cikkszam` int(6) NOT NULL,
  `kategória` varchar(100) DEFAULT NULL,
  `aruneve` varchar(100) DEFAULT NULL,
  `eladasiar` int(100) DEFAULT NULL,
  `marka` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `termek`
--

INSERT INTO `termek` (`cikkszam`, `kategória`, `aruneve`, `eladasiar`, `marka`) VALUES
(246158, 'tea', 'LIPTON ICE TEA CITROM ÍZŰ 1,5 L', 559, 'LIPTON'),
(427073, 'tea', 'XIXO ICE TEA CITROMOS FEKETE TEA 250 ML', 199, 'XIXO'),
(1382006, 'csoki', 'MILKA FEHÉR CSOKOLÁDÉ 100 G', 359, 'MILKA');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vevo`
--

CREATE TABLE `vevo` (
  `vevokod` varchar(7) NOT NULL,
  `vevonev` varchar(999) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `vevo`
--

INSERT INTO `vevo` (`vevokod`, `vevonev`) VALUES
('AD7ACHQ', 'Balázs'),
('AY4ZQPN', 'Norbi'),
('RJ9ADKN', 'Dani');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `raktar`
--
ALTER TABLE `raktar`
  ADD PRIMARY KEY (`raktarkod`);

--
-- A tábla indexei `raktarozas`
--
ALTER TABLE `raktarozas`
  ADD PRIMARY KEY (`cikkszam`),
  ADD UNIQUE KEY `cikkszam` (`cikkszam`,`raktarkod`),
  ADD KEY `raktarozas_ibfk_1` (`raktarkod`);

--
-- A tábla indexei `rendeles`
--
ALTER TABLE `rendeles`
  ADD KEY `fk_rendeles_termek` (`cikkszam`),
  ADD KEY `vevokod` (`vevokod`);

--
-- A tábla indexei `termek`
--
ALTER TABLE `termek`
  ADD PRIMARY KEY (`cikkszam`);

--
-- A tábla indexei `vevo`
--
ALTER TABLE `vevo`
  ADD PRIMARY KEY (`vevokod`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `raktarozas`
--
ALTER TABLE `raktarozas`
  ADD CONSTRAINT `raktarozas_ibfk_1` FOREIGN KEY (`raktarkod`) REFERENCES `raktar` (`raktarkod`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `rendeles`
--
ALTER TABLE `rendeles`
  ADD CONSTRAINT `fk_rendeles_termek` FOREIGN KEY (`cikkszam`) REFERENCES `termek` (`cikkszam`),
  ADD CONSTRAINT `rendeles_ibfk_1` FOREIGN KEY (`vevokod`) REFERENCES `vevo` (`vevokod`);

--
-- Megkötések a táblához `termek`
--
ALTER TABLE `termek`
  ADD CONSTRAINT `termek_ibfk_1` FOREIGN KEY (`cikkszam`) REFERENCES `raktarozas` (`cikkszam`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `vevo`
--
ALTER TABLE `vevo`
  ADD CONSTRAINT `Vevo_ibfk_1` FOREIGN KEY (`vevokod`) REFERENCES `rendeles` (`vevokod`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
