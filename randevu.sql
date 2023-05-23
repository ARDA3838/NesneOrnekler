-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                8.0.21 - MySQL Community Server - GPL
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- randevu için veritabanı yapısı dökülüyor
DROP DATABASE IF EXISTS `randevu`;
CREATE DATABASE IF NOT EXISTS `randevu` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `randevu`;

-- tablo yapısı dökülüyor randevu.hasta_kayıt
DROP TABLE IF EXISTS `hasta_kayıt`;
CREATE TABLE IF NOT EXISTS `hasta_kayıt` (
  `tc` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ad` varchar(50) DEFAULT NULL,
  `soyad` varchar(50) DEFAULT NULL,
  `telefon` varchar(50) DEFAULT NULL,
  `ay_gün_saat` tinyint DEFAULT NULL,
  `branş_bölüm` tinyint DEFAULT NULL,
  `hastane` tinyint DEFAULT NULL,
  PRIMARY KEY (`tc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- randevu.hasta_kayıt: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `hasta_kayıt`;
/*!40000 ALTER TABLE `hasta_kayıt` DISABLE KEYS */;
/*!40000 ALTER TABLE `hasta_kayıt` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
