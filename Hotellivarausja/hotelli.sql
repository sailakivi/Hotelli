-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 04.03.2024 klo 08:00
-- Palvelimen versio: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `asiakasID` int(11) NOT NULL,
  `kayttajanimi` varchar(9) NOT NULL,
  `etunimi` varchar(25) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `lahiosoite` varchar(50) NOT NULL,
  `postinumero` varchar(10) NOT NULL,
  `postitoimipaikka` varchar(25) NOT NULL,
  `salasana` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `asiakkaat`
--

INSERT INTO `asiakkaat` (`asiakasID`, `kayttajanimi`, `etunimi`, `sukunimi`, `lahiosoite`, `postinumero`, `postitoimipaikka`, `salasana`) VALUES
(1, 'jlindroos', 'Jyri', 'Lindroos', 'Keskikatu 3', '04200', 'Kerava', '7XC3nVsZ5MT2dQ3WDeWGSQ=='),
(2, 'sirhotok', 'Sirpa', 'Hotokka', 'Kallioimarteentie 35', '02450', 'Espoo', 'ko1iaaX0G7clAa4FyBANkg=='),
(3, 'otthotok', 'Otto', 'Hotokka', 'Kallioimarteentie 35', '02450', 'Espoo', '7qmKcsmh8yVsjDA+5AOF0A=='),
(4, 'eevterva', 'Eeva', 'Tervala', 'Keskikatu 3', '04200', 'Kerava', 'MY/kqvNjftDFKecseIGwyQ==');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `huoneenNro` int(11) NOT NULL,
  `huonetyyppi` int(11) DEFAULT NULL,
  `puhelin` varchar(10) NOT NULL,
  `vapaa` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huoneet`
--

INSERT INTO `huoneet` (`huoneenNro`, `huonetyyppi`, `puhelin`, `vapaa`) VALUES
(110, 1, '110', 1),
(111, 1, '111', 1),
(112, 1, '112', 1),
(120, 2, '120', 1),
(121, 2, '121', 0),
(130, 3, '130', 1),
(131, 3, '131', 0),
(140, 4, '140', 1);

-- --------------------------------------------------------

--
-- Rakenne taululle `huonekategoria`
--

CREATE TABLE `huonekategoria` (
  `kategoriaId` int(11) NOT NULL,
  `Huonetyyppi` varchar(15) NOT NULL,
  `Hinta` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huonekategoria`
--

INSERT INTO `huonekategoria` (`kategoriaId`, `Huonetyyppi`, `Hinta`) VALUES
(1, 'Yhden hengen', '120'),
(2, 'Kahden hengen', '90'),
(3, 'Perhe', '150'),
(4, 'Sviitti', '300');

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `huoneenNro` int(11) NOT NULL,
  `asiakasId` int(11) NOT NULL,
  `Sisaan` date NOT NULL,
  `Ulos` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `varaukset`
--

INSERT INTO `varaukset` (`huoneenNro`, `asiakasId`, `Sisaan`, `Ulos`) VALUES
(110, 1, '2023-02-10', '2023-02-12'),
(120, 2, '2023-02-13', '2023-02-19'),
(131, 1, '2023-03-11', '2023-03-12');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`asiakasID`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`huoneenNro`),
  ADD KEY `Huonetyyppi` (`huonetyyppi`);

--
-- Indexes for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  ADD PRIMARY KEY (`kategoriaId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `asiakasID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  MODIFY `kategoriaId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `huoneet_ibfk_1` FOREIGN KEY (`huonetyyppi`) REFERENCES `huonekategoria` (`kategoriaId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
