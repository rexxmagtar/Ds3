-- MySQL Script generated by MySQL Workbench
-- Wed Oct 21 16:53:31 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `polyclinic`;
CREATE SCHEMA `polyclinic` DEFAULT CHARACTER SET utf8;
USE `polyclinic`;
-- -----------------------------------------------------
-- Table `mydb`.`visits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `visits` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `token` VARCHAR(255) NOT NULL,
  `doctor_fio` VARCHAR(45) NOT NULL,
  `patient_fio` VARCHAR(45) NOT NULL,
  `date` DATE NOT NULL,
  `speciality` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

INSERT INTO visits(token, doctor_fio, patient_fio, date, speciality) VALUES("token","Ivanov Ivan Ivanivich","Petrov Petr Petrovich", "2020-1-1","TERAPEUT");



