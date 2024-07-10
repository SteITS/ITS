-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: db
-- Creato il: Mag 10, 2024 alle 12:25
-- Versione del server: 11.3.2-MariaDB-1:11.3.2+maria~ubu2204
-- Versione PHP: 8.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `its_2024_studenti`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `esame`
--

CREATE TABLE `esame` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `esame`
--

INSERT INTO `esame` (`id`, `nome`) VALUES
(2, 'geografia'),
(1, 'matematica');

-- --------------------------------------------------------

--
-- Struttura della tabella `esame_sostenuto`
--

CREATE TABLE `esame_sostenuto` (
  `id` int(11) NOT NULL,
  `id_esame` int(11) NOT NULL,
  `id_studente` int(11) NOT NULL,
  `voto` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `esame_sostenuto`
--

INSERT INTO `esame_sostenuto` (`id`, `id_esame`, `id_studente`, `voto`) VALUES
(1, 2, 1, 20),
(2, 1, 3, 28),
(3, 1, 5, 19),
(4, 2, 2, 30),
(5, 2, 3, 18),
(6, 1, 2, 25),
(7, 2, 4, 27),
(8, 2, 6, 26),
(9, 2, 5, 29),
(10, 1, 1, 22),
(11, 2, 4, 28),
(12, 2, 5, 30);

-- --------------------------------------------------------

--
-- Struttura della tabella `studente`
--

CREATE TABLE `studente` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cognome` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `studente`
--

INSERT INTO `studente` (`id`, `nome`, `cognome`) VALUES
(1, 'giuseppe', 'bilbao'),
(2, 'paolo', 'bisanzio'),
(3, 'gianni', 'micheli'),
(4, 'teodoro', 'bundo'),
(5, 'carolina', 'martini'),
(6, 'giusy', 'hoffman'),
(7, 'lucia', 'severini');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `esame`
--
ALTER TABLE `esame`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Indici per le tabelle `esame_sostenuto`
--
ALTER TABLE `esame_sostenuto`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_esame` (`id_esame`),
  ADD KEY `id_studente` (`id_studente`);

--
-- Indici per le tabelle `studente`
--
ALTER TABLE `studente`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `esame`
--
ALTER TABLE `esame`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT per la tabella `esame_sostenuto`
--
ALTER TABLE `esame_sostenuto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT per la tabella `studente`
--
ALTER TABLE `studente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `esame_sostenuto`
--
ALTER TABLE `esame_sostenuto`
  ADD CONSTRAINT `esame_sostenuto_ibfk_1` FOREIGN KEY (`id_esame`) REFERENCES `esame` (`id`),
  ADD CONSTRAINT `esame_sostenuto_ibfk_2` FOREIGN KEY (`id_studente`) REFERENCES `studente` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
