-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: acelist
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking` (
  `booking_id` int NOT NULL,
  `room_id` int NOT NULL,
  `customer_id` varchar(20) NOT NULL,
  `employee_id` varchar(20) NOT NULL,
  `booking_time` date NOT NULL,
  `checkin_time` date NOT NULL,
  `checkout_time` date NOT NULL,
  `has_checked_in` tinyint(1) NOT NULL,
  `has_checked_out` tinyint(1) NOT NULL,
  PRIMARY KEY (`booking_id`),
  KEY `room_id` (`room_id`),
  KEY `customer_id` (`customer_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `room` (`room_id`),
  CONSTRAINT `booking_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`),
  CONSTRAINT `booking_ibfk_3` FOREIGN KEY (`employee_id`) REFERENCES `receptionist` (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` VALUES (1,103,'1122334455001','55443322110002','2022-11-11','2022-12-05','2022-12-06',0,0),(2,104,'1122334455015','55443322110002','2022-11-11','2022-12-05','2022-12-06',0,0),(3,111,'1122334455015','55443322110002','2022-11-11','2022-12-05','2022-12-09',0,0),(4,111,'1122334455012','55443322110001','2022-11-10','2022-12-04','2022-12-05',0,0);
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customer_id` varchar(20) NOT NULL,
  `customer_name` varchar(40) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('1122334455001','Mindy Tireman','mtireman0@yahoo.co.jp','503-139-0600'),('1122334455002','Trula Slowgrove','tslowgrove1@sourceforge.net','947-281-2137'),('1122334455003','Carine Aime','caime2@cpanel.net','198-482-3787'),('1122334455004','Tiphanie Worthington','tworthington3@ustream.tv','726-639-1040'),('1122334455005','Ignatius Newsome','inewsome4@baidu.com','302-616-7348'),('1122334455006','Arluene Alderton','aalderton5@behance.net','775-878-9868'),('1122334455007','Nester Watson-Brown','nwatsonbrown6@seattletimes.com','549-411-0818'),('1122334455008','Tammi Moules','tmoules7@example.com','186-803-5838'),('1122334455009','Urbain Durrans','udurrans8@blinklist.com','708-323-2706'),('1122334455010','Bobbie Kastel','bkastel9@youtu.be','161-301-1948'),('1122334455011','Deni Blakes','dblakesa@booking.com','283-836-6547'),('1122334455012','Wallache Brilleman','wbrillemanb@usgs.gov','669-996-8239'),('1122334455013','Gabriella Christon','gchristonc@yahoo.com','782-309-3621'),('1122334455014','Lurette Caygill','lcaygilld@accuweather.com','733-731-5297'),('1122334455015','Kermit Younglove','kyounglovee@multiply.com','273-559-8339'),('1122334455016','Kerrie Izard','kizardf@wikispaces.com','109-483-8323'),('1122334455017','Leoine Zelland','lzellandg@deliciousdays.com','426-291-8040'),('1122334455018','Laverne Bimrose','lbimroseh@acquirethisname.com','625-811-1011'),('1122334455019','Magdaia Rake','mrakei@gizmodo.com','531-608-4792'),('1122334455020','Chandra Broggio','cbroggioj@yandex.ru','737-458-0541'),('1122334455021','Gayelord Hambers','ghambersk@examiner.com','924-266-9501'),('1122334455022','Saba Christoffe','schristoffel@sfgate.com','720-547-6123'),('1122334455023','Catarina Bullon','cbullonm@mysql.com','222-348-7290'),('1122334455024','Erich Tellesson','etellessonn@sohu.com','588-878-2834'),('1122334455025','Karola Duckitt','kduckitto@craigslist.org','373-393-7406'),('1122334455026','Francesca Mehmet','fmehmetp@csmonitor.com','833-536-6874'),('1122334455027','Fairleigh Kuhnert','fkuhnertq@umich.edu','444-163-5059'),('1122334455028','Madge Bampforth','mbampforthr@foxnews.com','350-778-3760'),('1122334455029','Kinny Dumphy','kdumphys@archive.org','292-435-4048'),('1122334455030','Lark Danilchik','ldanilchikt@devhub.com','485-130-9801'),('1122334455031','Ermengarde Sollon','esollonu@canalblog.com','300-661-3017'),('1122334455032','Alessandro Petera','apeterav@instagram.com','414-562-4684'),('1122334455033','Donnie Bulbrook','dbulbrookw@flickr.com','708-788-7115'),('1122334455034','Valera Halvosen','vhalvosenx@vimeo.com','278-719-1501'),('1122334455035','Christina Hundley','chundleyy@example.com','617-711-0237'),('1122334455036','Ase Skupinski','askupinskiz@usa.gov','889-178-0768'),('1122334455037','Clerissa Natt','cnatt10@aboutads.info','668-510-4097'),('1122334455038','Janie Ungerechts','jungerechts11@webeden.co.uk','644-823-3275'),('1122334455039','Chrystal Brownfield','cbrownfield12@blogger.com','734-282-2079'),('1122334455040','Lizzy Stonuary','lstonuary13@fda.gov','809-169-3728'),('1122334455041','Calida Eatock','ceatock14@123-reg.co.uk','485-427-8435'),('1122334455042','Arnaldo Simonyi','asimonyi15@free.fr','215-910-2440'),('1122334455043','Katine Lismore','klismore16@sbwire.com','522-111-1552'),('1122334455044','Judie Budcock','jbudcock17@illinois.edu','893-883-4315'),('1122334455045','Annabell Hedditeh','ahedditeh18@biblegateway.com','503-275-6387'),('1122334455046','Petey Kearford','pkearford19@sphinn.com','795-657-8217'),('1122334455047','Ewan Fairbrother','efairbrother1a@spotify.com','143-299-9982'),('1122334455048','Hershel McGrey','hmcgrey1b@cloudflare.com','501-943-7606'),('1122334455049','Gisela Hesse','ghesse1c@webnode.com','549-680-3775'),('1122334455050','Darcy Heenan','dheenan1d@newyorker.com','478-996-6201'),('1122334455051','Nickie Stood','nstood1e@netscape.com','520-694-0173'),('1122334455052','Leese MacRedmond','lmacredmond1f@slashdot.org','886-366-7640'),('1122334455053','Blondy Westoff','bwestoff1g@hao123.com','228-916-9421'),('1122334455054','Lane Nesbitt','lnesbitt1h@about.me','808-210-9307'),('1122334455055','Trude Deevey','tdeevey1i@si.edu','677-541-2352'),('1122334455056','Debera Derrett','dderrett1j@sun.com','614-266-9921'),('1122334455057','Renata Melia','rmelia1k@fastcompany.com','808-741-8175'),('1122334455058','Garvey Guyet','gguyet1l@umn.edu','806-660-4580'),('1122334455059','Lydia Sodory','lsodory1m@moonfruit.com','195-309-3922'),('1122334455060','Norah Lunge','nlunge1n@freewebs.com','321-242-2654'),('1122334455061','Korney Twine','ktwine1o@usgs.gov','211-709-6318'),('1122334455062','Catarina Chaplin','cchaplin1p@w3.org','410-414-6597'),('1122334455063','Leda Novic','lnovic1q@people.com.cn','322-804-0270'),('1122334455064','Berty Granham','bgranham1r@nytimes.com','417-875-2908'),('1122334455065','Kelley Maureen','kmaureen1s@gnu.org','562-113-3726'),('1122334455066','Cobby Northall','cnorthall1t@storify.com','752-807-7177'),('1122334455067','Mabel Koppel','mkoppel1u@shareasale.com','213-958-3211'),('1122334455068','Fredra Mattheissen','fmattheissen1v@bloomberg.com','577-513-0643'),('1122334455069','Olympe Steely','osteely1w@example.com','743-385-2903'),('1122334455070','Kingsley Drayson','kdrayson1x@tinyurl.com','937-430-4481'),('1122334455071','Meridith Dockrey','mdockrey1y@kickstarter.com','335-945-5698'),('1122334455072','Eadmund Gaitung','egaitung1z@theguardian.com','536-592-3085'),('1122334455073','Felike Kluger','fkluger20@wikipedia.org','491-746-0725'),('1122334455074','Melamie Miell','mmiell21@google.fr','213-652-3414'),('1122334455075','Jay Follis','jfollis22@barnesandnoble.com','821-898-6660'),('1122334455076','Brigitte Eric','beric23@pen.io','185-673-2073'),('1122334455077','Mindy Stearn','mstearn24@mapquest.com','433-709-8460'),('1122334455078','Zilvia Gomby','zgomby25@weibo.com','721-332-5242'),('1122334455079','Mabelle OKeefe','mokeefe26@chronoengine.com','435-268-1193'),('1122334455080','Niko Breeze','nbreeze27@vimeo.com','221-993-0972'),('1122334455081','Donavon Lelliott','dlelliott28@yahoo.com','562-846-9179'),('1122334455082','Rianon Rottcher','rrottcher29@booking.com','753-852-5896'),('1122334455083','Selena Prisk','sprisk2a@bigcartel.com','446-402-2713'),('1122334455084','Luise Fortin','lfortin2b@indiegogo.com','266-260-4525'),('1122334455085','Bucky Ivkovic','bivkovic2c@dropbox.com','833-285-1177'),('1122334455086','Cedric Bodimeade','cbodimeade2d@pcworld.com','283-853-2978'),('1122334455087','Patti Escritt','pescritt2e@sun.com','208-895-7085'),('1122334455088','Siobhan Vittel','svittel2f@usatoday.com','711-692-7627'),('1122334455089','Darrel Wilne','dwilne2g@goo.gl','412-911-5123'),('1122334455090','Salvador Olivey','solivey2h@reference.com','564-691-0985'),('1122334455091','Corby Winfred','cwinfred2i@symantec.com','757-281-7288'),('1122334455092','Aube Lenox','alenox2j@tripadvisor.com','715-888-5406'),('1122334455093','Dael Goscar','dgoscar2k@over-blog.com','103-983-6385'),('1122334455094','Shurlocke Comins','scomins2l@freewebs.com','610-362-3831'),('1122334455095','Rochester Ewer','rewer2m@amazon.co.jp','642-145-0078'),('1122334455096','Gerome Mahaddy','gmahaddy2n@studiopress.com','171-933-0830'),('1122334455097','Susy Tomaskov','stomaskov2o@acquirethisname.com','786-769-5751'),('1122334455098','Dyann Bransden','dbransden2p@adobe.com','536-426-4506'),('1122334455099','Porter Roselli','proselli2q@diigo.com','503-137-8928'),('1122334455100','Mollee Slowan','mslowan2r@ezinearticles.com','887-646-2779');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `item_id` int NOT NULL,
  `item_name` varchar(40) NOT NULL,
  `item_price` int NOT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'massage',250000),(2,'spa',420000),(3,'dinner',150000);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `booking_id` int NOT NULL,
  `item_id` int NOT NULL,
  `amount` int NOT NULL,
  KEY `booking_id` (`booking_id`),
  KEY `item_id` (`item_id`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`booking_id`) REFERENCES `booking` (`booking_id`),
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `menu` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,3,2);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receptionist`
--

DROP TABLE IF EXISTS `receptionist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receptionist` (
  `employee_id` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(30) NOT NULL,
  `name` varchar(40) NOT NULL,
  `phone_number` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receptionist`
