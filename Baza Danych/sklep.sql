-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql11.freemysqlhosting.net
-- Czas generowania: 25 Maj 2022, 10:23
-- Wersja serwera: 5.5.62-0ubuntu0.14.04.1
-- Wersja PHP: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `sql11495118`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `obiekty`
--

CREATE TABLE `obiekty` (
  `ID` int(11) NOT NULL,
  `Nazwa_obiektu` text COLLATE utf8_polish_ci NOT NULL,
  `Adres` text COLLATE utf8_polish_ci NOT NULL,
  `Kod_pocztowy` text COLLATE utf8_polish_ci NOT NULL,
  `Miejscowosc` text COLLATE utf8_polish_ci NOT NULL,
  `Telefon` text COLLATE utf8_polish_ci NOT NULL,
  `Liczba_pracownikow` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `obiekty`
--

INSERT INTO `obiekty` (`ID`, `Nazwa_obiektu`, `Adres`, `Kod_pocztowy`, `Miejscowosc`, `Telefon`, `Liczba_pracownikow`) VALUES
(1, 'Sklep', 'niewiadoma 22', '66-420', 'Kaczygrad', '420696965', 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pracownicy`
--

CREATE TABLE `pracownicy` (
  `ID` int(11) NOT NULL,
  `ID_obiektu` int(11) NOT NULL,
  `Imie` text CHARACTER SET utf8mb4 NOT NULL,
  `Nazwisko` text CHARACTER SET utf8mb4 NOT NULL,
  `Miasto` text CHARACTER SET utf8mb4 NOT NULL,
  `Adres` text CHARACTER SET utf8mb4 NOT NULL,
  `Plec` text CHARACTER SET utf8mb4 NOT NULL,
  `Kod_Pocztowy` text CHARACTER SET utf8mb4 NOT NULL,
  `Data_Urodzenia` date NOT NULL,
  `Kraj_Urodzenia` text CHARACTER SET utf8mb4 NOT NULL,
  `E-mail` text CHARACTER SET utf8mb4,
  `Numer_Kontaktowy` text CHARACTER SET utf8mb4 NOT NULL,
  `Stanowisko` text CHARACTER SET utf8mb4,
  `Pesel` text CHARACTER SET utf8mb4 NOT NULL,
  `Pochodzenie` text CHARACTER SET utf8mb4 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `pracownicy`
--

INSERT INTO `pracownicy` (`ID`, `ID_obiektu`, `Imie`, `Nazwisko`, `Miasto`, `Adres`, `Plec`, `Kod_Pocztowy`, `Data_Urodzenia`, `Kraj_Urodzenia`, `E-mail`, `Numer_Kontaktowy`, `Stanowisko`, `Pesel`, `Pochodzenie`) VALUES
(1, 1, 'Kamil', 'Bank', 'Kaczograd', 'Niewiem 2', 'Słuszna', '00-100', '2004-11-09', 'Nieznany', 'omgcoto@xd.com', '548213598', 'Najlepsze', '5221145548844', 'Y'),
(2, 1, 'Miłosz', 'Hewelt', 'Kaczograd', 'Niewiem 2', '-', '00-100', '2004-01-05', 'Nieznany', 'ojdhssa@xd.com', '548213598', 'Kierownik Budowy XD', 'nie ma', 'Ten_no');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `towar`
--

CREATE TABLE `towar` (
  `ID` int(11) NOT NULL,
  `ID_obiektu` int(11) NOT NULL,
  `Nazwa` text CHARACTER SET utf8mb4 NOT NULL,
  `Ilosc` int(11) NOT NULL,
  `Producent` text CHARACTER SET utf8mb4 NOT NULL,
  `Nr_Faktury` text CHARACTER SET utf8mb4 NOT NULL,
  `Podatki` int(11) NOT NULL,
  `Cena_Netto` decimal(10,2) NOT NULL,
  `Cena_Brutto` decimal(10,2) NOT NULL,
  `Stan` text CHARACTER SET utf8mb4 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `obiekty`
--
ALTER TABLE `obiekty`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pracownicy`
--
ALTER TABLE `pracownicy`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_obiektu` (`ID_obiektu`);

--
-- Indexes for table `towar`
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
