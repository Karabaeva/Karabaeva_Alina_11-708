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
('����� ����� 2','���������','https://www.ivi.ru/watch/138508/description','���������� �����'),
('','','',''),
('','','',''),
('','','',''),
('','','','')
GO