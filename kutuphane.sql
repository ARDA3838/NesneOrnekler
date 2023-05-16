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


-- kütüphane için veritabanı yapısı dökülüyor
DROP DATABASE IF EXISTS `kütüphane`;
CREATE DATABASE IF NOT EXISTS `kütüphane` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `kütüphane`;

-- tablo yapısı dökülüyor kütüphane.kitaplar
DROP TABLE IF EXISTS `kitaplar`;
CREATE TABLE IF NOT EXISTS `kitaplar` (
  `kitap_id` int NOT NULL AUTO_INCREMENT,
  `tur_id` tinyint NOT NULL,
  `kitap_adi` varchar(40) NOT NULL,
  `yazar` varchar(40) NOT NULL,
  `yayinevi` varchar(40) NOT NULL,
  `sayfa_sayisi` smallint NOT NULL,
  PRIMARY KEY (`kitap_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kütüphane.kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitaplar`;
/*!40000 ALTER TABLE `kitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kütüphane.kitap_turleri
DROP TABLE IF EXISTS `kitap_turleri`;
CREATE TABLE IF NOT EXISTS `kitap_turleri` (
  `tur_id` int NOT NULL AUTO_INCREMENT,
  `tur_adi` varchar(40) NOT NULL,
  PRIMARY KEY (`tur_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kütüphane.kitap_turleri: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitap_turleri`;
/*!40000 ALTER TABLE `kitap_turleri` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitap_turleri` ENABLE KEYS */;

-- tablo yapısı dökülüyor kütüphane.odunc_kitaplar
DROP TABLE IF EXISTS `odunc_kitaplar`;
CREATE TABLE IF NOT EXISTS `odunc_kitaplar` (
  `tur_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kütüphane.odunc_kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `odunc_kitaplar`;
/*!40000 ALTER TABLE `odunc_kitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `odunc_kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kütüphane.ogrenci
DROP TABLE IF EXISTS `ogrenci`;
CREATE TABLE IF NOT EXISTS `ogrenci` (
  `ogrenci_no` int NOT NULL,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(25) NOT NULL,
  `sinif` tinyint NOT NULL,
  `cinsiyet` varchar(7) NOT NULL,
  `sinif1` varchar(12) NOT NULL,
  PRIMARY KEY (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kütüphane.ogrenci: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `ogrenci`;
/*!40000 ALTER TABLE `ogrenci` DISABLE KEYS */;
/*!40000 ALTER TABLE `ogrenci` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