--

LOCK TABLES `receptionist` WRITE;
/*!40000 ALTER TABLE `receptionist` DISABLE KEYS */;
INSERT INTO `receptionist` VALUES ('55443322110001','nasikorea','nasikorea','Lindsey Stirling','222-333-4444'),('55443322110002','nasijepang','nasijepang','Monkey D. Luffy','111-222-3333'),('55443322110003','nasibelanda','nasibelanda','Roronoa Zoro','444-333-2222'),('55443322110004','nasiarab','nasiarab','Maha Balor','999-000-8888');
/*!40000 ALTER TABLE `receptionist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room` (
  `room_id` int NOT NULL,
  `room_type` varchar(20) NOT NULL,
  `room_price` int NOT NULL,
  `floor` int NOT NULL,
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` VALUES (101,'Minister',650000,1),(102,'Minister',650000,1),(103,'Minister',650000,1),(104,'Minister',650000,1),(105,'Minister',650000,1),(106,'Minister',650000,1),(107,'Minister',650000,1),(108,'Minister',650000,1),(109,'Minister',650000,1),(110,'Minister',650000,1),(111,'Minister',650000,1),(112,'Minister',650000,1),(113,'Minister',650000,1),(114,'Minister',650000,1),(115,'Minister',650000,1),(116,'Minister',650000,1),(117,'Minister',650000,1),(118,'Minister',650000,1),(119,'Minister',650000,1),(120,'Minister',650000,1),(121,'Minister',650000,1),(122,'Minister',650000,1),(123,'Minister',650000,1),(124,'Minister',650000,1),(125,'Minister',650000,1),(126,'Minister',650000,1),(127,'Minister',650000,1),(128,'Minister',650000,1),(129,'Minister',650000,1),(130,'Minister',650000,1),(201,'Emperor',900000,2),(202,'Emperor',900000,2),(203,'Emperor',900000,2),(204,'Emperor',900000,2),(205,'Emperor',900000,2),(206,'Emperor',900000,2),(207,'Emperor',900000,2),(208,'Emperor',900000,2),(209,'Emperor',900000,2),(210,'Emperor',900000,2),(211,'Emperor',900000,2),(212,'Emperor',900000,2),(213,'Emperor',900000,2),(214,'Emperor',900000,2),(215,'Emperor',900000,2),(216,'Emperor',900000,2),(217,'Emperor',900000,2),(218,'Emperor',900000,2),(219,'Emperor',900000,2),(220,'Emperor',900000,2),(221,'Emperor',900000,2),(222,'Emperor',900000,2),(223,'Emperor',900000,2),(224,'Emperor',900000,2),(225,'Emperor',900000,2),(226,'Emperor',900000,2),(227,'Emperor',900000,2),(228,'Emperor',900000,2),(229,'Emperor',900000,2),(230,'Emperor',900000,2),(301,'Emperor',900000,3),(302,'Emperor',900000,3),(303,'Emperor',900000,3),(304,'Emperor',900000,3),(305,'Emperor',900000,3),(306,'Emperor',900000,3),(307,'Emperor',900000,3),(308,'Emperor',900000,3),(309,'Emperor',900000,3),(310,'Emperor',900000,3),(311,'Emperor',900000,3),(312,'Emperor',900000,3),(313,'Emperor',900000,3),(314,'Emperor',900000,3),(315,'Emperor',900000,3),(316,'Emperor',900000,3),(317,'Emperor',900000,3),(318,'Emperor',900000,3),(319,'Emperor',900000,3),(320,'Emperor',900000,3),(321,'Emperor',900000,3),(322,'Emperor',900000,3),(323,'Emperor',900000,3),(324,'Emperor',900000,3),(325,'Emperor',900000,3),(326,'Emperor',900000,3),(327,'Emperor',900000,3),(328,'Emperor',900000,3),(329,'Emperor',900000,3),(330,'Emperor',900000,3),(401,'King',1200000,4),(402,'King',1200000,4),(403,'King',1200000,4),(404,'King',1200000,4),(405,'King',1200000,4),(406,'King',1200000,4),(407,'King',1200000,4),(408,'King',1200000,4),(409,'King',1200000,4),(410,'King',1200000,4),(411,'King',1200000,4),(412,'King',1200000,4),(413,'King',1200000,4),(414,'King',1200000,4),(415,'King',1200000,4),(416,'King',1200000,4),(417,'King',1200000,4),(418,'King',1200000,4),(419,'King',1200000,4),(420,'King',1200000,4),(421,'King',1200000,4),(422,'King',1200000,4),(423,'King',1200000,4),(424,'King',1200000,4),(425,'King',1200000,4),(426,'King',1200000,4),(427,'King',1200000,4),(428,'King',1200000,4),(429,'King',1200000,4),(430,'King',1200000,4);
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-12 23:16:56
