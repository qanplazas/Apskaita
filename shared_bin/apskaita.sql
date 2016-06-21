/*
SQLyog Community v12.2.1 (64 bit)
MySQL - 10.1.10-MariaDB : Database - apskaita
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`apskaita` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_lithuanian_ci */;

USE `apskaita`;

/*Table structure for table `mat_vert` */

DROP TABLE IF EXISTS `mat_vert`;

CREATE TABLE `mat_vert` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Kodas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `Pavadinimas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `SaskaitaId` int(11) NOT NULL,
  `MatoVntId` int(10) NOT NULL,
  `KiekioLikutis` decimal(18,2) NOT NULL,
  `SumosLikutis` decimal(18,2) NOT NULL,
  `PadalinysId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `SaskaitaId` (`SaskaitaId`),
  KEY `PadalinysId` (`PadalinysId`),
  KEY `MatoVntId` (`MatoVntId`),
  CONSTRAINT `mat_vert_ibfk_1` FOREIGN KEY (`SaskaitaId`) REFERENCES `saskaita` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `mat_vert_ibfk_2` FOREIGN KEY (`PadalinysId`) REFERENCES `padalinys` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `mat_vert_ibfk_3` FOREIGN KEY (`MatoVntId`) REFERENCES `matovnt` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `mat_vert` */

insert  into `mat_vert`(`Id`,`Kodas`,`Pavadinimas`,`SaskaitaId`,`MatoVntId`,`KiekioLikutis`,`SumosLikutis`,`PadalinysId`) values 
(1,'000380','Tašelis, smulkus, pušis',10,3,'899.00','-9480.52',2),
(2,'000977','Tašas, pušies 92*74',10,3,'0.00','0.00',2),
(3,'000274','Stiklo paketai',11,4,'1.42','1.42',2),
(4,'000554','Stiklo paketai',11,4,'0.00','0.00',2),
(5,'002514','ASSA 602 oval. cil., raktas, apd. rak. v. r.',8,6,'2.00','97.21',2),
(6,'002726','Stiklo paketai',11,4,'0.00','0.00',2);

/*Table structure for table `matovnt` */

DROP TABLE IF EXISTS `matovnt`;

CREATE TABLE `matovnt` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Pavad` varchar(10) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `matovnt` */

insert  into `matovnt`(`Id`,`Pavad`) values 
(1,'l'),
(2,'kg'),
(3,'m'),
(4,'m*2'),
(5,'m*3'),
(6,'kompl'),
(7,'vnt');

/*Table structure for table `nurasymo_aktas` */

DROP TABLE IF EXISTS `nurasymo_aktas`;

CREATE TABLE `nurasymo_aktas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Vaztarascio_nr` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `Data` date NOT NULL,
  `Saskaitos_nr` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `TiekejasId` int(11) NOT NULL,
  `PadalinysId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `PadalinysId` (`PadalinysId`),
  KEY `TiekejasId` (`TiekejasId`),
  CONSTRAINT `nurasymo_aktas_ibfk_1` FOREIGN KEY (`PadalinysId`) REFERENCES `padalinys` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `nurasymo_aktas_ibfk_2` FOREIGN KEY (`TiekejasId`) REFERENCES `tiekejas` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `nurasymo_aktas` */

insert  into `nurasymo_aktas`(`Id`,`Vaztarascio_nr`,`Data`,`Saskaitos_nr`,`TiekejasId`,`PadalinysId`) values 
(3,'nurasymas','2015-05-15','1',1,2);

/*Table structure for table `nurasymo_operacija` */

DROP TABLE IF EXISTS `nurasymo_operacija`;

