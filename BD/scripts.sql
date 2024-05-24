CREATE DATABASE IF NOT EXISTS gestionis CHARACTER SET utf8;
SET DEFAULT_STORAGE_ENGINE=INNODB;

USE gestionis;

CREATE TABLE IF NOT EXISTS usuario (
apodo VARCHAR(15) PRIMARY KEY,
nombre VARCHAR(20) NOT NULL,
apellidos VARCHAR(45),
correo VARCHAR(60) NOT NULL UNIQUE,
contrasenya VARCHAR(255) NOT NULL,
salt VARCHAR(255) NOT NULL,
direccion VARCHAR(60),
telefono VARCHAR(9),
experiencia INT NOT NULL,
foto BLOB NOT NULL,
nivel INT NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS cuenta (
numCuenta INT PRIMARY KEY AUTO_INCREMENT,
apodoUsuario VARCHAR(45) NOT NULL,
pasivos DECIMAL(10,2) NOT NULL,
FOREIGN KEY (apodoUsuario) REFERENCES usuario(apodo) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS categoriaGasto (
idCategoria INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(45) NOT NULL,
color INT NOT NULL,
limite DECIMAL(10,2)
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
idCategoria INT NOT NULL,
tipo VARCHAR(45) NOT NULL,
comentarios VARCHAR(300),
fecha DATE NOT NULL,
hora TIME NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta) ON DELETE CASCADE,
FOREIGN KEY (idCategoria) REFERENCES categoriaGasto(idCategoria) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS ingreso (
idIngreso INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
nombre VARCHAR(45) NOT NULL,
cantidad FLOAT NOT NULL,
tipo VARCHAR(45) NOT NULL,
idCategoria INT NULL,
comentarios VARCHAR(300),
fecha DATE NOT NULL,
hora TIME NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta) ON DELETE CASCADE,
FOREIGN KEY (idCategoria) REFERENCES categoriaIngreso(idCategoria) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS activo (
idActivo INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NULL,
nombre VARCHAR(45) NOT NULL,
valorAdquisicion FLOAT NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS coche (
idActivo INT PRIMARY KEY AUTO_INCREMENT,
marca VARCHAR(45) NOT NULL,
modelo VARCHAR(45) NOT NULL,
anyo DATE NOT NULL,
FOREIGN KEY (idActivo) REFERENCES activo(idActivo) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS bienRaiz (
idActivo INT PRIMARY KEY AUTO_INCREMENT,
tipo VARCHAR(45) NOT NULL,
ubicacion VARCHAR(45) NOT NULL,
construcNueva TINYINT NOT NULL,
FOREIGN KEY (idActivo) REFERENCES activo(idActivo) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS deuda (
idDeuda INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
titulo VARCHAR(45) UNIQUE NOT NULL,
descripcion VARCHAR(45),
debo BOOL,
cantidad FLOAT NOT NULL,
fechaCreacion DATE NOT NULL,
fechaVencimiento DATE NOT NULL,
anyadirRecordatorio BOOL NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS nota (
idNota INT PRIMARY KEY AUTO_INCREMENT,
idDeuda INT NULL,
apodoUsuario VARCHAR(15) NOT NULL,
titulo VARCHAR(45) NOT NULL,
alarma BOOL NOT NULL,
color INT NOT NULL,
descripcion VARCHAR(45),
fechaRecordatorio DATE,
FOREIGN KEY (idDeuda) REFERENCES deuda(idDeuda) ON DELETE CASCADE,
FOREIGN KEY (apodoUsuario) REFERENCES usuario(apodo) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS notificacion (
idNotificacion INT PRIMARY KEY AUTO_INCREMENT,
numCuenta INT NOT NULL,
titulo VARCHAR(45) NOT NULL,
idCategoria INT NOT NULL,
descripcion VARCHAR(255) NOT NULL,
recomendacion VARCHAR(255) NOT NULL,
fecha DATE NOT NULL,
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta) ON DELETE CASCADE,
FOREIGN KEY (idCategoria) REFERENCES categoriaGasto(idCategoria) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS limite (
numCuenta INT NOT NULL,
idCategoria INT NOT NULL,
limite DECIMAL(10,2),
PRIMARY KEY (numCuenta,idCategoria),
FOREIGN KEY (numCuenta) REFERENCES cuenta(numCuenta) ON DELETE CASCADE,
FOREIGN KEY (idCategoria) REFERENCES categoriaGasto(idCategoria) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS nivel (
idNivel INT PRIMARY KEY AUTO_INCREMENT,
nivel INT NOT NULL,
xpRequerido INT NOT NULL
);

INSERT INTO nivel (nivel, xpRequerido) VALUES (1, 100), (2, 200), (3, 400), (4, 800), (5, 1600), (6, 999999);

DELIMITER //

CREATE TRIGGER before_update_usuario
BEFORE UPDATE ON usuario
FOR EACH ROW
BEGIN
DECLARE new_level INT;
SET new_level = (SELECT idNivel FROM nivel WHERE NEW.experiencia >= xpRequerido ORDER BY xpRequerido DESC LIMIT 1);
SET NEW.nivel = new_level;
END; //

DELIMITER ;

INSERT INTO categoriaIngreso (idCategoria, nombre)
VALUES (NULL, "Inversión");

INSERT INTO categoriaIngreso (idCategoria, nombre)
VALUES (NULL, "Venta");

INSERT INTO categoriaGasto (idCategoria, nombre, color, limite)
VALUES (1, "Restaurante", -53714, 150);

INSERT INTO categoriaGasto (idCategoria, nombre, color, limite)
VALUES (2, "Supermercado", -13729281, 150);

INSERT INTO categoriaGasto (idCategoria, nombre, color, limite)
VALUES (3, "Gasolina", -2494, 150);

INSERT INTO categoriaGasto (idCategoria, nombre, color, limite)
VALUES (4, "Entretenimiento", -12386472, 150);

INSERT INTO categoriaGasto (idCategoria, nombre, color, limite)
VALUES (5, "Luz", -5670662, 150);