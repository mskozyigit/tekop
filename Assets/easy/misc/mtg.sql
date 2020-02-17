-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 21, 2014 at 07:31 AM
-- Server version: 5.5.34
-- PHP Version: 5.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `mtg`
--

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `user` varchar(14) NOT NULL,
  `name` varchar(20) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `Cash` int(11) NOT NULL,
  `email` varchar(20) NOT NULL,
  UNIQUE KEY `pass` (`pass`),
  UNIQUE KEY `user_2` (`user`),
  KEY `pass_2` (`pass`),
  KEY `user` (`user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user`, `name`, `pass`, `Cash`, `email`) VALUES
('prasetyo', '[MTG]prasetyo', '777fed5f4639d91b167be7a2a708070f', 24727, ''),
('endrik', '[MTG]EndrikPrasetyo', 'e12e2cb624be07b648d368ba79d6197b', 13000, '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