CREATE TABLE `nurasymo_operacija` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TurtasId` int(11) NOT NULL,
  `AktasId` int(11) NOT NULL,
  `NurasytasKiekis` decimal(18,2) NOT NULL,
  `VienetoKaina` decimal(18,2) NOT NULL,
  `ArIssaugota` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `TurtasId` (`TurtasId`),
  KEY `AktasId` (`AktasId`),
  CONSTRAINT `nurasymo_operacija_ibfk_1` FOREIGN KEY (`TurtasId`) REFERENCES `mat_vert` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `nurasymo_operacija_ibfk_2` FOREIGN KEY (`AktasId`) REFERENCES `nurasymo_aktas` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `nurasymo_operacija` */

insert  into `nurasymo_operacija`(`Id`,`TurtasId`,`AktasId`,`NurasytasKiekis`,`VienetoKaina`,`ArIssaugota`) values 
(2,1,3,'100.00','100.00',1);

/*Table structure for table `padalinys` */

DROP TABLE IF EXISTS `padalinys`;

CREATE TABLE `padalinys` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Kodas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `Pavadinimas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `padalinys` */

insert  into `padalinys`(`Id`,`Kodas`,`Pavadinimas`) values 
(1,'01','Dažymo cechas'),
(2,'02','Surinkimo cechas');

/*Table structure for table `pajamavimo_aktas` */

DROP TABLE IF EXISTS `pajamavimo_aktas`;

CREATE TABLE `pajamavimo_aktas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Vaztarascio_nr` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `Data` date NOT NULL,
  `Saskaitos_nr` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `TiekejasId` int(11) NOT NULL,
  `PadalinysId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `PadalinysId` (`PadalinysId`),
  KEY `TiekejasId` (`TiekejasId`),
  CONSTRAINT `pajamavimo_aktas_ibfk_1` FOREIGN KEY (`PadalinysId`) REFERENCES `padalinys` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `pajamavimo_aktas_ibfk_2` FOREIGN KEY (`TiekejasId`) REFERENCES `tiekejas` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `pajamavimo_aktas` */

insert  into `pajamavimo_aktas`(`Id`,`Vaztarascio_nr`,`Data`,`Saskaitos_nr`,`TiekejasId`,`PadalinysId`) values 
(6,'vz','2016-01-10','5',1,2);

/*Table structure for table `pajamavimo_operacija` */

DROP TABLE IF EXISTS `pajamavimo_operacija`;

CREATE TABLE `pajamavimo_operacija` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TurtasId` int(11) NOT NULL,
  `AktasId` int(11) NOT NULL,
  `PajamuotasKiekis` decimal(18,2) NOT NULL,
  `VienetoKaina` decimal(18,2) NOT NULL,
  `ArIssaugota` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `TurtasId` (`TurtasId`),
  KEY `AktasId` (`AktasId`),
  CONSTRAINT `pajamavimo_operacija_ibfk_1` FOREIGN KEY (`TurtasId`) REFERENCES `mat_vert` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `pajamavimo_operacija_ibfk_2` FOREIGN KEY (`AktasId`) REFERENCES `pajamavimo_aktas` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `pajamavimo_operacija` */

insert  into `pajamavimo_operacija`(`Id`,`TurtasId`,`AktasId`,`PajamuotasKiekis`,`VienetoKaina`,`ArIssaugota`) values 
(8,3,6,'1.00','1.00',1);

/*Table structure for table `prisijungimas` */

DROP TABLE IF EXISTS `prisijungimas`;

CREATE TABLE `prisijungimas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `prisij_vardas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `slaptaz` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `prisijungimas` */

insert  into `prisijungimas`(`Id`,`prisij_vardas`,`slaptaz`) values 
(1,'admin','21232f297a57a5a743894a0e4a801fc3');

/*Table structure for table `registras` */

DROP TABLE IF EXISTS `registras`;

