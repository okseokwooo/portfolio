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
-- Table structure for table `team_vs_lotte`
--

DROP TABLE IF EXISTS `team_vs_lotte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `team_vs_lotte` (
  `ranking` int NOT NULL,
  `team_name` varchar(45) DEFAULT NULL,
  `play` int DEFAULT NULL,
  `win` int DEFAULT NULL,
  `draw` int DEFAULT NULL,
  `lose` int DEFAULT NULL,
  `win_per` double DEFAULT NULL,
  `rate_per_game` double DEFAULT NULL,
  `k_per` double DEFAULT NULL,
  `babip` double DEFAULT NULL,
  `hit_rate` double DEFAULT NULL,
  `ops` double DEFAULT NULL,
  `woba` double DEFAULT NULL,
  `wraa` double DEFAULT NULL,
  `wrc` double DEFAULT NULL,
  `era` double DEFAULT NULL,
  `ra9_war` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team_vs_lotte`
--

LOCK TABLES `team_vs_lotte` WRITE;
/*!40000 ALTER TABLE `team_vs_lotte` DISABLE KEYS */;
INSERT INTO `team_vs_lotte` VALUES (1,'NC',16,10,0,6,0.625,6.75,18.4,0.373,0.318,0.849,0.375,17.22,103.05,4.6,2.93),(1,'KIA',16,10,0,6,0.625,4.94,18,0.322,0.279,0.764,0.343,-2.21,76.42,4.68,3.65),(3,'두산',16,9,1,6,0.6,5.25,14.4,0.323,0.293,0.792,0.353,3.4,83.57,3.68,3.76),(4,'삼성',16,8,0,8,0.5,5,17.2,0.296,0.261,0.728,0.326,-11.89,67.9,4.4,3.48),(4,'SSG',16,8,0,8,0.5,4.44,18.1,0.277,0.249,0.703,0.312,-18.78,57.03,4.96,1.92),(4,'Hero',16,8,0,8,0.5,5,19.6,0.287,0.244,0.732,0.328,-10.65,69.53,4.18,3.51),(7,'LG',16,7,0,9,0.438,5.19,18,0.32,0.277,0.735,0.327,-10.84,67.16,4.82,2.24),(7,'KT',16,7,0,9,0.438,5.12,18,0.294,0.262,0.751,0.333,-7.57,70.81,5.71,2.19),(9,'한화',16,5,0,11,0.313,3.31,19.8,0.301,0.249,0.665,0.303,-25.12,55.44,6.15,0.88);
/*!40000 ALTER TABLE `team_vs_lotte` ENABLE KEYS */;
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
