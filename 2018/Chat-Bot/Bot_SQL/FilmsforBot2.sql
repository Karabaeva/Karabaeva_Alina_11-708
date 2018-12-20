use master
GO

CREATE DATABASE FilmsforBot
GO;

CREATE TABLE FilmsMood
( Name_F nvarchar,
  Mood nvarchar,
  Link nvarchar,
  Genre nvarchar,
);
GO

INSERT INTO FilmsMood (Name_F, Mood, Link, Genre)
VALUES ('1+1 (Intouchables2011)1+1', 'Счастливый', 'https://www.kinopoisk.ru/film/535341/', 'Комедия' ),
('Иван Васильевич меняет профессию','Счастливый','https://www.kinopoisk.ru/film/ivan-vasilevich-menyaet-professiyu-1973-42664/','Комедия'),
('Жизнь прекрасна','Счастливый','https://www.kinopoisk.ru/film/381/','Комедия'),
('Криминальное чтиво','Счастливый','https://www.kinopoisk.ru/film/kriminalnoe-chtivo-1994-342/','Комедия'),
('Большой куш','Счастливый','https://www.kinopoisk.ru/film/bolshoy-kush-2000-526/','Комедия'),
('В джазе только девушки','Счастливый','https://www.kinopoisk.ru/film/v-dzhaze-tolko-devushki-1959-356/','Комедия'),
('Побег из Шоушенка','Грустный','https://www.kinopoisk.ru/film/pobeg-iz-shoushenka-1994-326/','Драма'),
('Зеленая миля','Грустный','https://www.kinopoisk.ru/film/435/','Драма'),
('Форрест Гамп','Грустный','https://www.kinopoisk.ru/film/forrest-gamp-1994-448/','Драма'),
('Ночь живых мертвецов','Злой','https://www.kinopoisk.ru/film/noch-zhivykh-mertvetsov-1968-8370/','Ужасы'),
('Рассвет мертвецов','Злой','https://www.kinopoisk.ru/film/8371/','Ужасы'),
('Заклятие','Злой','https://www.kinopoisk.ru/film/zaklyatie-2013-468994/','Ужасы'),
('Властелин колец: Возвращение Короля','Страх','https://www.kinopoisk.ru/film/vlastelin-kolec-vozvrashhenie-korolya-2003-3498/','Приключение'),
('ВАЛЛ·И','Страх','https://www.kinopoisk.ru/film/valli-2008-279102/','Приключение'),
('Джанго освобожденный','Страх','https://www.kinopoisk.ru/film/586397/','Приключение'),
('Рождественская история','Удивлённый','https://www.ivi.ru/watch/105821/description','Новогодний фильм'),
('Санта Клаус','Удивлённый','https://www.ivi.ru/watch/138509/description','Новогодний фильм'),
('Санта Клаус 2','Удивлённый','https://www.ivi.ru/watch/138508/description','Новогодний фильм');
GO

CREATE TABLE Emotion 
(
   Id INT NOT NULL PRIMARY KEY, 
    Contempt INT NOT NULL, 
    Disgust INT NOT NULL, 
    Anger INT NOT NULL, 
    Fear INT NOT NULL, 
    Happiness INT NOT NULL, 
    Neutral INT NOT NULL, 
    Sadness INT NOT NULL, 
    Surprise INT NOT NULL, 
    PhotoId INT NOT NULL, 
    DateTimeCreate DATETIME NOT NULL, 
    PhotoId_1 INT NOT NULL, 
);
GO 

CREATE TABLE Client 
(   Id INT NOT NULL PRIMARY KEY , 
    FirstName NCHAR(10) NOT NULL, 
    LastName NCHAR(10) NOT NULL, 
    SenderId NCHAR(10) NOT NULL, 
    Datee DATETIME NOT NULL,
);

CREATE TABLE Photo 
(   Id INT NOT NULL PRIMARY KEY, 
    Pathh NCHAR(10) NOT NULL, 
    DateCreate DATETIME NOT NULL, 
    UserId INT NOT NULL,
);
GO