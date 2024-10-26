-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: clinic_tooth
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `idaccount` int NOT NULL AUTO_INCREMENT,
  `first` varchar(45) DEFAULT NULL,
  `middle` varchar(45) DEFAULT NULL,
  `last` varchar(45) DEFAULT NULL,
  `extension` varchar(45) DEFAULT NULL,
  `sex` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `number` varchar(45) DEFAULT NULL,
  `bday` date DEFAULT NULL,
  `province` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `baranggay` varchar(45) DEFAULT NULL,
  `house` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(65) DEFAULT NULL,
  `doctorMode` varchar(65) DEFAULT NULL,
  `accountPic` mediumblob,
  `about` longtext,
  PRIMARY KEY (`idaccount`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  UNIQUE KEY `doctorMode_UNIQUE` (`doctorMode`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment` (
  `appointment_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int DEFAULT NULL,
  `dentist_id` int DEFAULT NULL,
  `patients` varchar(45) DEFAULT NULL,
  `doctor` varchar(45) DEFAULT NULL,
  `operation` mediumtext,
  `appointment_date` date DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `active` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`appointment_id`),
  KEY `id_key_idx` (`patient_id`),
  KEY `id_dentist_idx` (`dentist_id`),
  CONSTRAINT `id_dentist` FOREIGN KEY (`dentist_id`) REFERENCES `account` (`idaccount`),
  CONSTRAINT `id_key` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`idpatients`)
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patients` (
  `idpatients` int NOT NULL AUTO_INCREMENT,
  `first_name_patients` varchar(45) DEFAULT NULL,
  `middle_name_patients` varchar(45) DEFAULT NULL,
  `last_name_patients` varchar(45) DEFAULT NULL,
  `extension` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `sex_patients` varchar(45) DEFAULT NULL,
  `birthdate_patients` date DEFAULT NULL,
  `contact_number_patients` varchar(45) DEFAULT NULL,
  `patients_image` mediumblob,
  `date_registered` date DEFAULT NULL,
  `province` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `baranggay` varchar(45) DEFAULT NULL,
  `house_number` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idpatients`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `treatment`
--

DROP TABLE IF EXISTS `treatment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treatment` (
  `idtreatment` int NOT NULL AUTO_INCREMENT,
  `idpatients` int DEFAULT NULL,
  `workdone1` varchar(45) DEFAULT NULL,
  `workdone2` varchar(45) DEFAULT NULL,
  `workdone3` varchar(45) DEFAULT NULL,
  `doctor` varchar(45) DEFAULT NULL,
  `date_of_treatment` date DEFAULT NULL,
  `prescriptions` varchar(45) DEFAULT NULL,
  `price` decimal(10,0) DEFAULT NULL,
  `teeth11_label` varchar(45) DEFAULT NULL,
  `teeth12_label` varchar(45) DEFAULT NULL,
  `teeth13_label` varchar(45) DEFAULT NULL,
  `teeth14_label` varchar(45) DEFAULT NULL,
  `teeth15_label` varchar(45) DEFAULT NULL,
  `teeth16_label` varchar(45) DEFAULT NULL,
  `teeth17_label` varchar(45) DEFAULT NULL,
  `teeth18_label` varchar(45) DEFAULT NULL,
  `teeth21_label` varchar(45) DEFAULT NULL,
  `teeth22_label` varchar(45) DEFAULT NULL,
  `teeth23_label` varchar(45) DEFAULT NULL,
  `teeth24_label` varchar(45) DEFAULT NULL,
  `teeth25_label` varchar(45) DEFAULT NULL,
  `teeth26_label` varchar(45) DEFAULT NULL,
  `teeth27_label` varchar(45) DEFAULT NULL,
  `teeth28_label` varchar(45) DEFAULT NULL,
  `teeth31_label` varchar(45) DEFAULT NULL,
  `teeth32_label` varchar(45) DEFAULT NULL,
  `teeth33_label` varchar(45) DEFAULT NULL,
  `teeth34_label` varchar(45) DEFAULT NULL,
  `teeth35_label` varchar(45) DEFAULT NULL,
  `teeth36_label` varchar(45) DEFAULT NULL,
  `teeth37_label` varchar(45) DEFAULT NULL,
  `teeth38_label` varchar(45) DEFAULT NULL,
  `teeth41_label` varchar(45) DEFAULT NULL,
  `teeth42_label` varchar(45) DEFAULT NULL,
  `teeth43_label` varchar(45) DEFAULT NULL,
  `teeth44_label` varchar(45) DEFAULT NULL,
  `teeth45_label` varchar(45) DEFAULT NULL,
  `teeth46_label` varchar(45) DEFAULT NULL,
  `teeth47_label` varchar(45) DEFAULT NULL,
  `teeth48_label` varchar(45) DEFAULT NULL,
  `teeth_type` varchar(45) DEFAULT NULL,
  `workCategory` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtreatment`),
  KEY `idpatient_idx` (`idpatients`),
  CONSTRAINT `idpatient` FOREIGN KEY (`idpatients`) REFERENCES `patients` (`idpatients`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-28 21:08:13
