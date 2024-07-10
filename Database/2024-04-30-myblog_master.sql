-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: db
-- Creato il: Apr 30, 2024 alle 11:48
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
-- Database: `myblog_master`
--
CREATE DATABASE IF NOT EXISTS `myblog_master` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `myblog_master`;

-- --------------------------------------------------------

--
-- Struttura della tabella `authority`
--

DROP TABLE IF EXISTS `authority`;
CREATE TABLE `authority` (
  `id` tinyint(4) NOT NULL,
  `authority_default` bit(1) NOT NULL,
  `authority_name` enum('ADMIN','WRITER','MEMBER','MODERATOR','GUEST') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `authority`
--

INSERT INTO `authority` (`id`, `authority_default`, `authority_name`) VALUES
(1, b'0', 'ADMIN'),
(2, b'0', 'WRITER'),
(3, b'0', 'MEMBER'),
(4, b'0', 'MODERATOR'),
(5, b'1', 'GUEST');

-- --------------------------------------------------------

--
-- Struttura della tabella `avatar`
--

DROP TABLE IF EXISTS `avatar`;
CREATE TABLE `avatar` (
  `data` blob NOT NULL,
  `filename` varchar(255) NOT NULL,
  `filetype` varchar(10) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `avatar`
--

INSERT INTO `avatar` (`data`, `filename`, `filetype`, `user_id`) VALUES
(0x89504e470d0a1a0a0000000d494844520000002e00000032080600000023ade9d7000000017352474200aece1ce90000000467414d410000b18f0bfc61050000000970485973000012740000127401de661f780000007b494441546843d5c8310100300cc0a07aaa7f6d9d01042c070f33b797c42c6016300b9805cc026601b38059c02c6016300b9805cc026601b38059c02c6016300b9805cc026601b38059c02c6016300b9805cc026601b38059c02c6016300b9805cc026601b38059c02c6016300b9805cc026601b38059c0fcdede031022b15a551be4ee0000000049454e44ae426082, 'image_832748932.png', 'image/png', 4),
(0x4749463839613200320080000000ff33ffffff21f904000700ff002c0000000032003200000233848fa9cbed0fa39cb4da8bb3debcfb0f86e24896e689a6eacab6ee0bc7f24cd7f68de7facef7fe0f0c0a87c4a2f1884c2a2705003b, 'image_9876.gif', 'image/gif', 6);

-- --------------------------------------------------------

--
-- Struttura della tabella `comment`
--

DROP TABLE IF EXISTS `comment`;
CREATE TABLE `comment` (
  `id` int(11) NOT NULL,
  `created_at` datetime(6) DEFAULT NULL,
  `updated_at` datetime(6) DEFAULT NULL,
  `censored` bit(1) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `parent` int(11) DEFAULT NULL,
  `post_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `comment`
--

INSERT INTO `comment` (`id`, `created_at`, `updated_at`, `censored`, `comment`, `parent`, `post_id`, `user_id`) VALUES
(1, '2024-04-30 07:33:04.000000', '2024-04-30 07:33:04.000000', b'0', 'ciao! quale tipo di vino bianco è meglio utilizzare? grazie', NULL, 2, 4),
(2, '2024-04-30 07:33:45.000000', '2024-04-30 07:33:45.000000', b'0', 'ciao! Scegli un vino bianco secco!', 1, 2, 5),
(3, '2024-04-30 12:39:57.000000', '2024-04-30 12:39:57.000000', b'0', 'viene bene anche con le pere', NULL, 3, 9),
(4, '2024-04-30 13:02:06.000000', '2024-04-30 13:02:06.000000', b'0', 'Si può usare il burro normale al posto di quello chiarificato? Oppure c\'è un modo per trasformare il burro normale in chiarificato?', NULL, 4, 5),
(5, '2024-04-30 13:07:33.000000', '2024-04-30 13:07:33.000000', b'1', 'SEI UN CRETINO !', 4, 4, 7);

-- --------------------------------------------------------

--
-- Struttura della tabella `post`
--

DROP TABLE IF EXISTS `post`;
CREATE TABLE `post` (
  `id` int(11) NOT NULL,
  `created_at` datetime(6) DEFAULT NULL,
  `updated_at` datetime(6) DEFAULT NULL,
  `content` text NOT NULL,
  `image` varchar(255) DEFAULT NULL,
  `publication_date` date DEFAULT NULL,
  `title` varchar(255) NOT NULL,
  `tot_comments` smallint(6) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `post`
--

INSERT INTO `post` (`id`, `created_at`, `updated_at`, `content`, `image`, `publication_date`, `title`, `tot_comments`, `user_id`) VALUES
(1, '2024-01-15 12:59:05.000000', '2024-04-15 12:59:07.000000', 'Dove sono nati gli spaghetti alla carbonara? Il Vicolo della Scrofa, per chi conosce Roma, è una delle stradine più caratteristiche e ricche di simboli. Proprio in una trattoria di questa strada, da cui il nome del vicolo, pare sia stata realizzata la prima carbonara, nel 1944. La storia più attendibile su questo primo piatto, infatti, racconta l\'incontro tra gli ingredienti a disposizione dei soldati americani e la fantasia di un cuoco romano. Il risultato fu il prototipo degli spaghetti alla carbonara: uova, bacon (poi guanciale) e formaggio. Man a mano la ricetta è evoluta fino a quella che tutti conosciamo oggi e possiamo apprezzare a casa di amici romani veraci (e voraci!), nelle trattorie come nei ristoranti stellati della Capitale, in tutta Italia e all\'estero, nelle innumerevoli versioni: con o senza pepe, con un tuorlo per persona o l\'aggiunta di almeno un uovo intero, con guanciale o pancetta tesa. Il condimento per la carbonara si prepara in una manciata di minuti, come tante altre prelibatezze romane (pensiamo alla cacio e pepe!). Pensate che occorrono soltanto guanciale speziato tagliato a striscioline, una crema dorata a base di tuorli (nella nostra versione) e tanto Pecorino romano grattugiato al momento.', NULL, '2024-04-15', 'SPAGHETTI ALLA CARBONARA', 0, 6),
(2, '2024-04-30 07:29:53.000000', '2024-04-30 07:29:53.000000', 'Lo zafferano è una spezia antica che si ricava dagli stigmi del fiore omonimo. In principio veniva utilizzato per le sue proprietà coloranti ma col tempo è diventato un ingrediente pregiato con cui si possono realizzare ricette indimenticabili… come il risotto allo zafferano! Questo classico primo piatto è tipico della cucina lombarda dove viene spesso abbinato all’ossobuco, ma è amato in tutte le regioni d’Italia: dai grandi e dai piccoli, dai palati più raffinati a quelli più veraci. Il motivo sta nella semplicità della preparazione e nella magia dorata dello zafferano, che impreziosisce i chicchi di riso con il suo aroma e colore inconfondibile. Per un sapore più intenso vi consigliamo di scegliere i pistilli, ma se preferite andrà benissimo anche lo zafferano in polvere. Come ogni risotto che si rispetti, inoltre, sarà fondamentale la fase della mantecatura per ottenere la cremosità ideale, né troppo brodosa né troppo densa. Se avete sempre voluto sapere come si prepara un risotto allo zafferano perfettamente all’onda, quindi, non vi resta che seguire la ricetta!', NULL, NULL, 'RISOTTO ALLO ZAFFERANO', 2, 8),
(3, '2024-04-30 12:39:29.000000', '2024-04-30 12:39:30.000000', 'La torta di mele è un dolce della tradizione casalinga, soffice e goloso, preparato con tante mele e perfetto per la colazione o la merenda.', NULL, '2024-12-31', 'TORTA DI MELE', 1, 6),
(4, '2024-04-30 12:59:05.000000', '2024-04-30 12:59:07.000000', 'Il filetto al pepe verde è un classico secondo di carne dal gusto avvolgente grazie alla cremosa salsa a base di panna e senape con cui viene servito.', 'https://www.giallozafferano.it/images/184-18454/Filetto-al-pepe-verde_450x300.jpg', '2024-04-30', 'FILETTO AL PEPE VERDE', 1, 8),
(5, '2024-04-16 13:33:02.000000', '2024-04-16 13:33:02.000000', 'L\'orata al forno è un secondo piatto di pesce classico e saporito, preparato con un contorno di gustose patate a spicchi e con tante erbe aromatiche.', NULL, '2024-04-16', 'ORATA AL FORNO', 0, 8);

-- --------------------------------------------------------

--
-- Struttura della tabella `post_tags`
--

DROP TABLE IF EXISTS `post_tags`;
CREATE TABLE `post_tags` (
  `post_id` int(11) NOT NULL,
  `tag_id` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `post_tags`
--

INSERT INTO `post_tags` (`post_id`, `tag_id`) VALUES
(1, 1),
(2, 1),
(4, 2),
(5, 2),
(3, 4),
(4, 6),
(5, 7);

-- --------------------------------------------------------

--
-- Struttura della tabella `preferred_post`
--

DROP TABLE IF EXISTS `preferred_post`;
CREATE TABLE `preferred_post` (
  `user_id` int(11) NOT NULL,
  `post_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `preferred_post`
--

INSERT INTO `preferred_post` (`user_id`, `post_id`) VALUES
(5, 1),
(4, 2),
(4, 4),
(8, 4);

-- --------------------------------------------------------

--
-- Struttura della tabella `rating`
--

DROP TABLE IF EXISTS `rating`;
CREATE TABLE `rating` (
  `created_at` datetime(6) DEFAULT NULL,
  `updated_at` datetime(6) DEFAULT NULL,
  `rate` tinyint(4) NOT NULL CHECK (`rate` > 0 and `rate` < 6),
  `user_id` int(11) NOT NULL,
  `post_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `rating`
--

INSERT INTO `rating` (`created_at`, `updated_at`, `rate`, `user_id`, `post_id`) VALUES
('2024-04-30 07:34:46.000000', '2024-04-30 07:34:46.000000', 5, 4, 2),
('2024-04-30 07:34:46.000000', '2024-04-30 07:34:46.000000', 4, 5, 2),
('2024-04-30 13:05:44.000000', '2024-04-30 13:05:43.000000', 3, 7, 3);

-- --------------------------------------------------------

--
-- Struttura della tabella `reason`
--

DROP TABLE IF EXISTS `reason`;
CREATE TABLE `reason` (
  `reason` varchar(30) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date DEFAULT NULL,
  `severity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `reason`
--

INSERT INTO `reason` (`reason`, `start_date`, `end_date`, `severity`) VALUES
('FLAMING', '2020-01-01', NULL, 6),
('PAROLACCE', '2020-04-30', '2022-12-31', 4),
('PAROLACCE', '2023-01-01', NULL, 3),
('PORNOGRAFIA', '2020-01-01', NULL, 36500);

-- --------------------------------------------------------

--
-- Struttura della tabella `reporting`
--

DROP TABLE IF EXISTS `reporting`;
CREATE TABLE `reporting` (
  `created_at` datetime(6) DEFAULT NULL,
  `updated_at` datetime(6) DEFAULT NULL,
  `status` enum('NEW','IN_PROGRESS','CLOSED_WITH_BAN','CLOSED_WITHOUT_BAN') DEFAULT NULL,
  `comment_id` int(11) NOT NULL,
  `reason_name` varchar(30) DEFAULT NULL,
  `reason_start_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `reporting`
--

INSERT INTO `reporting` (`created_at`, `updated_at`, `status`, `comment_id`, `reason_name`, `reason_start_date`) VALUES
('2024-04-30 13:07:53.000000', '2024-04-30 13:07:55.000000', 'CLOSED_WITH_BAN', 5, 'PAROLACCE', '2023-01-01');

-- --------------------------------------------------------

--
-- Struttura della tabella `tag`
--

DROP TABLE IF EXISTS `tag`;
CREATE TABLE `tag` (
  `id` smallint(6) NOT NULL,
  `tag_name` varchar(50) NOT NULL,
  `visible` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `tag`
--

INSERT INTO `tag` (`id`, `tag_name`, `visible`) VALUES
(1, 'PRIMI PIATTI', b'1'),
(2, 'SECONDI PIATTI', b'1'),
(3, 'FINGER FOOD', b'0'),
(4, 'DOLCI', b'1'),
(5, 'ANTIPASTI', b'1'),
(6, 'CARNE', b'1'),
(7, 'PESCE', b'1');

-- --------------------------------------------------------

--
-- Struttura della tabella `user_authority`
--

DROP TABLE IF EXISTS `user_authority`;
CREATE TABLE `user_authority` (
  `user_id` int(11) NOT NULL,
  `authority_id` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `user_authority`
--

INSERT INTO `user_authority` (`user_id`, `authority_id`) VALUES
(3, 1),
(6, 2),
(8, 2),
(4, 3),
(5, 3),
(7, 3),
(9, 3),
(10, 4);

-- --------------------------------------------------------

--
-- Struttura della tabella `_user`
--

DROP TABLE IF EXISTS `_user`;
CREATE TABLE `_user` (
  `id` int(11) NOT NULL,
  `created_at` datetime(6) DEFAULT NULL,
  `updated_at` datetime(6) DEFAULT NULL,
  `bio` varchar(255) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `enabled` bit(1) NOT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `_user`
--

INSERT INTO `_user` (`id`, `created_at`, `updated_at`, `bio`, `email`, `enabled`, `firstname`, `lastname`, `password`, `username`) VALUES
(3, '2024-04-10 15:56:42.252508', '2024-04-10 15:56:42.252508', NULL, 'admin@admin.abc', b'1', NULL, NULL, '$2a$10$9svUiIG2TaLiEbZI6bePOOVOTBvapRALS38XkklEH7mQXFChnemBu', 'admin'),
(4, '2024-04-14 16:26:49.741130', '2024-04-14 16:26:49.741130', NULL, 'mario@gmail.abc', b'1', NULL, 'gialli', '$2a$10$OEEiHW1ef8juBE8J7sZ48uBkG7rDvxhfxddOm.aGf7jUEKfxnc1ve', 'mario'),
(5, '2024-04-14 16:33:45.885118', '2024-04-14 16:33:45.885118', NULL, 'martina@gmail.abc', b'1', NULL, NULL, '$2a$10$aprKuHipmWmBrATzHIbpPeNz.9CZdhSyziSUyHF7SVv7qT8Ek1.pa', 'martina'),
(6, '2024-04-30 07:25:22.000000', '2024-04-30 07:25:22.000000', NULL, 'william@gmail.abc', b'1', 'william', 'rossi', '$2a$10$aprKuHipmWmBrATzHIbpPeNz.9CZdhSyziSUyHF7SVv7qT8Ek1.pa', 'william'),
(7, '2024-04-30 07:35:35.000000', '2024-04-30 07:35:35.000000', NULL, 'marcello@gmail.abc', b'0', 'marcello', NULL, '$2a$10$aprKuHipmWmBrATzHIbpPeNz.9CZdhSyziSUyHF7SVv7qT8Ek1.pa', 'marcello'),
(8, '2024-04-30 13:00:56.000000', '2024-04-30 13:00:57.000000', NULL, 'walter@gmail.abc', b'1', 'walter', 'verdi', '$2a$10$OEEiHW1ef8juBE8J7sZ48uBkG7rDvxhfxddOm.aGf7jUEKfxnc1ve', 'walter'),
(9, '2024-04-30 13:09:41.000000', '2024-04-30 13:09:42.000000', 'Ciao sono io :-)', 'mafalda@gmail.abc', b'1', NULL, NULL, '$2a$10$aprKuHipmWmBrATzHIbpPeNz.9CZdhSyziSUyHF7SVv7qT8Ek1.pa', 'mafalda'),
(10, '2024-04-09 13:11:39.000000', '2024-04-10 13:11:39.000000', NULL, 'catone@gmail.abc', b'1', 'Catone', 'il Censore', '$2a$10$9svUiIG2TaLiEbZI6bePOOVOTBvapRALS38XkklEH7mQXFChnemBu', 'catone');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `authority`
--
ALTER TABLE `authority`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UK_6ct98mcqw43jw46da6tbapvie` (`authority_name`);

--
-- Indici per le tabelle `avatar`
--
ALTER TABLE `avatar`
  ADD PRIMARY KEY (`user_id`);

--
-- Indici per le tabelle `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FKiv5gvib8r4qx2vunyjd1yu1i2` (`parent`),
  ADD KEY `FKs1slvnkuemjsq2kj4h3vhx7i1` (`post_id`),
  ADD KEY `FKoo5phijy22unidgkw0sipcs74` (`user_id`);

--
-- Indici per le tabelle `post`
--
ALTER TABLE `post`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FKrh90w2rgxa8jj5r0kjlaims1y` (`user_id`);

--
-- Indici per le tabelle `post_tags`
--
ALTER TABLE `post_tags`
  ADD PRIMARY KEY (`post_id`,`tag_id`),
  ADD KEY `FKp7cfgjsujc2vl3p88qfqkpws6` (`tag_id`);

--
-- Indici per le tabelle `preferred_post`
--
ALTER TABLE `preferred_post`
  ADD PRIMARY KEY (`user_id`,`post_id`),
  ADD KEY `FK2vuvtt4joq95mxt09fp7wpd71` (`post_id`);

--
-- Indici per le tabelle `rating`
--
ALTER TABLE `rating`
  ADD PRIMARY KEY (`post_id`,`user_id`),
  ADD KEY `FK740eouanmwdsi22ljt2tnwri8` (`user_id`);

--
-- Indici per le tabelle `reason`
--
ALTER TABLE `reason`
  ADD PRIMARY KEY (`reason`,`start_date`);

--
-- Indici per le tabelle `reporting`
--
ALTER TABLE `reporting`
  ADD PRIMARY KEY (`comment_id`),
  ADD KEY `FK5bngqjyter93t7hm6eox7he75` (`reason_name`,`reason_start_date`);

--
-- Indici per le tabelle `tag`
--
ALTER TABLE `tag`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UK_1r1tyf6uga9k6jwdqnoqwtk2a` (`tag_name`);

--
-- Indici per le tabelle `user_authority`
--
ALTER TABLE `user_authority`
  ADD PRIMARY KEY (`user_id`,`authority_id`),
  ADD KEY `FKgvxjs381k6f48d5d2yi11uh89` (`authority_id`);

--
-- Indici per le tabelle `_user`
--
ALTER TABLE `_user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UK_k11y3pdtsrjgy8w9b6q4bjwrx` (`email`),
  ADD UNIQUE KEY `UK_nlcolwbx8ujaen5h0u2kr2bn2` (`username`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `authority`
--
ALTER TABLE `authority`
  MODIFY `id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT per la tabella `comment`
--
ALTER TABLE `comment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT per la tabella `post`
--
ALTER TABLE `post`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT per la tabella `tag`
--
ALTER TABLE `tag`
  MODIFY `id` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT per la tabella `_user`
--
ALTER TABLE `_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `avatar`
--
ALTER TABLE `avatar`
  ADD CONSTRAINT `FKfnjwc42htd43de0j1rc9ltqv6` FOREIGN KEY (`user_id`) REFERENCES `_user` (`id`);

--
-- Limiti per la tabella `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `FKiv5gvib8r4qx2vunyjd1yu1i2` FOREIGN KEY (`parent`) REFERENCES `comment` (`id`),
  ADD CONSTRAINT `FKoo5phijy22unidgkw0sipcs74` FOREIGN KEY (`user_id`) REFERENCES `_user` (`id`),
  ADD CONSTRAINT `FKs1slvnkuemjsq2kj4h3vhx7i1` FOREIGN KEY (`post_id`) REFERENCES `post` (`id`);

--
-- Limiti per la tabella `post`
--
ALTER TABLE `post`
  ADD CONSTRAINT `FKrh90w2rgxa8jj5r0kjlaims1y` FOREIGN KEY (`user_id`) REFERENCES `_user` (`id`);

--
-- Limiti per la tabella `post_tags`
--
ALTER TABLE `post_tags`
  ADD CONSTRAINT `FKmmtgl185ka210lj8kenewllt1` FOREIGN KEY (`post_id`) REFERENCES `post` (`id`),
  ADD CONSTRAINT `FKp7cfgjsujc2vl3p88qfqkpws6` FOREIGN KEY (`tag_id`) REFERENCES `tag` (`id`);

--
-- Limiti per la tabella `preferred_post`
--
ALTER TABLE `preferred_post`
  ADD CONSTRAINT `FK2vuvtt4joq95mxt09fp7wpd71` FOREIGN KEY (`post_id`) REFERENCES `post` (`id`),
  ADD CONSTRAINT `FKj3il9iydo6w5twulme37cciy1` FOREIGN KEY (`user_id`) REFERENCES `_user` (`id`);

--
-- Limiti per la tabella `rating`
--
ALTER TABLE `rating`
  ADD CONSTRAINT `FK740eouanmwdsi22ljt2tnwri8` FOREIGN KEY (`user_id`) REFERENCES `_user` (`id`),
  ADD CONSTRAINT `FKq23oorcfn21b1owhgcqle69oq` FOREIGN KEY (`post_id`) REFERENCES `post` (`id`);

--
-- Limiti per la tabella `reporting`
--
ALTER TABLE `reporting`
  ADD CONSTRAINT `FK5bngqjyter93t7hm6eox7he75` FOREIGN KEY (`reason_name`,`reason_start_date`) REFERENCES `reason` (`reason`, `start_date`),
  ADD CONSTRAINT `FKf1ajjj57rtajuau9m7emr4qih` FOREIGN KEY (`comment_id`) REFERENCES `comment` (`id`);

--
-- Limiti per la tabella `user_authority`
--
ALTER TABLE `user_authority`
  ADD CONSTRAINT `FKgvxjs381k6f48d5d2yi11uh89` FOREIGN KEY (`authority_id`) REFERENCES `authority` (`id`),
  ADD CONSTRAINT `FKqqm2hu93y192x5qbey5vg8hxj` FOREIGN KEY (`user_id`) REFERENCES `_user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
