-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 20, 2017 at 04:18 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `yurt_otomasyonu`
--

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `delete_personal`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_personal` (IN `ID` INT)  NO SQL
DELETE FROM personal WHERE personal_id =ID$$

DROP PROCEDURE IF EXISTS `delete_salary`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_salary` (IN `ID` INT)  NO SQL
DELETE FROM salary WHERE personal_id =ID$$

DROP PROCEDURE IF EXISTS `delete_student`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_student` (IN `ID` INT)  NO SQL
DELETE FROM student WHERE student_id =ID$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `archive`
--

DROP TABLE IF EXISTS `archive`;
CREATE TABLE IF NOT EXISTS `archive` (
  `archive_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  `surname` varchar(20) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL,
  `type` varchar(20) NOT NULL,
  `proccess` varchar(20) NOT NULL,
  PRIMARY KEY (`archive_id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `archive`
--

INSERT INTO `archive` (`archive_id`, `name`, `surname`, `tel`, `type`, `proccess`) VALUES
(1, 'Ahmet', 'Koç', '5348779924', 'STUDENT', 'INSERT'),
(2, 'omar ', 'kaya ', '05478354411', 'STUDENT', 'INSERT'),
(3, 'Mert', 'Dogan', '0532784527', 'PERSONAL', 'INSERT'),
(4, 'Ahmet', 'Koç', '5348779924', 'STUDENT', 'EDIT'),
(5, 'omar ', 'kaya ', '05478354411', 'STUDENT', 'EDIT'),
(6, 'Yasin', 'korkmaz', '05379251473', 'PERSONAL', 'INSERT'),
(7, 'Omar', 'korkmaz', '05379251473', 'PERSONAL', 'INSERT'),
(8, 'Omar', 'korkmaz', '05379251473', 'PERSONAL', 'DELETE'),
(9, 'Yasin', 'korkmaz', '05379251473', 'PERSONAL', 'DELETE'),
(10, 'Adnan', 'Mehrat', '', 'PERSONAL', 'INSERT'),
(11, 'Adnan', 'Mehrat', '', 'PERSONAL', 'UPDATE'),
(12, 'Adnan', 'Mehrat', '0524871314', 'PERSONAL', 'UPDATE'),
(13, 'Hussam', 'Aliwi', '', 'STUDENT', 'INSERT'),
(14, 'Eyad', 'Toma', '', 'STUDENT', 'INSERT'),
(15, 'Ziya', 'Ghazal', '', 'STUDENT', 'INSERT'),
(16, 'Ziya', 'Ghazal', '', 'STUDENT', 'EDIT'),
(17, 'Adnan', 'Mehrat', '', 'STUDENT', 'INSERT'),
(18, 'Mohamed', 'Aliwi', '', 'PERSONAL', 'INSERT'),
(19, 'Mohamed', 'Aliwi', '', 'PERSONAL', 'UPDATE'),
(20, 'Adnan', 'Mehrat', '0524871314', 'PERSONAL', 'UPDATE'),
(21, 'Adnan', 'Mehrat', '0524871314', 'PERSONAL', 'UPDATE'),
(22, 'Mohamed', 'Aliwi', '', 'PERSONAL', 'UPDATE'),
(23, 'Omar', 'Taha', '', 'PERSONAL', 'INSERT'),
(24, 'Mert', 'Dogan', '0532784527', 'PERSONAL', 'UPDATE'),
(25, 'Adnan', 'Mehrat', '0524871314', 'PERSONAL', 'UPDATE');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
CREATE TABLE IF NOT EXISTS `department` (
  `dep_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` char(40) NOT NULL,
  PRIMARY KEY (`dep_id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`dep_id`, `name`) VALUES
(1, 'Bil Muh.'),
(2, 'Insaat Muh'),
(3, 'Kimya'),
(5, 'Statistic'),
(4, 'TIP');

-- --------------------------------------------------------

--
-- Table structure for table `fees`
--

