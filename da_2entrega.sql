-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: da_2entrega
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `erabiltzaileak`
--

DROP TABLE IF EXISTS `erabiltzaileak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `erabiltzaileak` (
  `id_erabiltzailea` int NOT NULL AUTO_INCREMENT,
  `abizena2` varchar(20) NOT NULL,
  `izena` varchar(20) NOT NULL,
  `abizena1` varchar(20) NOT NULL,
  `nan` varchar(9) NOT NULL,
  `jaiotza_data` date NOT NULL,
  `posta_elektronikoa` varchar(45) NOT NULL,
  `telefono_zenbakia` varchar(9) NOT NULL,
  `helbidea` longtext NOT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `is_deleted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id_erabiltzailea`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `erabiltzaileak`
--

LOCK TABLES `erabiltzaileak` WRITE;
/*!40000 ALTER TABLE `erabiltzaileak` DISABLE KEYS */;
INSERT INTO `erabiltzaileak` VALUES (1,'Lopez','Aitor','Garcia','12345678A','1990-01-15','aitor.garcia@example.com','600123456','Calle Mayor 1','2025-10-12 18:56:08','2025-10-12 18:56:08',0),(2,'Sanchez','Nerea','Martinez','23456789B','1988-03-22','nerea.martinez1@example.com','600123002','Calle Luna 2','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(3,'Gomez','Jon','Perez','34567890C','1992-05-30','jon.perez1@example.com','600123003','Calle Sol 3','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(4,'Diaz','Amaia','Rodriguez','45678901D','1995-07-18','amaia.rodriguez1@example.com','600123004','Calle Estrella 4','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(5,'Fernandez','Mikel','Lopez','56789012E','1985-09-05','mikel.lopez1@example.com','600123005','Calle Rio 5','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(6,'Martinez','Leire','Gonzalez','67890123F','1993-11-11','leire.gonzalez1@example.com','600123006','Calle Mar 6','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(7,'Garcia','Iker','Sanchez','78901234G','1991-02-28','iker.sanchez1@example.com','600123007','Calle Montaña 7','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(8,'Lopez','Ane','Diaz','89012345H','1989-06-16','ane.diaz1@example.com','600123008','Calle Bosque 8','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(9,'Perez','Asier','Fernandez','90123456J','1994-08-24','asier.fernandez1@example.com','600123009','Calle Prado 9','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(10,'Rodriguez','Irati','Gomez','01234567K','1996-12-03','irati.gomez1@example.com','600123010','Calle Fuente 10','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(11,'Gomez','Hugo','Lopez','11234567L','1990-04-10','hugo.lopez1@example.com','600123011','Calle Loma 11','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(12,'Diaz','Sara','Martinez','12234567M','1992-06-21','sara.martinez1@example.com','600123012','Calle Rio 12','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(13,'Fernandez','Unai','Garcia','13234567N','1987-08-14','unai.garcia1@example.com','600123013','Calle Sol 13','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(14,'Sanchez','Maialen','Rodriguez','14234567P','1993-10-02','maialen.rodriguez1@example.com','600123014','Calle Luna 14','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(15,'Lopez','Xabier','Perez','15234567Q','1991-01-29','xabier.perez1@example.com','600123015','Calle Estrella 15','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(16,'Fernandez','Leioa','Gonzalez','16234567R','1988-03-19','leioa.gonzalez1@example.com','600123016','Calle Mar 16','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(17,'Diaz','Iñigo','Sanchez','17234567S','1995-05-25','inigo.sanchez1@example.com','600123017','Calle Bosque 17','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(18,'Garcia','Elena','Diaz','18234567T','1990-07-31','elena.diaz1@example.com','600123018','Calle Prado 18','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(19,'Martinez','Pablo','Fernandez','19234567U','1992-09-12','pablo.fernandez1@example.com','600123019','Calle Fuente 19','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(20,'Lopez','Naiara','Gomez','20234567V','1989-11-23','naiara.gomez1@example.com','600123020','Calle Loma 20','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(21,'Sanchez','Ander','Lopez','21234567W','1994-02-17','ander.lopez1@example.com','600123021','Calle Rio 21','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(22,'Perez','Irune','Martinez','22234567X','1991-04-08','irune.martinez1@example.com','600123022','Calle Sol 22','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(23,'Rodriguez','Gorka','Garcia','23234567Y','1986-06-19','gorka.garcia1@example.com','600123023','Calle Luna 23','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(24,'Gomez','Leire','Rodriguez','24234567Z','1993-08-28','leire.rodriguez2@example.com','600123024','Calle Estrella 24','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(25,'Fernandez','Aitor','Perez','25234567A','1990-10-14','aitor.perez2@example.com','600123025','Calle Mar 25','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(26,'Diaz','Miren','Gonzalez','26234567B','1992-12-05','miren.gonzalez1@example.com','600123026','Calle Bosque 26','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(27,'Lopez','Iker','Sanchez','27234567C','1988-01-20','iker.sanchez2@example.com','600123027','Calle Prado 27','2025-10-12 18:57:03','2025-10-12 18:57:03',0),(28,'Fernandez','Nahia','Diaz','28234567D','1995-03-15','nahia.diaz1@example.com','600123028','Calle Fuente 28','2025-10-12 18:57:03','2025-10-12 19:57:40',0),(30,'Martinez','Irati','Gomez','30234567F','1993-07-07','irati.gomez2@example.com','600123030','Calle Rio 30','2025-10-12 18:57:03','2025-10-12 18:58:34',1);
/*!40000 ALTER TABLE `erabiltzaileak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `langileak`
--

