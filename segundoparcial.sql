-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-12-2019 a las 00:47:06
-- Versión del servidor: 10.1.40-MariaDB
-- Versión de PHP: 7.1.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `segundoparcial`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `amarre`
--

CREATE TABLE `amarre` (
  `amarreid` varchar(10) NOT NULL,
  `descripcion` varchar(30) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `amarre`
--

INSERT INTO `amarre` (`amarreid`, `descripcion`, `valor`) VALUES
('M01', 'Muelle 1', 500000),
('M02', 'Muelle 2', 700000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `atributos`
--

CREATE TABLE `atributos` (
  `atributoid` varchar(10) NOT NULL,
  `descripcion` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `atributos`
--

INSERT INTO `atributos` (`atributoid`, `descripcion`) VALUES
('NA', 'NA'),
('PAT', 'Patron'),
('SOC', 'Socio'),
('SOCPAT', 'Socio y Patron');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `barco`
--

CREATE TABLE `barco` (
  `matricula` varchar(20) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `numeroAmarre` varchar(10) DEFAULT NULL,
  `identificacion` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `barco`
--

INSERT INTO `barco` (`matricula`, `nombre`, `numeroAmarre`, `identificacion`) VALUES
('B01', 'Santa Rita', 'M01', '123'),
('B02', 'Buque Gloria', 'M02', '789'),
('B03', 'Katamaran', 'M01', '1045699211');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personas`
--

CREATE TABLE `personas` (
  `identificacion` varchar(15) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido` varchar(30) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `correo` varchar(60) DEFAULT NULL,
  `atributoid` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`identificacion`, `nombre`, `apellido`, `telefono`, `direccion`, `correo`, `atributoid`) VALUES
('1045699211', 'Brayan', 'Lopez', '1234567', 'calle falsa123', 'brayan@hotmail.com', 'NA'),
('123', 'pedro', 'Casas', '111111', 'bbbbbb', 'pedro@hotmail.com', 'SOC'),
('1234', 'jesus', 'barril', '12121212', 'calle', 'jesus@hotmail.com', 'SOCPAT'),
('456', 'Malon', 'Perez', '000000', 'calle falsa123', 'a@hotmail.com', 'PAT'),
('789', 'Gabriel', 'Acosta', '000000', 'calle falsa123', 'b@hotmail.com', 'SOCPAT'),
('848484', 'dfjd', 'Casas', '111111', 'bbbbbb', 'juan@hotmail.com', 'SOC');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ruta`
--

CREATE TABLE `ruta` (
  `idRuta` varchar(10) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ruta`
--

INSERT INTO `ruta` (`idRuta`, `nombre`) VALUES
('BAQ-BOG', 'Barranquilla - Bogota'),
('BAQCAL', 'Barranquilla - Cali'),
('BAQMED', 'Barranquilla - Medellin'),
('CAL-BOG', 'Cali - Bogota');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salidas`
--

CREATE TABLE `salidas` (
  `idOperacion` int(11) NOT NULL,
  `matriculaBarco` varchar(20) DEFAULT NULL,
  `identificacion` varchar(15) DEFAULT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `destino` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `salidas`
--

INSERT INTO `salidas` (`idOperacion`, `matriculaBarco`, `identificacion`, `fecha`, `destino`) VALUES
(1, 'B02', '1234', '2019-11-28 02:06:20', 'BAQMED'),
(2, 'B03', '123', '2019-11-28 16:48:32', 'BAQ-BOG'),
(3, 'B01', '123', '2019-11-28 16:48:51', 'CAL-BOG');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `identificacion` varchar(15) DEFAULT NULL,
  `user` varchar(30) NOT NULL,
  `passw` varchar(30) DEFAULT NULL,
  `roll` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`identificacion`, `user`, `passw`, `roll`) VALUES
('1045699211', 'brayan', '1234', 'Admin'),
('123', 'carlos', '1234Ab.', 'Usuario'),
('789', 'gabriel', '1234', 'Usuario'),
('1234', 'jesus', '1234Ab.', 'Usuario'),
('456', 'marlon', '1234', 'Usuario'),
('848484', 'user1', '1234A.', 'Usuario');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `amarre`
--
ALTER TABLE `amarre`
  ADD PRIMARY KEY (`amarreid`);

--
-- Indices de la tabla `atributos`
--
ALTER TABLE `atributos`
  ADD PRIMARY KEY (`atributoid`);

--
-- Indices de la tabla `barco`
--
ALTER TABLE `barco`
  ADD PRIMARY KEY (`matricula`),
  ADD KEY `identificacion` (`identificacion`);

--
-- Indices de la tabla `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`identificacion`),
  ADD KEY `atributoid` (`atributoid`);

--
-- Indices de la tabla `ruta`
--
ALTER TABLE `ruta`
  ADD PRIMARY KEY (`idRuta`);

--
-- Indices de la tabla `salidas`
--
ALTER TABLE `salidas`
  ADD PRIMARY KEY (`idOperacion`),
  ADD KEY `destino` (`destino`),
  ADD KEY `matriculaBarco` (`matriculaBarco`),
  ADD KEY `identificacion` (`identificacion`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`user`),
  ADD KEY `identificacion` (`identificacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `salidas`
--
ALTER TABLE `salidas`
  MODIFY `idOperacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `barco`
--
ALTER TABLE `barco`
  ADD CONSTRAINT `barco_ibfk_1` FOREIGN KEY (`identificacion`) REFERENCES `personas` (`identificacion`);

--
-- Filtros para la tabla `personas`
--
ALTER TABLE `personas`
  ADD CONSTRAINT `personas_ibfk_1` FOREIGN KEY (`atributoid`) REFERENCES `atributos` (`atributoid`);

--
-- Filtros para la tabla `salidas`
--
ALTER TABLE `salidas`
  ADD CONSTRAINT `salidas_ibfk_1` FOREIGN KEY (`destino`) REFERENCES `ruta` (`idRuta`),
  ADD CONSTRAINT `salidas_ibfk_2` FOREIGN KEY (`matriculaBarco`) REFERENCES `barco` (`matricula`),
  ADD CONSTRAINT `salidas_ibfk_3` FOREIGN KEY (`identificacion`) REFERENCES `personas` (`identificacion`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`identificacion`) REFERENCES `personas` (`identificacion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
