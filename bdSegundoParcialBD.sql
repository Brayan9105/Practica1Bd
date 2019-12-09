
CREATE DATABASE SegundoParcial;
USE SegundoParcial;

CREATE TABLE atributos(
atributoid VARCHAR(10) PRIMARY KEY,
descripcion VARCHAR(30)
);

CREATE TABLE personas(
identificacion VARCHAR(15) PRIMARY KEY, 
nombre VARCHAR(30), 
apellido VARCHAR(30), 
telefono VARCHAR(15), 
direccion VARCHAR(50),
correo VARCHAR(60),
atributoid VARCHAR(10),
FOREIGN KEY(atributoid) REFERENCES atributos(atributoid)
);

CREATE TABLE amarre(
amarreid VARCHAR(10) PRIMARY KEY,
descripcion VARCHAR(30),
valor INT
);

CREATE TABLE barco (
matricula VARCHAR(20) PRIMARY KEY, 
nombre VARCHAR(30), 
numeroAmarre VARCHAR(10),
identificacion VARCHAR(15),
FOREIGN KEY(identificacion) REFERENCES personas(identificacion)
);

CREATE TABLE ruta(
idRuta VARCHAR(10) PRIMARY KEY, 
nombre VARCHAR(30)
);


CREATE TABLE salidas(
idOperacion int PRIMARY KEY auto_increment, 
matriculaBarco  VARCHAR(20),
identificacion VARCHAR(15), 
fecha TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP, 
destino VARCHAR(10),
FOREIGN KEY(destino) REFERENCES ruta(idRuta),
FOREIGN KEY(matriculaBarco) REFERENCES barco(matricula), 
FOREIGN KEY(identificacion) REFERENCES personas(identificacion)
)auto_increment=1;


CREATE TABLE usuarios(
identificacion VARCHAR(15),
user VARCHAR(30) PRIMARY KEY,
passw VARCHAR(30),
roll VARCHAR(20),
FOREIGN KEY(identificacion) REFERENCES personas(identificacion)
);



INSERT INTO atributos
(atributoid, descripcion)
VALUES
('SOC', 'Socio'),
('PAT', 'Patron'),
('SOCPAT', 'Socio y Patron'),
('NA', 'NA');

INSERT INTO personas
(identificacion, nombre, apellido, telefono, direccion, correo, atributoid)
VALUES
('1045699211', 'Brayan','Lopez','1234567','calle falsa123', 'brayan@hotmail.com','NA'),
('123', 'Carlos','Rodriguez','000000','calle falsa123', 'carlos@hotmail.com','SOC'),
('456', 'Malon','Perez','000000','calle falsa123', 'a@hotmail.com','PAT'),
('789', 'Gabriel','Acosta','000000','calle falsa123', 'b@hotmail.com','SOCPAT');

INSERT INTO usuarios
(identificacion, user, passw, roll)
VALUES
('1045699211','brayan','1234','Admin'),
('123','carlos','1234','Usuario'),
('456','marlon','1234','Usuario'),
('789','gabriel','1234','Usuario');

INSERT INTO amarre
(amarreid, descripcion, valor)
VALUES
('M01', 'Muelle 1', 500000),
('M02', 'Muelle 2', 700000);

INSERT INTO ruta
(idRuta, nombre)
VALUES
('BAQMED', 'Barranquilla - Medellin'),
('BAQCAL', 'Barranquilla - Cali');

INSERT INTO barco
(matricula, nombre, numeroAmarre, identificacion)
VALUES
('B01', 'Santa Rita', 'M01', '123'),
('B02', 'Gloria', 'M02', '789');



SELECT socios.nombre AS Socio FROM barco
INNER JOIN socios ON socios.identificacion = barco.identificacionSocio
WHERE matricula = '1233'

