USE master;
GO

DROP DATABASE IF EXISTS TESS_DB;
GO

CREATE DATABASE TESS_DB;
GO

USE TESS_DB;
GO

DROP TABLE IF EXISTS Tasks;

CREATE TABLE Tasks (
	pk_task int IDENTITY(1,1),
	name_task nvarchar(255) NOT NULL,
	date_task datetime NOT NULL,
	complete_task bit
);

INSERT INTO Tasks VALUES (1, 'atividade 1', '2020-02-10 15:45:00', 1);
INSERT INTO Tasks VALUES (2, 'atividade 2', '2021-05-10 15:45:05', 0);
INSERT INTO Tasks VALUES (3, 'atividade 3', '2021-02-10 15:45:02', 1);
INSERT INTO Tasks VALUES (4, 'atividade 4', '2021-06-10 15:45:55', 0);
INSERT INTO Tasks VALUES (5, 'atividade 5', '2021-02-10 15:25:44', 1);
INSERT INTO Tasks VALUES (6, 'atividade 6', '2021-03-10 15:35:55', 0);
INSERT INTO Tasks VALUES (7, 'atividade 7', '2021-02-10 15:15:07', 1);
INSERT INTO Tasks VALUES (8, 'atividade 8', '2021-03-10 15:45:08', 0);
INSERT INTO Tasks VALUES (9, 'atividade 9', '2020-04-10 15:45:55', 1);
INSERT INTO Tasks VALUES (10, 'atividade 10', '2021-08-10 01:45:00', 0);
INSERT INTO Tasks VALUES (11, 'atividade 11', '2021-02-10 15:45:00', 0);
INSERT INTO Tasks VALUES (12, 'atividade 12', '2021-02-10 15:45:00', 1);
INSERT INTO Tasks VALUES (13, 'atividade 13', '2021-06-10 15:25:00', 0);
INSERT INTO Tasks VALUES (14, 'atividade 14', '2021-05-10 15:35:11', 0);
INSERT INTO Tasks VALUES (15, 'atividade 15', '2020-02-10 15:35:16', 1);

SELECT * FROM Tasks;