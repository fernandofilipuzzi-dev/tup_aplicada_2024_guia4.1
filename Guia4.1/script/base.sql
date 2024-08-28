

--CREATE DATABASE  EnviosDB

--GO

USE EnviosDB

DROP TABLE IF EXISTS Envios;

CREATE TABLE Envios(
   Id INT PRIMARY KEY IDENTITY(1,1),
   Valor_Total DECIMAL(18,2)
)

GO

USE EnviosDB

DROP TABLE IF EXISTS Costos;

CREATE TABLE Costos(
   Id INT PRIMARY KEY IDENTITY(1,1),
   Tipo INT NOT NULL DEFAULT 0, --0 VALOR FIJO, --1 VARIABLE
   Concepto NVARCHAR(50),
   Valor_Final DECIMAL(18,2),
   Id_Envio INT NOT NULL,
   Precio_Por_Unidad DECIMAL(18,2),
   Unidades DECIMAL (18,2),
   FOREIGN KEY (Id_Envio) REFERENCES Envios(Id)
)

--CREATE TABLE Costos_Variables
--(
-- Id INT PRIMARY KEY IDENTITY(1,1),
-- Precio_Por_Unidad DECIMAL(18,2),
--   Unidades DECIMAL (18,2),
--    Id_Costo INT NOT NULL,
--)

GO

USE EnviosDB

INSERT INTO Envios(Valor_Total)
VALUES(0)

DECLARE @Id_Envio INT=1;

INSERT INTO Costos(Tipo,  Concepto, Valor_Final, Precio_Por_Unidad,  Unidades, Id_Envio)
VALUES(0,'Peaje puente zarate', 300, null,null,@Id_Envio),
(1,'Combustible - litros', null, 1500.5, 500,@Id_Envio),
(0,'Peaje t�nel', 300, null,null,@Id_Envio),
(1,'Horas de conducci�n', null, 1500.5, 500,@Id_Envio)

GO
SELECT * FROM Envios e
JOIN Costos c ON c.Id_Envio=e.Id

SELECT * FROM Envios