DROP TABLE IF EXISTS `fees`;
CREATE TABLE IF NOT EXISTS `fees` (
  `fees_id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '4000',
  `date` datetime NOT NULL,
  `paid` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`fees_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fees`
--

INSERT INTO `fees` (`fees_id`, `student_id`, `amount`, `date`, `paid`) VALUES
(1, 14060850, 4000, '2017-12-16 00:00:00', 0),
(2, 14060851, 4000, '2017-12-16 00:00:00', 0),
(3, 14060850, 4000, '2017-12-16 00:00:00', 1500),
(4, 14060850, 4000, '2017-12-16 00:00:00', 500),
(5, 14060852, 4000, '2017-12-16 00:00:00', 0),
(6, 14060853, 4000, '2017-12-17 00:00:00', 0),
(7, 14060853, 4000, '2017-12-17 00:00:00', 1000),
(8, 14060854, 4000, '2017-12-17 00:00:00', 0),
(9, 14060855, 4000, '2017-12-17 00:00:00', 0),
(10, 14060854, 4000, '2017-12-17 00:00:00', 520);

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

DROP TABLE IF EXISTS `job`;
CREATE TABLE IF NOT EXISTS `job` (
  `job_id` int(11) NOT NULL AUTO_INCREMENT,
  `position` varchar(40) NOT NULL,
  PRIMARY KEY (`job_id`),
  KEY `job_id` (`job_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`job_id`, `position`) VALUES
(1, 'System Administrator'),
(2, 'Data Entry'),
(5, 'Block Manager'),
(6, 'Manager'),
(8, 'Cleaner'),
(9, 'Student Manager'),
(10, 'Danisman'),
(12, 'muhendis');

-- --------------------------------------------------------

--
-- Table structure for table `personal`
--

