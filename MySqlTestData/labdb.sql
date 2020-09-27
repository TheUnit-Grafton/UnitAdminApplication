-- phpMyAdmin SQL Dump
-- version 4.9.5deb2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Sep 27, 2020 at 10:38 AM
-- Server version: 8.0.21-0ubuntu0.20.04.4
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `labdb`
--
CREATE DATABASE IF NOT EXISTS `labdb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `labdb`;

-- --------------------------------------------------------

--
-- Table structure for table `Activities`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Activities`;
CREATE TABLE IF NOT EXISTS `Activities` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ActivityName` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ActivityType` int NOT NULL,
  `ActivityAddress` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ActivityPort` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `IsCurrent` tinyint(1) NOT NULL,
  `ActivityDescription` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Activities`:
--

--
-- Dumping data for table `Activities`
--

INSERT INTO `Activities` (`Id`, `ActivityName`, `ActivityType`, `ActivityAddress`, `ActivityPort`, `IsCurrent`, `ActivityDescription`) VALUES
(1, 'The Unit Learning', 2, 'http://learning.grafton.internal', NULL, 1, 'Web-based, self-paced courses in coding skills, Scratch, 3D Graphics, Game Design, and game building with Unity and BuildBox.  New courses are being added all the time, so if there is something in particular you would like to learn, talk to one of the Mentors to see if a course can be created.'),
(2, 'MineTest (Creative mode)', 0, 'games.grafton.internal', '2999', 1, 'The UnIT Grafton\'s \'Creative World\' MineTest server.  This world does not allow you to destroy other players constructs.'),
(3, '5 Minute Dungeons', 1, 'With Ben', NULL, 0, 'Play a game of 5 Minute Dungeons with Ben...see if you can beat those monsters!'),
(4, 'MineTest (PvP mode)', 0, 'games.grafton.internal', '2990', 0, 'Connect to our \'Player vs Player\' MineTest world with some friends, and reign havoc and destruction.'),
(5, 'Game Planning', 3, 'http://boards.grafton.internal', NULL, 0, 'Got any good ideas to include in our game? Go to the Development Boards and create a card with your ideas.  The Mentors can help you get started if you are not sure how.\n\nNOTE: You will need to remember your login for this site.'),
(7, 'Aussie Trivia', 1, 'With Ben', NULL, 0, 'How much do you know about Aussie Trivia?  This game for up to 4 players will put you to the test.'),
(8, 'Catalog computer parts', 3, 'See Steve to get a temporary login for the database', NULL, 1, 'All computers and spare parts belonging to The UnIT need to be cataloged and added to the database.  All non-functioning and non-useful parts need to be disposed of.'),
(9, 'Pandemic', 1, 'With Ben', NULL, 0, 'Save the world from a virus outbreak'),
(19, 'Design Learning reward badges', 3, 'With Ben', NULL, 1, 'The UnIT learning system has the ability to reward learners with badges describing their achievements. We need YOUR help to design and create these badges to include in our learning system.');

-- --------------------------------------------------------

--
-- Table structure for table `Announcements`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Announcements`;
CREATE TABLE IF NOT EXISTS `Announcements` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Message` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LinkAddress` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `IsCurrent` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Announcements`:
--

--
-- Dumping data for table `Announcements`
--

