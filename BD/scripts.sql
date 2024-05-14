CREATE DATABASE IF NOT EXISTS gestionis CHARACTER SET utf8;
SET DEFAULT_STORAGE_ENGINE=INNODB;

USE gestionis;

CREATE TABLE IF NOT EXISTS usuario (
apodo VARCHAR(15) PRIMARY KEY,
correo VARCHAR(60) NOT NULL UNIQUE,
nombre VARCHAR(20) NOT NULL,
apellidos VARCHAR(45),
contrasenya VARCHAR(60) NOT NULL,
direccion VARCHAR(60),
telefono VARCHAR(9),
experiencia INT NOT NULL,
foto BLOB NOT NULL
);

CREATE TABLE IF NOT EXISTS cuenta (
numCuenta INT PRIMARY KEY AUTO_INCREMENT,
apodoUsuario VARCHAR(45) NOT NULL,
totalDinero FLOAT NOT NULL,
pasivos FLOAT NOT NULL,
FOREIGN KEY (apodoUsuario) REFERENCES usuario(apodo)
);

CREATE TABLE IF NOT EXISTS notificacion (
idNotificacion INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
titulo VARCHAR(45) NOT NULL,
categoria VARCHAR(45) NOT NULL,
descripcion VARCHAR(45),
fecha DATE NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta)
);

CREATE TABLE IF NOT EXISTS categoriaGasto (
idCategoria INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(45) NOT NULL,
color INT NOT NULL
);

CREATE TABLE IF NOT EXISTS categoriaIngreso (
idCategoria INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(45) NOT NULL
);

CREATE TABLE IF NOT EXISTS gasto (
idGasto INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
nombre VARCHAR(45) NOT NULL,
cantidad FLOAT NOT NULL,
categoria INT NOT NULL,
tipo VARCHAR(45) NOT NULL,
comentarios VARCHAR(300),
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta),
FOREIGN KEY (categoria) REFERENCES categoriaGasto(idCategoria)
);

CREATE TABLE IF NOT EXISTS ingreso (
idIngreso INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
nombre VARCHAR(45) NOT NULL,
cantidad FLOAT NOT NULL,
tipo VARCHAR(45) NOT NULL,
categoria INT NOT NULL,
comentarios VARCHAR(300),
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta),
FOREIGN KEY (categoria) REFERENCES categoriaIngreso(idCategoria)
);

CREATE TABLE IF NOT EXISTS activo (
idActivo INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NULL,
nombre VARCHAR(45) NOT NULL,
valorAdquisicion FLOAT NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES Cuenta(numCuenta)
);

CREATE TABLE IF NOT EXISTS coche (
idActivo INT PRIMARY KEY AUTO_INCREMENT,
marca VARCHAR(45) NOT NULL,
modelo VARCHAR(45) NOT NULL,
anyo DATE NOT NULL,
FOREIGN KEY (idActivo) REFERENCES Activo(idActivo)
);

CREATE TABLE IF NOT EXISTS bienRaiz (
idActivo INT PRIMARY KEY AUTO_INCREMENT,
tipo VARCHAR(45) NOT NULL,
ubicacion VARCHAR(45) NOT NULL,
construcNueva TINYINT NOT NULL,
FOREIGN KEY (idActivo) REFERENCES Activo(idActivo)
);

CREATE TABLE IF NOT EXISTS deuda (
idDeuda INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
titulo VARCHAR(45) NOT NULL,
descripcion VARCHAR(45),
cantidad FLOAT NOT NULL,
fechaLimite DATE NOT NULL,
interes FLOAT NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta)
);

CREATE TABLE IF NOT EXISTS nota (
idNota INT PRIMARY KEY AUTO_INCREMENT,
idDeuda INT NOT NULL NOT NULL,
apodoUsuario VARCHAR(15) NOT NULL,
descripcion VARCHAR(45),
fechaRecoradtorio DATE,
FOREIGN KEY (idDeuda) REFERENCES deuda(idDeuda),
FOREIGN KEY (apodoUsuario) REFERENCES usuario(apodo)
);