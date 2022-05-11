-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 11 Maj 2022, 22:10
-- Wersja serwera: 10.4.11-MariaDB
-- Wersja PHP: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `sklep`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `obiekty`
--

CREATE TABLE `obiekty` (
  `ID` int(11) NOT NULL,
  `Nazwa_obiektu` text NOT NULL,
  `Adres` text NOT NULL,
  `Kod_pocztowy` text NOT NULL,
  `Miejscowość` text NOT NULL,
  `Telefon` text NOT NULL,
  `Liczba_pracowników` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `obiekty`
--

INSERT INTO `obiekty` (`ID`, `Nazwa_obiektu`, `Adres`, `Kod_pocztowy`, `Miejscowość`, `Telefon`, `Liczba_pracowników`) VALUES
(1, 'Sklep', 'niewiadoma 22', '66-420', 'Kaczygrad', '420696965', 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pracownicy`
--

CREATE TABLE `pracownicy` (
  `ID` int(11) NOT NULL,
  `ID_obiektu` int(11) NOT NULL,
  `Imie` text NOT NULL,
  `Nazwisko` text NOT NULL,
  `Miasto` text NOT NULL,
  `Adres` text NOT NULL,
  `Płeć` text NOT NULL,
  `Kod_Pocztowy` text NOT NULL,
  `Data_Urodzenia` date NOT NULL,
  `Kraj_Urodzenia` text NOT NULL,
  `E-mail` text DEFAULT NULL,
  `Numer_Kontaktowy` text NOT NULL,
  `Stanowisko` text DEFAULT NULL,
  `Pesel` text NOT NULL,
  `Pochodzenie` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `pracownicy`
--

INSERT INTO `pracownicy` (`ID`, `ID_obiektu`, `Imie`, `Nazwisko`, `Miasto`, `Adres`, `Płeć`, `Kod_Pocztowy`, `Data_Urodzenia`, `Kraj_Urodzenia`, `E-mail`, `Numer_Kontaktowy`, `Stanowisko`, `Pesel`, `Pochodzenie`) VALUES
(1, 1, 'Kamil', 'Bank', 'Kaczograd', 'Niewiem 2', 'Słuszna', '00-100', '2004-11-09', 'Nieznany', 'omgcoto@xd.com', '548213598', 'Najlepsze', '5221145548844', 'Y'),
(2, 1, 'Miłosz', 'Hewelt', 'Kaczograd', 'Niewiem 2', '-', '00-100', '2004-01-05', 'Nieznany', 'ojdhssa@xd.com', '548213598', 'Kierownik Budowy XD', 'nie ma', 'Ten_no');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `towar`
--

CREATE TABLE `towar` (
  `ID` int(11) NOT NULL,
  `ID_obiektu` int(11) NOT NULL,
  `Nazwa` text NOT NULL,
  `Ilość` int(11) NOT NULL,
  `Producent` text NOT NULL,
  `Nr.Faktury` text NOT NULL,
  `Podatki_%` int(11) NOT NULL,
  `Cena_Netto` decimal(10,2) NOT NULL,
  `Cena_Brutto` decimal(10,2) NOT NULL,
  `Stan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `obiekty`
--
ALTER TABLE `obiekty`
  ADD PRIMARY KEY (`ID`);

--
-- Indeksy dla tabeli `pracownicy`
--
ALTER TABLE `pracownicy`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_obiektu` (`ID_obiektu`);

--
-- Indeksy dla tabeli `towar`
--
ALTER TABLE `towar`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_obiektu` (`ID_obiektu`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `obiekty`
--
ALTER TABLE `obiekty`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `pracownicy`
--
ALTER TABLE `pracownicy`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `towar`
--
ALTER TABLE `towar`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `pracownicy`
--
ALTER TABLE `pracownicy`
  ADD CONSTRAINT `pracownicy_ibfk_1` FOREIGN KEY (`ID_obiektu`) REFERENCES `obiekty` (`ID`);

--
-- Ograniczenia dla tabeli `towar`
--
ALTER TABLE `towar`
  ADD CONSTRAINT `towar_ibfk_1` FOREIGN KEY (`ID_obiektu`) REFERENCES `obiekty` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