INSERT INTO `Announcements` (`Id`, `Message`, `LinkAddress`, `IsCurrent`) VALUES
(1, 'A new version of MineTest is available', '/files/MineTest5-1.zip', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Computers`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Computers`;
CREATE TABLE IF NOT EXISTS `Computers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Brand` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `CPU` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Speed` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `MemorySizeInGb` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `MemoryType` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `HardDriveSizeInGb` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `HardDriveBrand` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `SerialNumber` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ObtainedFrom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `OperatingSystem` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `FormFactor` int NOT NULL DEFAULT '0',
  `IsCurrentAsset` tinyint(1) NOT NULL DEFAULT '0',
  `Comments` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `AssetTag` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `DriveType` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Computers`:
--

--
-- Dumping data for table `Computers`
--

INSERT INTO `Computers` (`Id`, `Brand`, `CPU`, `Speed`, `MemorySizeInGb`, `MemoryType`, `HardDriveSizeInGb`, `HardDriveBrand`, `SerialNumber`, `ObtainedFrom`, `OperatingSystem`, `FormFactor`, `IsCurrentAsset`, `Comments`, `AssetTag`, `DriveType`) VALUES
(1, 'The UnIT Main Server', 'AMD Ryzen 3 3200G', '3.2GHz', '16Gb', 'DDR4', '640Gb', 'Seagate', 'N/A', 'Built by TheUnIT members', 'Linux 18.04 LTS', 5, 1, 'Name: server.grafton.internal\nIP Address: 192.168.1.10', 'S-001', 0),
(2, 'TheUnIT Games Server', 'AMD Ryzen 5 3400G ', '3.4GHz', '16GB', 'DDR4', '1Tb', 'Seagate', 'N/A', 'Built Inhouse', 'Linux 18.04.03 LTS', 5, 1, 'Games server for TheLab Grafton.', 'S-002', 0),
(3, 'Lenovo ThinkPad X131e', 'Celeron 887', '1.5GHz', '4Gb', 'SODIM', '128Gb', 'Samsung', '03BB7010262012128006DE7', 'Donated - Ex school', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by South Grafton HIgh', 'C-001', 1),
(4, 'DELL', 'Intel Core i3-2310M', '2.10GHz', '4GB', 'DDR3', ' 460GB', 'DNF', '24F1TP1', 'Donation', 'Windows 7 Home Premium X64', 0, 0, 'Non SP1', NULL, 0),
(5, 'Lenovo Thinkpad X130e', 'Celeron 857', '1.2Ghz', '4GB', 'DDR', '320GB', 'Seagate', 'LR-9BLGN', 'Grafton High', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by Grafton High', 'C-006', 0),
(9, 'Lenovo Thinkpad X131e', 'Celeron 887', '1.5GHz', '4Gb', 'DDR', '128Gb', 'Samsung', '03BB701026201211280015C6', 'Donated - ex school', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by Grafton High', 'C-002', 1),
(10, 'Lenovo Thinkpad X131e', 'Celeron 887', '1.5Ghz', '4Gb', 'DDR', '128Gb', 'Samsung', '03BB70102620121128006997', 'Donated by Grafton High School', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by Grafton High', 'C-004', 1),
(11, 'Lenovo Thinkpad X130e', 'Celeron 857', '1.2Ghz', '4Gb', 'DDR', '320Gb', 'Hitachi', 'LR-9BLHN', 'Donated by South Grafton High School', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by South Grafton High', 'C-009', 0),
(12, 'Lenovo Thinkpad X130e', 'Celeron 857', '1.2Ghz', '4Gb', 'DDR', '320Gb', 'Hitachi', 'LR-9BHPC', 'Donated by South Grafton High', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by South Grafton High', 'C-010', 0),
(13, 'Lenovo Thinkpad X130e', 'Celeron 857', '1.2GHz', '4Gb', 'DDR', '320Gb', 'Hitachi', 'LR-9BKZD', 'Donated', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by South Grafton High', 'C-008', 0),
(14, 'Lenovo Thinkpad X131e', 'Celeron 857', '1.2', '4Gb', 'DDR', '128Gb', 'Light-On', 'PB-90FX7', 'Donated', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by Grafton High', 'C-007', 1),
(15, 'Lenovo Thinkpad X131e', 'Celeron 857', '1.5GHz', '4Gb', 'DDR', '128Gb', 'Light-On', '03BB70102620121128006DE7', 'Donated', 'Ubuntu Linux 20.04 LTS', 0, 1, 'Donated by Grafton High', 'C-003', 1),
(16, 'Lenovo Thinkpad X131e', 'Celeron 887', '1.2GHz', '4Gb', 'DDR', '128Gb', 'Samsung', '03BB70102620121128006CAD', 'Donated by Grafton High', 'Ubuntu Linux 20.04', 0, 1, NULL, 'C-005', 1),
(17, 'Lenovo IdeaPad S145-14AST', 'AMD A6-9225', '2.6GHz', '4Gb', 'DDR4', '128Gb', NULL, 'PF25MA35', 'Harvey Norman Grafton', 'Windows 10 Home', 0, 1, 'Purchased with government grant', 'C-011', 1),
(18, 'Lenovo IdeaPad S145-14AST', 'AMD A6-9225', '2.6GHz', '4Gb', 'DDR4', '128Gb', NULL, 'PF1W63BD', 'Harvey Norman Grafton', 'Windows 10 Home', 0, 1, 'Purchased with government grant', 'C-012', 1),
(19, 'Lenovo IdeaPad S145-14AST', 'AMD A6-9225', '2.6GHz', '4Gb', 'DDR4', '128Gb', NULL, 'PF25MA3H', 'Harvey Norman Grafton', 'Windows 10 Home', 0, 1, 'Purchased using government grant', 'C-013', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Expectations`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Expectations`;
CREATE TABLE IF NOT EXISTS `Expectations` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MemberId` int NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Type` int NOT NULL,
  `MemberModelId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Expectations_MemberModelId` (`MemberModelId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Expectations`:
--   `MemberModelId`
--       `Members` -> `Id`
--

-- --------------------------------------------------------

--
-- Table structure for table `Issues`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Issues`;
CREATE TABLE IF NOT EXISTS `Issues` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MemberId` int NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `MemberModelId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Issues_MemberModelId` (`MemberModelId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Issues`:
--   `MemberModelId`
--       `Members` -> `Id`
--

-- --------------------------------------------------------

--
-- Table structure for table `Members`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Members`;
CREATE TABLE IF NOT EXISTS `Members` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DateOfBirth` datetime(6) NOT NULL,
  `DateEnrolled` datetime(6) NOT NULL,
  `PhotoPath` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `BookedSession` int NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `IsCadet` tinyint(1) NOT NULL,
  `Notes` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Members`:
--

--
-- Dumping data for table `Members`
--

INSERT INTO `Members` (`Id`, `FirstName`, `LastName`, `DateOfBirth`, `DateEnrolled`, `PhotoPath`, `BookedSession`, `IsActive`, `IsCadet`, `Notes`) VALUES
(1, 'Jon', 'Snow', '1970-08-10 00:00:00.000000', '2020-01-01 00:00:00.000000', 'JohnSnow.jpg', 1, 1, 1, NULL),
(2, 'Cercie', 'Lannister', '1988-07-22 00:00:00.000000', '2020-06-06 00:00:00.000000', NULL, 2, 1, 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `Orders`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Orders`;
CREATE TABLE IF NOT EXISTS `Orders` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ItemDescription` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Supplier` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SupplierPartNo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ArrivalDate` datetime(6) DEFAULT NULL,
  `OrderDate` datetime(6) DEFAULT NULL,
  `RequestedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PricePerUnit` decimal(65,30) NOT NULL,
  `QuantityRequested` int NOT NULL,
  `RequestDate` datetime(6) NOT NULL,
  `OrderedBy` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Orders`:
--

--
-- Dumping data for table `Orders`
--

INSERT INTO `Orders` (`Id`, `ItemDescription`, `Supplier`, `SupplierPartNo`, `ArrivalDate`, `OrderDate`, `RequestedBy`, `PricePerUnit`, `QuantityRequested`, `RequestDate`, `OrderedBy`) VALUES
(1, 'Test Item', 'TheLAB', 'TEST1', NULL, NULL, NULL, '15.000000000000000000000000000000', 1, '2020-03-14 00:00:00.000000', NULL),
(2, 'Test2', 'test2', 't2', NULL, NULL, NULL, '10.500000000000000000000000000000', 2, '2020-03-14 00:00:00.000000', NULL),
(3, 'Test3', 'test3', 'test3', NULL, '2020-03-14 00:00:00.000000', NULL, '5.000000000000000000000000000000', 1, '2020-03-14 00:00:00.000000', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `Parts`
--
-- Creation: Aug 11, 2020 at 12:39 AM
--

DROP TABLE IF EXISTS `Parts`;
CREATE TABLE IF NOT EXISTS `Parts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Description` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Brand` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Capacity` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Type` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- RELATIONSHIPS FOR TABLE `Parts`:
--

--
-- Dumping data for table `Parts`
--

INSERT INTO `Parts` (`Id`, `Description`, `Brand`, `Capacity`, `Type`) VALUES
(1, 'WD Caviar Blue 3.5\" HDD', 'Western Digital', '500GB', 2),
(2, 'SATA 3.5\" HDD', 'Samsung', '500Gb', 2),
(3, 'Seagate Barracuda SATA 3.5\" HDD', 'Seagate', '320GB', 2),
(4, 'Seagate Barracuda 3.5\" SATA HDD', 'Seagate', '250GB', 2),
(5, 'Western Digital Caviar Blue 3.5\" SATA HDD', 'Western Digital', '320GB', 2),
(6, 'Western Digital 3.5\" SATA HDD', 'Western Digital', '250GB', 2),
(7, 'Western Digital Blue 3.5\" SATA HDD', 'Western Digital', '500GB', 2),
(8, 'Seagate Barracuda 3.5\" SATA HDD', 'Seagate', '500GB', 2),
(9, 'Seagate Barracuda 3.5\" SATA HDD', 'Seagate', '500GB', 2),
(10, '2.5\" SATA 5400RPM HDD.', 'Hitachi', '500GB', 2),
(12, '2.5\" SATA HDD', 'Hitachi', '250GB', 2),
(13, '2.5\" SATA HDD', 'Fujitsu', '160GB', 2),
(14, 'Seagate Momentus 2.5\" SATA HDD', 'Seagate, Samsung, Spinpoint', '750GB', 2);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Expectations`
--
ALTER TABLE `Expectations`
  ADD CONSTRAINT `FK_Expectations_Members_MemberModelId` FOREIGN KEY (`MemberModelId`) REFERENCES `Members` (`Id`) ON DELETE RESTRICT;

--
-- Constraints for table `Issues`
--
ALTER TABLE `Issues`
  ADD CONSTRAINT `FK_Issues_Members_MemberModelId` FOREIGN KEY (`MemberModelId`) REFERENCES `Members` (`Id`) ON DELETE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
