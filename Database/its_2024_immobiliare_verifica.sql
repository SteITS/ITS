-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: db
-- Creato il: Mag 20, 2024 alle 15:06
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
-- Database: `its_2024_immobiliare_verifica`
--
CREATE DATABASE its_2024_immobiliare_verifica;
USE its_2024_immobiliare_verifica;
-- --------------------------------------------------------

--
-- Struttura della tabella `annuncio`
--

CREATE TABLE `annuncio` (
  `data_pubblicazione` date DEFAULT NULL COMMENT 'Se la data è NULL o settata nel futuro significa che l''annuncio non è ancora stato pubblicato.',
  `testo_annuncio` varchar(255) NOT NULL,
  `titolo_annuncio` varchar(45) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `annuncio`
--

INSERT INTO `annuncio` (`data_pubblicazione`, `testo_annuncio`, `titolo_annuncio`, `id`) VALUES
('2024-05-08', 'In zona comoda a tutti i servizi, ampio bilocale sito al primo piano di stabile signorile', 'BILOCALE CORSO ROMA 14/1,', 1),
('2024-05-03', 'in dimora d\'epoca del 1700 con servizio di custode e parco condominiale, ampio appartamento ARREDATO', 'APPARTAMENTO STRADA MAIOLE, MORIONDO', 2),
('2024-05-03', 'Proponiamo in vendita appartamento sito al secondo piano con terrazzino e mansarda abitabile.', 'NICHELINO: ZONA CENTRO CON MANSARDA ABITABILE', 3),
('2024-04-26', 'La soluzione è composta da due alloggi di circa 70 mq ciascuno.', 'VILLA BIFAMILIARE', 4),
('2024-05-23', 'Luminoso Loft Open Space in zona San Paolo', 'LOFT FINEMENTE RISTRUTTURATO', 5),
('2024-06-06', 'Dal portoncino blindato si accede alla zona giorno che comprende una cucina abitabile', 'TRILOCALE IN AFFITTO', 6),
(NULL, 'Box auto nelle vicinanze di Piazza Carlina di circa 10 mq.', 'Box auto / Piazza Carlina', 7),
('2024-04-30', 'In via Bard 43, appartamento monolocale al primo piano senza ascensore, in una piccola quadrifamiliare.', 'MONOLOCALE IN AFFITTO', 8),
('2024-05-02', 'L\'appartamento è al primo piano di una palazzina non dotata di ascensore.', 'BILOCALE IN AFFITTO', 9),
('2024-05-10', 'In un condominio anni \'70 di Corso Sebastopoli, posizione ideale .', 'TRILOCALE IN VENDITA', 10),
('2024-07-10', 'Prato Paperino, affascinante baiadera angolare in contesto colonico di recentemente ristrutturazione, con ampio giardino in parte pavimentato, ideale per chi ama la tranquillità. Immobile dotato di ingresso indipendente.', 'BAIADERA IN COLONICA CON GIARDINO', 12);

-- --------------------------------------------------------

--
-- Struttura della tabella `comune`
--

CREATE TABLE `comune` (
  `id` int(11) NOT NULL,
  `cap` int(11) NOT NULL,
  `comune` varchar(34) NOT NULL,
  `provincia` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `comune`
--

INSERT INTO `comune` (`id`, `cap`, `comune`, `provincia`) VALUES
(1, 10024, 'Moncalieri', 'TO'),
(3, 10027, 'Nichelino', 'TO'),
(4, 10100, 'Torino', 'TO'),
(5, 17021, 'Alassio', 'SV'),
(6, 59100, 'Paperino', 'PO'),
(7, 41026, 'Pavullo nel Frignano', 'MO');

-- --------------------------------------------------------

--
-- Struttura della tabella `contratto`
--

CREATE TABLE `contratto` (
  `id` int(11) NOT NULL,
  `tipo_contratto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `contratto`
--

INSERT INTO `contratto` (`id`, `tipo_contratto`) VALUES
(5, 'Affitto'),
(6, 'Affitto - Patti in deroga'),
(4, 'Affitto 4 + 4'),
(3, 'Affitto Agevolato'),
(2, 'Affitto Uso Foresteria'),
(1, 'Vendita');

-- --------------------------------------------------------

--
-- Struttura della tabella `immobile`
--

CREATE TABLE `immobile` (
  `id` int(11) NOT NULL,
  `box` bit(1) NOT NULL COMMENT '0=BOX ASSENTE; 1=BOX PRESENTE',
  `classe_energetica` varchar(3) DEFAULT NULL,
  `indirizzo` varchar(255) NOT NULL,
  `metratura` smallint(6) NOT NULL,
  `numero_bagni` tinyint(4) NOT NULL,
  `numero_stanze` tinyint(4) NOT NULL,
  `prezzo` float NOT NULL,
  `comune` int(11) NOT NULL,
  `contratto` int(11) NOT NULL,
  `tipo_immobile` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `immobile`
--

INSERT INTO `immobile` (`id`, `box`, `classe_energetica`, `indirizzo`, `metratura`, `numero_bagni`, `numero_stanze`, `prezzo`, `comune`, `contratto`, `tipo_immobile`) VALUES
(1, b'0', 'D', 'Corso Roma 14/1', 80, 1, 2, 400, 1, 3, 1),
(2, b'1', 'F', 'Appartamento Strada Maiole, Moriondo', 140, 2, 5, 1500, 1, 5, 1),
(3, b'0', 'C', 'Corso Islanda 57', 60, 1, 3, 600, 1, 2, 1),
(4, b'1', 'C', 'Pressi via Pallavicino', 140, 2, 8, 220000, 3, 1, 7),
(5, b'0', 'C', 'Zona Parco Ruffini', 80, 1, 4, 140000, 4, 1, 3),
(6, b'0', 'C', 'Pozzo Strada', 90, 1, 3, 900, 4, 5, 1),
(7, b'1', '-', 'Piazza Carlina', 10, 0, 1, 250, 4, 5, 4),
(8, b'0', 'C', 'Via Bard', 35, 1, 1, 400, 4, 3, 1),
(9, b'0', 'C', 'Via fratelli Garrone', 50, 1, 2, 500, 4, 6, 1),
(10, b'0', 'D', 'Corso Norvegia 89', 89, 1, 3, 147000, 4, 1, 1),
(11, b'1', 'D', 'Via Gastaldi', 150, 2, 4, 790000, 5, 1, 2),
(12, b'1', 'E', 'Località Betullaia', 1300, 3, 9, 339000, 6, 1, 10);

-- --------------------------------------------------------

--
-- Struttura della tabella `provincia`
--

CREATE TABLE `provincia` (
  `id` varchar(2) NOT NULL,
  `provincia` varchar(50) NOT NULL,
  `regione` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `provincia`
--

INSERT INTO `provincia` (`id`, `provincia`, `regione`) VALUES
('', 'Ascoli Piceno', 9),
('AG', 'Agrigento', 17),
('AL', 'Alessandria', 1),
('AN', 'Ancona', 9),
('AO', 'Aosta', 2),
('AQ', 'L\'Aquila', 10),
('AR', 'Arezzo', 7),
('AT', 'Asti', 1),
('AV', 'Avellino', 12),
('BA', 'Bari', 15),
('BG', 'Bergamo', 3),
('BI', 'Biella', 1),
('BL', 'Belluno', 6),
('BN', 'Benevento', 12),
('BO', 'Bologna', 8),
('BR', 'Brindisi', 15),
('BS', 'Brescia', 3),
('BT', 'Barletta-Andria-Trani', 15),
('BZ', 'Bolzano', 5),
('CA', 'Cagliari', 18),
('CB', 'Campobasso', 11),
('CE', 'Caserta', 12),
('CH', 'Chieti', 10),
('CL', 'Caltanissetta', 17),
('CN', 'Cuneo', 1),
('CO', 'Como', 3),
('CR', 'Cremona', 3),
('CS', 'Cosenza', 16),
('CT', 'Catania', 17),
('CZ', 'Catanzaro', 16),
('EN', 'Enna', 17),
('FC', 'Forlì-Cesena', 8),
('FE', 'Ferrara', 8),
('FG', 'Foggia', 15),
('FI', 'Firenze', 7),
('FM', 'Fermo', 9),
('FR', 'Frosinone', 13),
('GE', 'Genova', 4),
('GO', 'Gorizia', 6),
('GR', 'Grosseto', 7),
('IM', 'Imperia', 4),
('IS', 'Isernia', 11),
('KR', 'Crotone', 16),
('LC', 'Lecco', 3),
('LE', 'Lecce', 15),
('LI', 'Livorno', 7),
('LO', 'Lodi', 3),
('LT', 'Latina', 13),
('LU', 'Lucca', 7),
('MB', 'Monza-Brianza', 3),
('MC', 'Macerata', 9),
('ME', 'Messina', 17),
('MI', 'Milano', 3),
('MN', 'Mantova', 3),
('MO', 'Modena', 8),
('MS', 'Massa-Carrara', 7),
('MT', 'Matera', 14),
('NA', 'Napoli', 12),
('NO', 'Novara', 1),
('NU', 'Nuoro', 18),
('OR', 'Oristano', 18),
('PA', 'Palermo', 17),
('PC', 'Piacenza', 8),
('PD', 'Padova', 19),
('PE', 'Pescara', 10),
('PG', 'Perugia', 20),
('PI', 'Pisa', 7),
('PN', 'Pordenone', 6),
('PO', 'Prato', 7),
('PR', 'Parma', 8),
('PT', 'Pistoia', 7),
('PU', 'Pesaro-Urbino', 9),
('PV', 'Pavia', 3),
('PZ', 'Potenza', 14),
('RA', 'Ravenna', 8),
('RC', 'Reggio di Calabria', 16),
('RE', 'Reggio nell\'Emilia', 8),
('RG', 'Ragusa', 17),
('RI', 'Rieti', 13),
('RM', 'Roma', 13),
('RN', 'Rimini', 8),
('RO', 'Rovigo', 19),
('SA', 'Salerno', 12),
('SI', 'Siena', 1),
('SO', 'Sondrio', 3),
('SP', 'La Spezia', 4),
('SR', 'Siracusa', 17),
('SS', 'Sassari', 18),
('SU', 'Sud Sardegna', 18),
('SV', 'Savona', 4),
('TA', 'Taranto', 15),
('TE', 'Teramo', 10),
('TN', 'Trento', 5),
('TO', 'Torino', 1),
('TP', 'Trapani', 17),
('TR', 'Terni', 20),
('TS', 'Trieste', 6),
('TV', 'Treviso', 19),
('UD', 'Udine', 6),
('VA', 'Varese', 3),
('VB', 'Verbania', 1),
('VC', 'Vercelli', 1),
('VE', 'Venezia', 19),
('VI', 'Vicenza', 19),
('VR', 'Verona', 19),
('VT', 'Viterbo', 13),
('VV', 'Vibo Valenza', 16);

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
-- Struttura della tabella `tipo_immobile`
--

CREATE TABLE `tipo_immobile` (
  `id` int(11) NOT NULL,
  `tipo_immobile` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `tipo_immobile`
--

INSERT INTO `tipo_immobile` (`id`, `tipo_immobile`) VALUES
(1, 'Appartamento'),
(5, 'Baita'),
(4, 'Box'),
(10, 'Cascinale'),
(3, 'Loft'),
(2, 'Villa'),
(7, 'Villa bifamiliare');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `annuncio`
--
ALTER TABLE `annuncio`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `comune`
--
ALTER TABLE `comune`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FKglxr1bkjfwto627wielvet2mg` (`provincia`);

--
-- Indici per le tabelle `contratto`
--
ALTER TABLE `contratto`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UK_qbgg6mjope7oun6qu51806m4r` (`tipo_contratto`);

--
-- Indici per le tabelle `immobile`
--
ALTER TABLE `immobile`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FKixpg5s8frc0s1o829m5a6r3vy` (`comune`),
  ADD KEY `FKnjt36rryf9ftb0yt8yraxvuih` (`contratto`),
  ADD KEY `FKdbl4qpn3jptk7lues4jyo923j` (`tipo_immobile`);

--
-- Indici per le tabelle `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UK_oi52nn1v26jl0dxh6hc47g9ax` (`provincia`),
  ADD KEY `FK_provincia_regione` (`regione`);

--
-- Indici per le tabelle `regione`
--
ALTER TABLE `regione`
  ADD PRIMARY KEY (`codice_regione`),
  ADD UNIQUE KEY `denominazione` (`denominazione`);

--
-- Indici per le tabelle `tipo_immobile`
--
ALTER TABLE `tipo_immobile`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UK_8vmv54172hqf048pe30deemgc` (`tipo_immobile`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `comune`
--
ALTER TABLE `comune`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT per la tabella `contratto`
--
ALTER TABLE `contratto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT per la tabella `immobile`
--
ALTER TABLE `immobile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT per la tabella `regione`
--
ALTER TABLE `regione`
  MODIFY `codice_regione` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT per la tabella `tipo_immobile`
--
ALTER TABLE `tipo_immobile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `annuncio`
--
ALTER TABLE `annuncio`
  ADD CONSTRAINT `FKdc2etlisk7ih988y0bbqq0rxu` FOREIGN KEY (`id`) REFERENCES `immobile` (`id`);

--
-- Limiti per la tabella `comune`
--
ALTER TABLE `comune`
  ADD CONSTRAINT `FKglxr1bkjfwto627wielvet2mg` FOREIGN KEY (`provincia`) REFERENCES `provincia` (`id`);

--
-- Limiti per la tabella `immobile`
--
ALTER TABLE `immobile`
  ADD CONSTRAINT `FKdbl4qpn3jptk7lues4jyo923j` FOREIGN KEY (`tipo_immobile`) REFERENCES `tipo_immobile` (`id`),
  ADD CONSTRAINT `FKixpg5s8frc0s1o829m5a6r3vy` FOREIGN KEY (`comune`) REFERENCES `comune` (`id`),
  ADD CONSTRAINT `FKnjt36rryf9ftb0yt8yraxvuih` FOREIGN KEY (`contratto`) REFERENCES `contratto` (`id`);

--
-- Limiti per la tabella `provincia`
--
ALTER TABLE `provincia`
  ADD CONSTRAINT `FK_provincia_regione` FOREIGN KEY (`regione`) REFERENCES `regione` (`codice_regione`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