CREATE TABLE `registras` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TurtasId` int(11) NOT NULL,
  `KiekisPradzioje` decimal(18,2) NOT NULL,
  `SumaPradzioje` decimal(18,2) NOT NULL,
  `NurasytasKiekis` decimal(18,2) NOT NULL,
  `NurasytaSuma` decimal(18,2) NOT NULL,
  `UzpajamuotasKiekis` decimal(18,2) NOT NULL,
  `UzpajamuotaSuma` decimal(18,2) NOT NULL,
  `KiekioLikutis` decimal(18,2) NOT NULL,
  `SumosLikutis` decimal(18,2) NOT NULL,
  `Laikotarpio_pradzia` date NOT NULL,
  `Laikotarpio_pabaiga` date NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `TurtasId` (`TurtasId`),
  CONSTRAINT `registras_ibfk_1` FOREIGN KEY (`TurtasId`) REFERENCES `mat_vert` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `registras` */

insert  into `registras`(`Id`,`TurtasId`,`KiekisPradzioje`,`SumaPradzioje`,`NurasytasKiekis`,`NurasytaSuma`,`UzpajamuotasKiekis`,`UzpajamuotaSuma`,`KiekioLikutis`,`SumosLikutis`,`Laikotarpio_pradzia`,`Laikotarpio_pabaiga`) values 
(1,1,'1000.00','520.00','1.00','0.52','0.00','0.00','999.00','519.48','2015-05-01','2015-05-31'),
(2,2,'0.00','0.00','0.00','0.00','0.00','0.00','0.00','0.00','2015-05-01','2015-05-31'),
(3,3,'0.42','0.42','0.00','0.00','0.00','0.00','0.42','0.42','2015-05-01','2015-05-31'),
(4,4,'0.00','0.00','0.00','0.00','0.00','0.00','0.00','0.00','2015-05-01','2015-05-31'),
(5,5,'2.00','97.21','0.00','0.00','0.00','0.00','2.00','97.21','2015-05-01','2015-05-31'),
(6,6,'0.00','0.00','0.00','0.00','0.00','0.00','0.00','0.00','2015-05-01','2015-05-31'),
(7,1,'999.00','519.48','100.00','10000.00','0.00','0.00','899.00','-9480.52','2016-05-01','2016-05-31'),
(8,2,'0.00','0.00','0.00','0.00','0.00','0.00','0.00','0.00','2016-05-01','2016-05-31'),
(9,3,'0.42','0.42','0.00','0.00','1.00','1.00','1.42','1.42','2016-05-01','2016-05-31'),
(10,4,'0.00','0.00','0.00','0.00','0.00','0.00','0.00','0.00','2016-05-01','2016-05-31'),
(11,5,'2.00','97.21','0.00','0.00','0.00','0.00','2.00','97.21','2016-05-01','2016-05-31'),
(12,6,'0.00','0.00','0.00','0.00','0.00','0.00','0.00','0.00','2016-05-01','2016-05-31');

/*Table structure for table `saskaita` */

DROP TABLE IF EXISTS `saskaita`;

CREATE TABLE `saskaita` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Kodas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `Pavadinimas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `saskaita` */

insert  into `saskaita`(`Id`,`Kodas`,`Pavadinimas`) values 
(8,'20','Atsargos'),
(9,'201','Žaliavos, medžiagos ir komplektuojamieji gaminiai'),
(10,'203','Pagaminti produktai'),
(11,'204','Prekės skirtos perpaduoti'),
(23,'209','Kitos atsargos'),
(24,'2092','Kuras');

/*Table structure for table `tiekejas` */

DROP TABLE IF EXISTS `tiekejas`;

CREATE TABLE `tiekejas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Pavadinimas` varchar(100) COLLATE utf8_lithuanian_ci NOT NULL,
  `PVM_kodas` varchar(100) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Imones_kodas` varchar(100) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Atsisk_sask_nr` varchar(100) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Adresas` varchar(100) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `Telefonas` varchar(100) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  `ElPastas` varchar(100) COLLATE utf8_lithuanian_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_lithuanian_ci;

/*Data for the table `tiekejas` */

insert  into `tiekejas`(`Id`,`Pavadinimas`,`PVM_kodas`,`Imones_kodas`,`Atsisk_sask_nr`,`Adresas`,`Telefonas`,`ElPastas`) values 
(1,'UAB \"Mediena\"',NULL,NULL,NULL,NULL,NULL,NULL),
(2,'UAB \"Varžtų pasaulis\"',NULL,NULL,NULL,NULL,NULL,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