DROP TABLE IF EXISTS `personal`;
CREATE TABLE IF NOT EXISTS `personal` (
  `personal_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `tc` varchar(11) NOT NULL,
  `address` varchar(100) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL,
  `user` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `start_date` date NOT NULL,
  `finish_date` date DEFAULT NULL,
  `job_id` int(11) NOT NULL,
  `admin` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`personal_id`),
  UNIQUE KEY `user` (`user`),
  UNIQUE KEY `tc` (`tc`),
  KEY `personal_id` (`personal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `personal`
--

INSERT INTO `personal` (`personal_id`, `name`, `surname`, `tc`, `address`, `email`, `tel`, `user`, `pass`, `start_date`, `finish_date`, `job_id`, `admin`) VALUES
(1, 'admin', 'admin', '00000000000', '', '', '', 'admin', 'admin', '2017-01-01', NULL, 1, 1),
(2, 'Mert', 'Dogan', '32104765218', 'Samsun Korfez no 3', 'mertdogan', '0532784527', 'mert', 'mert', '2017-12-16', '2017-12-18', 2, 0),
(3, 'Adnan', 'Mehrat', '99988855541', 'Samsun - korfez', 'adnan@demir', '0524871314', 'Adnan', 'Adnan', '2017-12-16', NULL, 2, 0),
(4, 'Mohamed', 'Aliwi', '99956227456', '', '', '', 'aliwimo', '12345', '2017-12-17', NULL, 1, 1),
(5, 'Omar', 'Taha', '55544411122', '', '', '', 'OmarTaha', 'OmarTaha', '2017-12-17', NULL, 8, 1);

--
-- Triggers `personal`
--
DROP TRIGGER IF EXISTS `after_delete_personal`;
DELIMITER $$
CREATE TRIGGER `after_delete_personal` BEFORE DELETE ON `personal` FOR EACH ROW INSERT INTO archive(name,surname,tel,type,proccess) VALUES (OLD.name,OLD.surname,OLD.tel,'PERSONAL','DELETE')
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `after_insert_personal`;
DELIMITER $$
CREATE TRIGGER `after_insert_personal` AFTER INSERT ON `personal` FOR EACH ROW INSERT INTO archive(name,surname,tel,type,proccess) VALUES (NEW.name,NEW.surname,NEW.tel,'PERSONAL','INSERT')
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `after_update_personal`;
DELIMITER $$
CREATE TRIGGER `after_update_personal` AFTER UPDATE ON `personal` FOR EACH ROW INSERT INTO archive(name,surname,tel,type,proccess) VALUES (OLD.name,OLD.surname,OLD.tel,'PERSONAL','UPDATE')
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `delete_salary`;
DELIMITER $$
CREATE TRIGGER `delete_salary` BEFORE DELETE ON `personal` FOR EACH ROW DELETE FROM salary WHERE personal_id = OLD.personal_id
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
CREATE TABLE IF NOT EXISTS `room` (
  `room_id` int(11) NOT NULL AUTO_INCREMENT,
  `capacity` int(11) NOT NULL,
  PRIMARY KEY (`room_id`),
  KEY `room_id` (`room_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_id`, `capacity`) VALUES
(1, 3),
(2, 5),
(3, 4),
(4, 3),
(5, 3),
(6, 3);

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

DROP TABLE IF EXISTS `salary`;
CREATE TABLE IF NOT EXISTS `salary` (
  `personal_id` int(11) NOT NULL,
  `job_id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  KEY `personal_id` (`personal_id`),
  KEY `job_id` (`job_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `salary`
--

INSERT INTO `salary` (`personal_id`, `job_id`, `amount`) VALUES
(1, 1, 0),
(4, 1, 300000),
(5, 8, 130000),
(2, 2, 2000),
(3, 2, 120000);

-- --------------------------------------------------------

--
-- Table structure for table `states`
--

DROP TABLE IF EXISTS `states`;
CREATE TABLE IF NOT EXISTS `states` (
  `state_no` int(11) NOT NULL AUTO_INCREMENT,
  `personal` tinyint(1) NOT NULL DEFAULT '0',
  `id` int(11) NOT NULL,
  `state` varchar(11) NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`state_no`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `states`
--

INSERT INTO `states` (`state_no`, `personal`, `id`, `state`, `date`) VALUES
(1, 1, 2, 'in', '2017-12-16 18:31:32'),
(2, 1, 2, 'out', '2017-12-16 18:31:41'),
(3, 0, 14060851, 'in', '2017-12-16 18:33:46'),
(4, 0, 14060851, 'out', '2017-12-16 18:33:53'),
(5, 1, 3, 'out', '2017-12-16 19:03:33'),
(6, 1, 3, 'in', '2017-12-16 19:03:48'),
(7, 0, 14060853, 'in', '2017-12-17 00:12:54'),
(8, 0, 14060853, 'out', '2017-12-17 00:13:08'),
(9, 0, 14060854, 'in', '2017-12-17 22:49:14'),
(10, 0, 14060854, 'out', '2017-12-17 22:49:35');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `student_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  `surname` varchar(30) NOT NULL,
  `tc` varchar(11) NOT NULL,
  `address` varchar(100) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL,
  `reg_date` date NOT NULL,
  `class` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `dep_id` int(11) NOT NULL,
  PRIMARY KEY (`student_id`),
  UNIQUE KEY `tc` (`tc`)
) ENGINE=InnoDB AUTO_INCREMENT=14060856 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_id`, `name`, `surname`, `tc`, `address`, `email`, `tel`, `reg_date`, `class`, `room_id`, `dep_id`) VALUES
(14060850, 'Ahmet', 'Koç', '51475862471', 'Samsun Korfez no 1', 'ahmetkoc@yurt.com', '5348779924', '2017-12-16', 3, 1, 2),
(14060851, 'omar ', 'kaya ', '98472361104', 'Samsun Korfez no 2', 'omarkaya@yurt.com', '05478354411', '2017-12-16', 1, 1, 4),
(14060852, 'Hussam', 'Aliwi', '99966652354', '', '', '', '2017-12-12', 3, 1, 3),
(14060853, 'Eyad', 'Toma', '66554477889', '', '', '', '2017-12-17', 4, 3, 5),
(14060854, 'Ziya', 'Ghazal', '99966655112', '', '', '', '2017-12-17', 1, 2, 1),
(14060855, 'Adnan', 'Mehrat', '88855544471', '', '', '', '2017-12-17', 2, 2, 1);

--
-- Triggers `student`
--
DROP TRIGGER IF EXISTS `after_delete_student`;
DELIMITER $$
CREATE TRIGGER `after_delete_student` BEFORE DELETE ON `student` FOR EACH ROW INSERT INTO archive(name,surname,tel,type,proccess) VALUES (OLD.name,OLd.surname,OLD.tel,'STUDENT','DELETE')
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `after_insert_student`;
DELIMITER $$
CREATE TRIGGER `after_insert_student` BEFORE INSERT ON `student` FOR EACH ROW INSERT INTO archive(name,surname,tel,type,proccess) VALUES (NEw.name,NEW.surname,NEw.tel,'STUDENT','INSERT')
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `after_update_student`;
DELIMITER $$
CREATE TRIGGER `after_update_student` AFTER UPDATE ON `student` FOR EACH ROW INSERT INTO archive(name,surname,tel,type,proccess) VALUES (OLD.name,OLD.surname,OLD.tel,'STUDENT','EDIT')
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `payment_for_student`;
DELIMITER $$
CREATE TRIGGER `payment_for_student` AFTER INSERT ON `student` FOR EACH ROW INSERT INTO fees (amount,date,paid,student_id) VALUES (4000,CURRENT_DATE,0,New.student_id)
$$
DELIMITER ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
