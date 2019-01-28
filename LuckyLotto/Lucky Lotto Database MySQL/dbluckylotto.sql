CREATE DATABASE  IF NOT EXISTS `dbluckylotto` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dbluckylotto`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: dbluckylotto
-- ------------------------------------------------------
-- Server version	5.5.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbluser` (
  `userid` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) DEFAULT NULL,
  `Password` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`userid`),
  UNIQUE KEY `username_UNIQUE` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbluser`
--

LOCK TABLES `tbluser` WRITE;
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` VALUES (1,'KENTH','KENTH'),(4,'TEST','TEST');
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblluckypick`
--

DROP TABLE IF EXISTS `tblluckypick`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblluckypick` (
  `luckypickid` int(11) NOT NULL AUTO_INCREMENT,
  `1stNumber` int(2) DEFAULT NULL,
  `2ndNumber` int(2) DEFAULT NULL,
  `3rdNumber` int(2) DEFAULT NULL,
  `4thNumber` int(2) DEFAULT NULL,
  `5thNumber` int(2) DEFAULT NULL,
  `6thNumber` int(2) DEFAULT NULL,
  `LottoType` varchar(45) DEFAULT NULL,
  `DateAndTime` datetime DEFAULT NULL,
  `LPUsername` varchar(45) DEFAULT NULL,
  `AutoPredictLottoDrawDate` datetime DEFAULT NULL,
  PRIMARY KEY (`luckypickid`),
  KEY `Username` (`LPUsername`),
  CONSTRAINT `Username` FOREIGN KEY (`LPUsername`) REFERENCES `tbluser` (`Username`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblluckypick`
--

LOCK TABLES `tblluckypick` WRITE;
/*!40000 ALTER TABLE `tblluckypick` DISABLE KEYS */;
INSERT INTO `tblluckypick` VALUES (1,38,55,37,41,49,45,'6/58','2018-10-09 03:39:13','KENTH','2019-01-15 00:00:00'),(2,55,38,37,49,41,45,'6/58','2018-10-12 04:03:31','TEST','2019-01-15 00:00:00'),(3,13,39,47,31,48,8,'6/58','2018-10-14 12:14:31','TEST','2019-01-18 00:00:00'),(4,2,9,23,30,29,38,'6/55','2019-01-28 08:14:15','KENTH','2019-01-18 00:00:00'),(5,4,31,29,39,1,30,'6/55','2019-01-28 01:28:01','KENTH','0001-01-01 00:00:00'),(6,23,54,47,39,48,7,'6/58','2019-01-28 01:30:43','KENTH','2019-01-28 00:00:00'),(7,27,48,57,50,51,46,'6/58','2019-01-28 01:36:09','KENTH','2019-01-29 00:00:00'),(8,48,27,57,46,50,51,'6/58','2019-01-28 01:38:52','TEST','2019-01-29 00:00:00'),(9,49,32,30,28,3,2,'6/49','2019-01-28 01:55:53','TEST','2019-01-29 00:00:00'),(10,4,2,25,20,36,3,'6/49','2019-01-28 01:59:34','TEST','2019-01-29 00:00:00');
/*!40000 ALTER TABLE `tblluckypick` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblwinner`
--

DROP TABLE IF EXISTS `tblwinner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblwinner` (
  `winnerid` int(11) NOT NULL AUTO_INCREMENT,
  `luckypickwinnerid` int(11) DEFAULT NULL,
  `lresultunique` varchar(100) DEFAULT NULL,
  `MessageStatus` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`winnerid`),
  KEY `luckywinnerid` (`luckypickwinnerid`),
  CONSTRAINT `luckywinnerid` FOREIGN KEY (`luckypickwinnerid`) REFERENCES `tblluckypick` (`luckypickid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblwinner`
--

LOCK TABLES `tblwinner` WRITE;
/*!40000 ALTER TABLE `tblwinner` DISABLE KEYS */;
INSERT INTO `tblwinner` VALUES (3,7,'7-2019/01/29-6/58','Read'),(4,8,'8-2019/01/29-6/58','Read');
/*!40000 ALTER TABLE `tblwinner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbllottoresult`
--

DROP TABLE IF EXISTS `tbllottoresult`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllottoresult` (
  `lottoresultid` int(11) NOT NULL AUTO_INCREMENT,
  `LottoTypeResult` varchar(45) DEFAULT NULL,
  `DateLottoDraw` datetime DEFAULT NULL,
  `DateAndTimeAdded` datetime DEFAULT NULL,
  `1stNumberResult` int(2) DEFAULT NULL,
  `2ndNumberResult` int(2) DEFAULT NULL,
  `3rdNumberResult` int(2) DEFAULT NULL,
  `4thNumberResult` int(2) DEFAULT NULL,
  `5thNumberResult` int(2) DEFAULT NULL,
  `6thNumberResult` int(2) DEFAULT NULL,
  `JackpotPrice` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`lottoresultid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbllottoresult`
--

LOCK TABLES `tbllottoresult` WRITE;
/*!40000 ALTER TABLE `tbllottoresult` DISABLE KEYS */;
INSERT INTO `tbllottoresult` VALUES (2,'6/49','2019-01-15 00:00:00','2019-01-27 10:58:58',43,25,18,12,19,10,'9,999,999'),(4,'6/58','2019-01-29 00:00:00','2019-01-28 02:09:25',27,48,46,50,51,57,'1,000,000'),(5,'6/58','2019-01-25 00:00:00','2019-01-28 04:06:37',27,46,48,50,51,57,'2,000,000');
/*!40000 ALTER TABLE `tbllottoresult` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-28 18:12:45
