-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 14, 2021 at 02:50 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `logist`
--

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `ID` int(255) UNSIGNED NOT NULL,
  `Назва` varchar(40) NOT NULL,
  `Тип` varchar(40) NOT NULL,
  `Кількість` int(255) UNSIGNED NOT NULL,
  `Ім'я` varchar(40) NOT NULL,
  `Прізвище` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`ID`, `Назва`, `Тип`, `Кількість`, `Ім'я`, `Прізвище`) VALUES
(1, 'HP-Pavillion-25-SU', 'Ноутбук', 1, 'Максим', 'Волнєйкін'),
(2, 'LG-MW2225', 'Монітор', 15, 'Олександр', 'Горбатенков'),
(3, 'Corsar-Z33', 'Системний блок', 7, 'Дарій', 'Гудзь'),
(4, 'Canom-PrinterLux', 'Прінтер', 210, 'Ілля', 'Куликов'),
(5, 'Raker Pro X', 'Мишка', 52, 'Анатолій', 'Левківський'),
(6, 'Abus-Mk244', 'Монітор', 40, 'Андрій', 'Феноков'),
(7, 'Zywie ZC-3', 'Мишка', 120, 'Максим', 'Мартинов');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD UNIQUE KEY `id` (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `ID` int(255) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
