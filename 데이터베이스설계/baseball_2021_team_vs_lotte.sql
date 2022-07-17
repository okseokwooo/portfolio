-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: baseball
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `2021_team_vs_lotte`
--

DROP TABLE IF EXISTS `2021_team_vs_lotte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `2021_team_vs_lotte` (
  `rank` int NOT NULL,
  `team_name` varchar(45) DEFAULT NULL,
  `ra9_war` double DEFAULT NULL,
  `era` double DEFAULT NULL,
  `wrc` double DEFAULT NULL,
  `woba` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `2021_team_vs_lotte`
--

LOCK TABLES `2021_team_vs_lotte` WRITE;
/*!40000 ALTER TABLE `2021_team_vs_lotte` DISABLE KEYS */;
INSERT INTO `2021_team_vs_lotte` VALUES (1,'두산',0.214,2.81,7.02,0.338),(2,'KIA',0.296,4.87,6.34,0.359),(2,'NC',0.215,5.13,9.76,0.4),(4,'KT',0.362,6.01,6.16,0.33),(5,'LG',0.241,2.94,5.03,0.319),(6,'삼성',0.333,4.49,5.59,0.343),(7,'키움',0.255,4.43,4.64,0.332),(7,'SSG',0.263,3.07,5.88,0.335),(9,'한화',0.116,2.33,2.86,0.288);
/*!40000 ALTER TABLE `2021_team_vs_lotte` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-11 18:58:41
