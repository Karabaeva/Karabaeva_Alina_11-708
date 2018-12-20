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
VALUES ('1+1 (Intouchables2011)1+1', '����������', 'https://www.kinopoisk.ru/film/535341/', '�������' ),
('���� ���������� ������ ���������','����������','https://www.kinopoisk.ru/film/ivan-vasilevich-menyaet-professiyu-1973-42664/','�������'),
('����� ���������','����������','https://www.kinopoisk.ru/film/381/','�������'),
('������������ �����','����������','https://www.kinopoisk.ru/film/kriminalnoe-chtivo-1994-342/','�������'),
('������� ���','����������','https://www.kinopoisk.ru/film/bolshoy-kush-2000-526/','�������'),
('� ����� ������ �������','����������','https://www.kinopoisk.ru/film/v-dzhaze-tolko-devushki-1959-356/','�������'),
('����� �� ��������','��������','https://www.kinopoisk.ru/film/pobeg-iz-shoushenka-1994-326/','�����'),
('������� ����','��������','https://www.kinopoisk.ru/film/435/','�����'),
('������� ����','��������','https://www.kinopoisk.ru/film/forrest-gamp-1994-448/','�����'),
('���� ����� ���������','����','https://www.kinopoisk.ru/film/noch-zhivykh-mertvetsov-1968-8370/','�����'),
('������� ���������','����','https://www.kinopoisk.ru/film/8371/','�����'),
('��������','����','https://www.kinopoisk.ru/film/zaklyatie-2013-468994/','�����'),
('��������� �����: ����������� ������','�����','https://www.kinopoisk.ru/film/vlastelin-kolec-vozvrashhenie-korolya-2003-3498/','�����������'),
('���˷�','�����','https://www.kinopoisk.ru/film/valli-2008-279102/','�����������'),
('������ �������������','�����','https://www.kinopoisk.ru/film/586397/','�����������'),
('�������������� �������','���������','https://www.ivi.ru/watch/105821/description','���������� �����'),
('����� �����','���������','https://www.ivi.ru/watch/138509/description','���������� �����'),
('����� ����� 2','���������','https://www.ivi.ru/watch/138508/description','���������� �����');
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