DROP TABLE IF EXISTS `langileak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `langileak` (
  `id_langilea` int NOT NULL AUTO_INCREMENT,
  `izena` varchar(20) NOT NULL,
  `abizena1` varchar(20) NOT NULL,
  `abizena2` varchar(20) NOT NULL,
  `nan` varchar(9) NOT NULL,
  `jaiotza_data` date NOT NULL,
  `posta_elektronikoa` varchar(45) NOT NULL,
  `telefono_zenbakia` varchar(9) NOT NULL,
  `helbidea` longtext NOT NULL,
  `erabiltzaile_izena` varchar(45) NOT NULL,
  `pasahitza` varchar(45) NOT NULL,
  `arduraduna` tinyint NOT NULL,
  PRIMARY KEY (`id_langilea`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `langileak`
--

LOCK TABLES `langileak` WRITE;
/*!40000 ALTER TABLE `langileak` DISABLE KEYS */;
INSERT INTO `langileak` VALUES (1,'Ane','Garcia','Lopez','12345678B','1990-05-14','ane.garcia@example.com','612345678','Calle Mayor 1, Bilbao','ane.g','pass1234',1),(2,'Iker','Martinez','Sanchez','23456789B','1988-11-02','iker.mtz@example.com','622345678','Avda Libertad 45, Donostia','iker.m','pass2345',0),(3,'Miren','Fernandez','Etxeberria','34567890C','1995-07-23','miren.f@example.com','632345678','Calle Arriaga 12, Vitoria','miren.f','pass3456',0),(4,'Jon','Perez','Agirre','45678901D','1992-03-10','jon.p@example.com','642345678','Plaza Nueva 3, Bilbao','jon.p','pass4567',1),(5,'Leire','Rodriguez','Ibarra','56789012E','1998-09-30','leire.r@example.com','652345678','Calle Iturribide 8, Gasteiz','leire.r','pass5678',0),(6,'Unai','Alonso','Garcia','67890123F','1985-12-05','unai.a@example.com','662345678','Calle San Juan 17, Donostia','unai.a','pass6789',1),(7,'Ainhoa','Lopez','Mendizabal','78901234G','1993-04-18','ainhoa.l@example.com','672345678','Calle Urkijo 4, Bilbao','ainhoa.l','pass7890',0),(8,'Gaizka','Hernandez','Garate','89012345H','1989-06-27','gaizka.h@example.com','682345678','Calle Estacion 23, Barakaldo','gaizka.h','pass8901',1),(9,'Maite','Etxebarria','Uribe','90123456I','1991-08-12','maite.e@example.com','692345678','Avda Gernika 56, Gernika','maite.e','pass9012',0),(10,'Ander','Agirre','Larrañaga','11223344J','1996-01-20','ander.a@example.com','602345678','Calle Goiri 11, Durango','ander.a','pass0123',0),(11,'Nerea','Gomez','Landaburu','22334455K','1990-10-08','nerea.g@example.com','611223344','Avda Basagoiti 89, Getxo','nerea.g','pw1122',1),(12,'Asier','Olabarria','Garcia','33445566L','1987-02-19','asier.o@example.com','622334455','Calle Diputacion 99, Bilbao','asier.o','pw2233',0),(14,'Xabier','Ruiz','Arrieta','55667788N','1986-11-25','xabier.r@example.com','644556677','Calle Artekale 6, Durango','xabier.r','pw4455',1),(15,'June','Salazar','Fernandez','66778899O','1992-09-09','june.s@example.com','655667788','Calle Elcano 7, Bilbao','june.s','pw5566',0),(16,'Markel','Vicente','Lopez','77889900P','1984-12-29','markel.v@example.com','666778899','Calle San Francisco 2, Barakaldo','markel.v','pw6677',1),(17,'Oihane','Calleja','Martinez','88990011Q','1997-03-15','oihane.c@example.com','677889900','Avda Txorierri 4, Leioa','oihane.c','pw7788',0),(18,'Mikel','Eguren','Santamaria','99001122R','1991-05-22','mikel.e@example.com','688990011','Calle La Paz 33, Vitoria','mikel.e','pw8899',1),(19,'Uxue','Lazaro','Garcia','10111213S','1995-08-19','uxue.l@example.com','699101112','Avda Universitaria 12, Donostia','uxue.l','pw9900',0),(20,'Aitor','Serrano','Iñiguez','12131415T','1989-04-03','aitor.s@example.com','600121314','Calle Santiago 21, Bilbao','aitor.s','pw1111',0),(21,'Amaia','Zabala','Ortega','13141516U','1993-02-11','amaia.z@example.com','611131415','Calle Iturriza 17, Gernika','amaia.z','pw2222',1),(22,'Kepa','Gonzalez','Perez','14151617V','1987-07-30','kepa.g@example.com','622141516','Plaza Euskadi 44, Bilbao','kepa.g','pw3333',0),(23,'Nahia','Jimenez','Uriarte','15161718W','1998-01-25','nahia.j@example.com','633151617','Calle Zabalbide 9, Bilbao','nahia.j','pw4444',0),(24,'Beñat','Ortiz','Sanchez','16171819X','1990-06-06','benat.o@example.com','644161718','Calle Areatza 3, Durango','benat.o','pw5555',1),(25,'Irune','Marquez','Aranburu','17181920Y','1996-12-02','irune.m@example.com','655171819','Avda Sabino Arana 5, Bilbao','irune.m','pw6666',0),(26,'Patxi','Pardo','Garcia','18192021Z','1985-09-14','patxi.p@example.com','666181920','Calle Cervantes 13, Vitoria','patxi.p','pw7777',1);
/*!40000 ALTER TABLE `langileak` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-12 20:00:39
