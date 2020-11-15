-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Nov 15, 2020 at 02:19 AM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `id15158086_edume`
--

-- --------------------------------------------------------

--
-- Table structure for table `hints`
--

CREATE TABLE `hints` (
  `hint_id` int(11) NOT NULL,
  `hint_desc` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `levels`
--

CREATE TABLE `levels` (
  `level_id` int(11) NOT NULL,
  `level_name` varchar(15) NOT NULL,
  `level_desc` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `levels`
--

INSERT INTO `levels` (`level_id`, `level_name`, `level_desc`) VALUES
(1, 'Level 1', 'Simple. Player should collect 1000 score to unlock next level.'),
(2, 'Level 2', 'Intermediate. Player should collect 2000 score to unlock next level.'),
(3, 'Level 3', 'Hard. Player should collect 3000 score to unlock next level.'),
(4, 'Level 4', 'Final and Hardest level. Player should collect 4000 score to win this level.');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `login_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `username` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`login_id`, `player_id`, `username`) VALUES
(83, 85, 'hasini'),
(84, 86, 'malki'),
(85, 87, 'ravindu'),
(86, 88, 'sithara'),
(87, 89, 'kosala'),
(96, 98, 'hiruni'),
(97, 99, 'amal');

-- --------------------------------------------------------

--
-- Table structure for table `players`
--

CREATE TABLE `players` (
  `id` int(10) NOT NULL,
  `username` varchar(15) NOT NULL,
  `age` int(11) DEFAULT NULL,
  `health` int(11) NOT NULL DEFAULT 3,
  `health2` int(11) NOT NULL DEFAULT 3,
  `time` float NOT NULL DEFAULT 3600,
  `time1` float NOT NULL DEFAULT 4500,
  `x_pos1` int(100) NOT NULL DEFAULT 0,
  `y_pos1` int(100) NOT NULL DEFAULT 0,
  `z_pos1` int(100) NOT NULL DEFAULT 0,
  `x_pos2` int(100) NOT NULL DEFAULT 0,
  `y_pos2` int(100) NOT NULL DEFAULT 0,
  `z_pos2` int(100) NOT NULL DEFAULT 0,
  `level_id` int(11) NOT NULL DEFAULT 1,
  `the_level` int(11) NOT NULL DEFAULT 1,
  `additionright` int(11) NOT NULL DEFAULT 0,
  `substractionright` int(11) NOT NULL DEFAULT 0,
  `multiplicationright` int(11) NOT NULL DEFAULT 0,
  `divisionright` int(11) NOT NULL DEFAULT 0,
  `additionwrong` int(11) NOT NULL DEFAULT 0,
  `substractionwrong` int(11) NOT NULL DEFAULT 0,
  `multiplicationwrong` int(11) NOT NULL DEFAULT 0,
  `divisionwrong` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `players`
--

INSERT INTO `players` (`id`, `username`, `age`, `health`, `health2`, `time`, `time1`, `x_pos1`, `y_pos1`, `z_pos1`, `x_pos2`, `y_pos2`, `z_pos2`, `level_id`, `the_level`, `additionright`, `substractionright`, `multiplicationright`, `divisionright`, `additionwrong`, `substractionwrong`, `multiplicationwrong`, `divisionwrong`) VALUES
(85, 'hasini', 10, 3, 3, 2000, 4368.17, 103, 6, 0, 0, 0, 0, 2, 2, 8, 6, 3, 4, 2, 4, 7, 8),
(86, 'malki', 9, 3, 3, 3500, 4400, 0, 0, 0, 0, 0, 0, 1, 1, 3, 7, 5, 2, 7, 5, 8, 3),
(87, 'ravindu', 10, 3, 3, 3300, 4000, 0, 0, 0, 0, 0, 0, 1, 1, 3, 2, 8, 6, 7, 8, 2, 4),
(88, 'sithara', 10, 3, 3, 3600, 4500, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0),
(89, 'kosala', 10, 3, 3, 3600, 4500, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(98, 'hiruni', 10, 3, 3, 3600, 4500, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(99, 'amal', 9, 3, 3, 3600, 4500, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `score_board`
--

CREATE TABLE `score_board` (
  `score_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `score` int(100) NOT NULL DEFAULT 0,
  `coins` int(100) NOT NULL DEFAULT 0,
  `diamands` int(100) NOT NULL DEFAULT 0,
  `coins2` int(100) NOT NULL DEFAULT 0,
  `diamands2` int(100) NOT NULL DEFAULT 0,
  `stars2` int(100) NOT NULL DEFAULT 0,
  `score1` int(100) NOT NULL DEFAULT 0,
  `score2` int(100) NOT NULL DEFAULT 0,
  `score3` int(100) NOT NULL DEFAULT 0,
  `score4` int(100) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `score_board`
--

INSERT INTO `score_board` (`score_id`, `player_id`, `score`, `coins`, `diamands`, `coins2`, `diamands2`, `stars2`, `score1`, `score2`, `score3`, `score4`) VALUES
(73, 85, 1715, 79, 39, 41, 1, 1, 1490, 215, 0, 0),
(74, 86, 2000, 70, 30, 20, 5, 3, 1500, 500, 0, 0),
(75, 87, 1500, 60, 2, 20, 2, 1, 300, 300, 0, 0),
(76, 88, 500, 60, 5, 6, 0, 0, 500, 0, 0, 0),
(77, 89, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(86, 98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(87, 99, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `Teacher`
--

CREATE TABLE `Teacher` (
  `teacher_id` int(11) NOT NULL,
  `name` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `hash` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `salt` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Teacher`
--

INSERT INTO `Teacher` (`teacher_id`, `name`, `hash`, `salt`) VALUES
(1, 'teacher', '$5$rounds=5000$steamedhamsteach$y/Hy6ASdL1S.pRHBJ2JShEvF7XmSdT12l/Bh.9gDuP2', '$5$rounds=5000$steamedhamsteacher$'),
(9, 'tea03', '$5$rounds=5000$steamedhamstea03$jVf1xclXM74czZ3V96b95JHYUIpD3ub7U7ugH49uNsC', '$5$rounds=5000$steamedhamstea03$');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `hints`
--
ALTER TABLE `hints`
  ADD PRIMARY KEY (`hint_id`);

--
-- Indexes for table `levels`
--
ALTER TABLE `levels`
  ADD PRIMARY KEY (`level_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`login_id`),
  ADD KEY `test2` (`player_id`);

--
-- Indexes for table `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `score_board`
--
ALTER TABLE `score_board`
  ADD PRIMARY KEY (`score_id`),
  ADD KEY `test` (`player_id`);

--
-- Indexes for table `Teacher`
--
ALTER TABLE `Teacher`
  ADD PRIMARY KEY (`teacher_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hints`
--
ALTER TABLE `hints`
  MODIFY `hint_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `levels`
--
ALTER TABLE `levels`
  MODIFY `level_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT for table `players`
--
ALTER TABLE `players`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;

--
-- AUTO_INCREMENT for table `score_board`
--
ALTER TABLE `score_board`
  MODIFY `score_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT for table `Teacher`
--
ALTER TABLE `Teacher`
  MODIFY `teacher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `test2` FOREIGN KEY (`player_id`) REFERENCES `players` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `score_board`
--
ALTER TABLE `score_board`
  ADD CONSTRAINT `test` FOREIGN KEY (`player_id`) REFERENCES `players` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
