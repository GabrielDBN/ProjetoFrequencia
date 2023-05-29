-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema escolla
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema escolla
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `escolla` DEFAULT CHARACTER SET utf8mb4 ;
USE `escolla` ;

-- -----------------------------------------------------
-- Table `escolla`.`alunos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`alunos` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `dataNascimento` DATE NULL DEFAULT NULL,
  `email` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`usuarios` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `email` VARCHAR(255) NULL DEFAULT NULL,
  `senha` VARCHAR(255) NULL DEFAULT NULL,
  `tipo` ENUM('professor', 'secretario') NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`professores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`professores` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `usuario_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `usuario_id` (`usuario_id` ASC),
  CONSTRAINT `professores_ibfk_1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `escolla`.`usuarios` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`disciplinas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`disciplinas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `professor_id` INT(11) NULL DEFAULT NULL,
  `tipo_disciplina` ENUM('2', '4') NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `professor_id` (`professor_id` ASC),
  CONSTRAINT `disciplinas_ibfk_1`
    FOREIGN KEY (`professor_id`)
    REFERENCES `escolla`.`professores` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`turmas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`turmas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `semestre` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`disciplinas_turmas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`disciplinas_turmas` (
  `disciplina_id` INT(11) NOT NULL,
  `turma_id` INT(11) NOT NULL,
  PRIMARY KEY (`disciplina_id`, `turma_id`),
  INDEX `turma_id` (`turma_id` ASC),
  CONSTRAINT `disciplinas_turmas_ibfk_1`
    FOREIGN KEY (`disciplina_id`)
    REFERENCES `escolla`.`disciplinas` (`id`),
  CONSTRAINT `disciplinas_turmas_ibfk_2`
    FOREIGN KEY (`turma_id`)
    REFERENCES `escolla`.`turmas` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`horarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`horarios` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `dia_semana` VARCHAR(255) NULL DEFAULT NULL,
  `horario` VARCHAR(255) NULL DEFAULT NULL,
  `disciplina_id` INT(11) NULL DEFAULT NULL,
  `turma_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `disciplina_id` (`disciplina_id` ASC),
  INDEX `turma_id` (`turma_id` ASC),
  CONSTRAINT `horarios_ibfk_1`
    FOREIGN KEY (`disciplina_id`)
    REFERENCES `escolla`.`disciplinas` (`id`),
  CONSTRAINT `horarios_ibfk_2`
    FOREIGN KEY (`turma_id`)
    REFERENCES `escolla`.`turmas` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`matriculas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`matriculas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `aluno_id` INT(11) NULL DEFAULT NULL,
  `disciplina_id` INT(11) NULL DEFAULT NULL,
  `turma_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `aluno_id` (`aluno_id` ASC),
  INDEX `disciplina_id` (`disciplina_id` ASC),
  INDEX `turma_id` (`turma_id` ASC),
  CONSTRAINT `matriculas_ibfk_1`
    FOREIGN KEY (`aluno_id`)
    REFERENCES `escolla`.`alunos` (`id`),
  CONSTRAINT `matriculas_ibfk_2`
    FOREIGN KEY (`disciplina_id`)
    REFERENCES `escolla`.`disciplinas` (`id`),
  CONSTRAINT `matriculas_ibfk_3`
    FOREIGN KEY (`turma_id`)
    REFERENCES `escolla`.`turmas` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`presencas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`presencas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `aluno_id` INT(11) NULL DEFAULT NULL,
  `disciplina_id` INT(11) NULL DEFAULT NULL,
  `data` DATE NULL DEFAULT NULL,
  `faltou` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `aluno_id` (`aluno_id` ASC),
  INDEX `disciplina_id` (`disciplina_id` ASC),
  CONSTRAINT `presencas_ibfk_1`
    FOREIGN KEY (`aluno_id`)
    REFERENCES `escolla`.`alunos` (`id`),
  CONSTRAINT `presencas_ibfk_2`
    FOREIGN KEY (`disciplina_id`)
    REFERENCES `escolla`.`disciplinas` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`presencas_horarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`presencas_horarios` (
  `presenca_id` INT(11) NOT NULL,
  `horario_id` INT(11) NOT NULL,
  PRIMARY KEY (`presenca_id`, `horario_id`),
  INDEX `horario_id` (`horario_id` ASC),
  CONSTRAINT `presencas_horarios_ibfk_1`
    FOREIGN KEY (`presenca_id`)
    REFERENCES `escolla`.`presencas` (`id`),
  CONSTRAINT `presencas_horarios_ibfk_2`
    FOREIGN KEY (`horario_id`)
    REFERENCES `escolla`.`horarios` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `escolla`.`secretarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `escolla`.`secretarios` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `usuario_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `usuario_id` (`usuario_id` ASC),
  CONSTRAINT `secretarios_ibfk_1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `escolla`.`usuarios` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
