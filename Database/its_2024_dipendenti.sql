-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Mag 18, 2024 alle 13:43
-- Versione del server: 10.4.28-MariaDB
-- Versione PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `its_2024_dipendenti`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `azienda`
--

CREATE TABLE `azienda` (
  `codice_azienda` int(11) NOT NULL,
  `ragione_sociale` varchar(255) NOT NULL,
  `regione` int(11) NOT NULL,
  `settore` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `azienda`
--

INSERT INTO `azienda` (`codice_azienda`, `ragione_sociale`, `regione`, `settore`) VALUES
(1, 'Confetture Rossi SpA', 8, 2),
(2, 'TopGear Srl', 3, 3),
(3, 'Bendaggioni SpA', 16, 6),
(4, 'Backend Grop Srl', 18, 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `dipendente`
--

CREATE TABLE `dipendente` (
  `codice_dipendente` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cognome` varchar(100) NOT NULL,
  `reddito` decimal(8,2) NOT NULL,
  `trattenute` decimal(3,2) NOT NULL COMMENT 'Ad es. 23% equilavale a 0.23',
  `mansione` int(11) NOT NULL,
  `azienda` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `dipendente`
--

INSERT INTO `dipendente` (`codice_dipendente`, `nome`, `cognome`, `reddito`, `trattenute`, `mansione`, `azienda`) VALUES
(1, 'Guglielmo', 'Pistoni', 20500.00, 0.28, 1, 2),
(3, 'Lucia', 'Biella', 20600.00, 0.28, 1, 2),
(4, 'Carlo', 'Cambio', 69800.00, 0.33, 6, 2),
(5, 'Rebecca', 'Sterzante', 20450.00, 0.28, 1, 2),
(6, 'Giulia', 'Pilota', 69300.00, 0.34, 5, 2),
(7, 'Rossella', 'Pesca', 22000.00, 0.29, 2, 1),
(8, 'Sabrina', 'Amarena', 22100.00, 0.29, 2, 1),
(9, 'Sergio', 'Limoni', 21300.00, 0.28, 1, 1),
(10, 'Andrea', 'Cerasa', 22100.00, 0.29, 2, 1),
(11, 'Marco', 'Fragola', 22100.00, 0.28, 1, 1),
(12, 'Maria', 'Sanguigna', 28700.00, 0.30, 3, 3),
(13, 'Marta', 'Zero', 28600.00, 0.30, 3, 3),
(14, 'Michele', 'Cannula', 28600.00, 0.30, 3, 3),
(15, 'Mafalda', 'Aghetti', 29200.00, 0.30, 3, 3),
(16, 'Martina', 'Fasciame', 28900.00, 0.30, 3, 3),
(17, 'Debora', 'Tutore', 70500.00, 0.34, 4, 3),
(18, 'Gianni', 'Femorini', 70000.00, 0.34, 4, 3),
(19, 'Guenda', 'Radio', 70800.00, 0.34, 4, 3),
(20, 'Massimo', 'Rustico', 22050.00, 0.28, 2, 4),
(21, 'Francesca', 'Golandi', 22000.00, 0.28, 2, 4),
(22, 'Fernando', 'Acca', 22000.00, 0.28, 2, 4),
(23, 'Federica', 'Netti', 22100.00, 0.28, 2, 4),
(24, 'Rossana', 'Debiani', 22450.00, 0.28, 2, 4),
(25, 'Domitilla', 'Giavazza', 22150.00, 0.28, 2, 4),
(26, 'Sara', 'Aspetto', 22250.00, 0.28, 2, 4),
(27, 'Luca', 'Candido', 26500.00, 0.29, 7, 1),
(28, 'Gaia', 'Fruttosio', 59500.00, 0.33, 6, 1),
(29, 'Fabrizio', 'Vellutato', 26500.00, 0.29, 7, 1),
(30, 'Dario', 'Vettore', 29600.00, 0.29, 7, 2),
(31, 'Lucilla', 'Cristalli', 29650.00, 0.29, 7, 2);

-- --------------------------------------------------------

--
-- Struttura della tabella `mansione`
--

CREATE TABLE `mansione` (
  `codice_mansione` int(11) NOT NULL,
  `denominazione` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `mansione`
--

INSERT INTO `mansione` (`codice_mansione`, `denominazione`) VALUES
(1, 'operaio'),
(2, 'impiegato'),
(3, 'operatore sanitario'),
(4, 'medico'),
(5, 'direttore'),
(6, 'manager'),
(7, 'operaio specializzato');

-- --------------------------------------------------------

--
-- Struttura della tabella `regione`
--

CREATE TABLE `regione` (
  `codice_regione` int(11) NOT NULL,
  `denominazione` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `regione`
--

INSERT INTO `regione` (`codice_regione`, `denominazione`) VALUES
(10, 'abruzzo'),
(14, 'basilicata'),
(16, 'calabria'),
(12, 'campania'),
(8, 'emilia romagna'),
(6, 'friuli venezia giulia'),
(13, 'lazio'),
(4, 'liguria'),
(3, 'lombardia'),
(9, 'marche'),
(11, 'molise'),
(1, 'piemonte'),
(15, 'puglia'),
(18, 'sardegna'),
(17, 'sicilia'),
(7, 'toscana'),
(5, 'trentino alto adige'),
(20, 'umbria'),
(2, 'valle d\'aosta'),
(19, 'veneto');

-- --------------------------------------------------------

--
-- Struttura della tabella `settore`
--

CREATE TABLE `settore` (
  `codice_settore` int(11) NOT NULL,
  `denominazione` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `settore`
--

INSERT INTO `settore` (`codice_settore`, `denominazione`) VALUES
(2, 'industria alimentare'),
(1, 'industria ICT'),
(3, 'industria metalmeccanica'),
(6, 'servizi sanitari');

-- --------------------------------------------------------

--
-- Struttura della tabella `versamento`
--

CREATE TABLE `versamento` (
  `codice_dipendente` int(11) NOT NULL,
  `data_versamento` date NOT NULL,
  `importo` decimal(7,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `versamento`
--

INSERT INTO `versamento` (`codice_dipendente`, `data_versamento`, `importo`) VALUES
(1, '2024-03-09', 6765.00),
(3, '2024-03-09', 6798.00),
(4, '2024-03-08', 23034.00),
(5, '2024-03-10', 6748.50),
(6, '2024-03-18', 22869.00),
(7, '2020-03-11', 7260.00),
(8, '2024-03-18', 7293.00),
(9, '2024-03-11', 7029.00),
(10, '2024-03-05', 7293.00),
(11, '2024-03-12', 7293.00),
(12, '2024-03-15', 9471.00),
(13, '2024-03-13', 9438.00),
(14, '2024-03-03', 9438.00),
(15, '2024-03-23', 9636.00),
(16, '2024-03-23', 9537.00),
(17, '2024-03-23', 23265.00),
(18, '2024-03-23', 23100.00),
(19, '2024-03-23', 23364.00),
(20, '2024-03-23', 7276.50),
(21, '2024-03-23', 7260.00),
(22, '2024-03-23', 7260.00),
(23, '2024-03-23', 7293.00),
(24, '2024-03-23', 7408.50),
(25, '2024-03-11', 7309.50),
(26, '2024-03-13', 7342.50),
(27, '2024-03-02', 8745.00),
(28, '2024-03-23', 19635.00),
(29, '2024-03-29', 8745.00),
(30, '2024-03-25', 9768.00);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `azienda`
--
ALTER TABLE `azienda`
  ADD PRIMARY KEY (`codice_azienda`),
  ADD KEY `regione` (`regione`),
  ADD KEY `settore` (`settore`);

--
-- Indici per le tabelle `dipendente`
--
ALTER TABLE `dipendente`
  ADD PRIMARY KEY (`codice_dipendente`),
  ADD KEY `mansione` (`mansione`),
  ADD KEY `azienda` (`azienda`);

--
-- Indici per le tabelle `mansione`
--
ALTER TABLE `mansione`
  ADD PRIMARY KEY (`codice_mansione`);

--
-- Indici per le tabelle `regione`
--
ALTER TABLE `regione`
  ADD PRIMARY KEY (`codice_regione`),
  ADD UNIQUE KEY `denominazione` (`denominazione`);

--
-- Indici per le tabelle `settore`
--
ALTER TABLE `settore`
  ADD PRIMARY KEY (`codice_settore`),
  ADD UNIQUE KEY `UNIQ_8D93D649452C9EC5` (`denominazione`);

--
-- Indici per le tabelle `versamento`
--
ALTER TABLE `versamento`
  ADD PRIMARY KEY (`codice_dipendente`,`data_versamento`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `azienda`
--
ALTER TABLE `azienda`
  MODIFY `codice_azienda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT per la tabella `dipendente`
--
ALTER TABLE `dipendente`
  MODIFY `codice_dipendente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT per la tabella `mansione`
--
ALTER TABLE `mansione`
  MODIFY `codice_mansione` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT per la tabella `regione`
--
ALTER TABLE `regione`
  MODIFY `codice_regione` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT per la tabella `settore`
--
ALTER TABLE `settore`
  MODIFY `codice_settore` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `azienda`
--
ALTER TABLE `azienda`
  ADD CONSTRAINT `azienda_ibfk_1` FOREIGN KEY (`regione`) REFERENCES `regione` (`codice_regione`),
  ADD CONSTRAINT `azienda_ibfk_2` FOREIGN KEY (`settore`) REFERENCES `settore` (`codice_settore`);

--
-- Limiti per la tabella `dipendente`
--
ALTER TABLE `dipendente`
  ADD CONSTRAINT `dipendente_ibfk_1` FOREIGN KEY (`mansione`) REFERENCES `mansione` (`codice_mansione`),
  ADD CONSTRAINT `dipendente_ibfk_2` FOREIGN KEY (`azienda`) REFERENCES `azienda` (`codice_azienda`);

--
-- Limiti per la tabella `versamento`
--
ALTER TABLE `versamento`
  ADD CONSTRAINT `versamento_ibfk_1` FOREIGN KEY (`codice_dipendente`) REFERENCES `dipendente` (`codice_dipendente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
