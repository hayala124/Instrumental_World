-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 21 2023 г., 13:51
-- Версия сервера: 8.0.30
-- Версия PHP: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `Musical_instrument_store`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Entrance`
--

CREATE TABLE `Entrance` (
  `id_entrance` int NOT NULL,
  `delivery_date` date NOT NULL,
  `number_document` int NOT NULL,
  `id_instrument` int NOT NULL,
  `id_provider` int NOT NULL,
  `quantity` int NOT NULL,
  `amount` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `Entrance`
--

INSERT INTO `Entrance` (`id_entrance`, `delivery_date`, `number_document`, `id_instrument`, `id_provider`, `quantity`, `amount`) VALUES
(1, '2023-12-07', 67544, 1, 1, 3, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Instrument`
--

CREATE TABLE `Instrument` (
  `id_instrument` int NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `id_type_instrument` int NOT NULL,
  `price` int NOT NULL,
  `quantity` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `Instrument`
--

INSERT INTO `Instrument` (`id_instrument`, `Name`, `id_type_instrument`, `price`, `quantity`) VALUES
(1, 'Цифровое пианино Artesia Performer', 1, 30000, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Instrument_Entrance`
--

CREATE TABLE `Instrument_Entrance` (
  `id_instrument` int NOT NULL,
  `id_entrance` int NOT NULL,
  `quantity` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Provider`
--

CREATE TABLE `Provider` (
  `id_provider` int NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Surname` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `address` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `phone_number` decimal(11,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `Provider`
--

INSERT INTO `Provider` (`id_provider`, `Name`, `Surname`, `address`, `phone_number`) VALUES
(1, 'Masha', 'Ivanova', 'ул. Славянская, д.15, кв. 789', '89526347845');

-- --------------------------------------------------------

--
-- Структура таблицы `Purchase`
--

CREATE TABLE `Purchase` (
  `id_purchase` int NOT NULL,
  `id_user` int NOT NULL,
  `id_instrument` int NOT NULL,
  `purchase_date` date NOT NULL,
  `quantity` int NOT NULL,
  `amount` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Type_of_instrument`
--

CREATE TABLE `Type_of_instrument` (
  `id_type_instrument` int NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `Type_of_instrument`
--

INSERT INTO `Type_of_instrument` (`id_type_instrument`, `Name`) VALUES
(1, 'Клавишные инструменты'),
(2, 'Струнные инструменты'),
(3, 'Ударные инструменты');

-- --------------------------------------------------------

--
-- Структура таблицы `User`
--

CREATE TABLE `User` (
  `id_user` int NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Surname` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `login` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Password` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `User`
--

INSERT INTO `User` (`id_user`, `Name`, `Surname`, `login`, `Password`) VALUES
(1, 'Melissa', 'Foster', 'melissa', 12345),
(2, 'Hayala', 'Shamilova', 'hayala', 5678),
(3, 'Vika', 'Ivanova', 'vika', 12345),
(7, 'Sveta', 'Petrova', 'sveta', 7890);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Entrance`
--
ALTER TABLE `Entrance`
  ADD PRIMARY KEY (`id_entrance`),
  ADD KEY `id_instrument` (`id_instrument`),
  ADD KEY `id_provider` (`id_provider`);

--
-- Индексы таблицы `Instrument`
--
ALTER TABLE `Instrument`
  ADD PRIMARY KEY (`id_instrument`),
  ADD KEY `id_type_instrument` (`id_type_instrument`);

--
-- Индексы таблицы `Instrument_Entrance`
--
ALTER TABLE `Instrument_Entrance`
  ADD KEY `id_document` (`id_entrance`),
  ADD KEY `id_instrument` (`id_instrument`);

--
-- Индексы таблицы `Provider`
--
ALTER TABLE `Provider`
  ADD PRIMARY KEY (`id_provider`);

--
-- Индексы таблицы `Purchase`
--
ALTER TABLE `Purchase`
  ADD PRIMARY KEY (`id_purchase`),
  ADD KEY `id_instrument` (`id_instrument`),
  ADD KEY `id_user` (`id_user`);

--
-- Индексы таблицы `Type_of_instrument`
--
ALTER TABLE `Type_of_instrument`
  ADD PRIMARY KEY (`id_type_instrument`);

--
-- Индексы таблицы `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `login` (`login`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Entrance`
--
ALTER TABLE `Entrance`
  MODIFY `id_entrance` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `Instrument`
--
ALTER TABLE `Instrument`
  MODIFY `id_instrument` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Provider`
--
ALTER TABLE `Provider`
  MODIFY `id_provider` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `Purchase`
--
ALTER TABLE `Purchase`
  MODIFY `id_purchase` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Type_of_instrument`
--
ALTER TABLE `Type_of_instrument`
  MODIFY `id_type_instrument` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `User`
--
ALTER TABLE `User`
  MODIFY `id_user` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Entrance`
--
ALTER TABLE `Entrance`
  ADD CONSTRAINT `entrance_ibfk_1` FOREIGN KEY (`id_instrument`) REFERENCES `Instrument` (`id_instrument`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `entrance_ibfk_2` FOREIGN KEY (`id_provider`) REFERENCES `Provider` (`id_provider`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `Instrument`
--
ALTER TABLE `Instrument`
  ADD CONSTRAINT `instrument_ibfk_1` FOREIGN KEY (`id_type_instrument`) REFERENCES `Type_of_instrument` (`id_type_instrument`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `Instrument_Entrance`
--
ALTER TABLE `Instrument_Entrance`
  ADD CONSTRAINT `instrument_entrance_ibfk_1` FOREIGN KEY (`id_entrance`) REFERENCES `Entrance` (`id_entrance`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `instrument_entrance_ibfk_2` FOREIGN KEY (`id_instrument`) REFERENCES `Instrument` (`id_instrument`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `Purchase`
--
ALTER TABLE `Purchase`
  ADD CONSTRAINT `purchase_ibfk_1` FOREIGN KEY (`id_instrument`) REFERENCES `Instrument` (`id_instrument`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `purchase_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `User` (`id_user`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
