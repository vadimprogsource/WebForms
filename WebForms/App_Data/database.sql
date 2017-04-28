CREATE DATABASE web_forms_db
USE web_forms_db
GO
CREATE TABLE Territories
(
  TerritoryID INT NOT NULL,
  Territory NVARCHAR(max) NULL,
  CountryName NVARCHAR(max) NULL,
  CreationDate DATETIME NOT NULL,
  PRIMARY KEY(TerritoryID)
)
GO
CREATE TABLE Countries
(
  CountryID INT NOT NULL,
  Country NVARCHAR(max) NULL,
  TerritoryID INT NOT NULL FOREIGN KEY REFERENCES Territories(TerritoryID),
  CreationDate DATETIME NOT NULL,
  PRIMARY KEY (CountryID)
)
GO
CREATE TABLE Clients
(
  ClientID INT NOT NULL IDENTITY(1,1),
  ClientName NVARCHAR(max) NULL,
  CountryID INT NOT NULL FOREIGN KEY REFERENCES Countries(CountryID),
  CreationDate DATETIME NOT NULL,
  PRIMARY KEY (ClientID)
  
)
GO
CREATE TABLE Projects
(
  ProjectID INT NOT NULL IDENTITY(1,1),
  ProjectCode NVARCHAR(10) NULL,
  ProjectTitle NVARCHAR(max) NULL,
  CountryID INT NOT NULL FOREIGN KEY REFERENCES Countries(CountryID),
  CreationDate DATETIME NOT NULL,
  PRIMARY KEY (ProjectID)
)
GO
INSERT INTO Territories(TerritoryID,Territory,CountryName,CreationDate) VALUES(1,N'Middle East',N'United Arab Emirates',GetDate())
INSERT INTO Territories(TerritoryID,Territory,CountryName,CreationDate) VALUES(2,N'Africa',N'Egypt',GetDate())

INSERT INTO Countries(CountryID,TerritoryID,Country,CreationDate) VALUES(1,1,N'United Arab Emirates',GetDate())
INSERT INTO Countries(CountryID,TerritoryID,Country,CreationDate) VALUES(2,2,N'Egypt',GetDate())

INSERT INTO Projects(CountryID,ProjectCode,ProjectTitle,CreationDate) VALUES(1,N'971 1234',N'Test project 1',GetDate())
INSERT INTO Projects(CountryID,ProjectCode,ProjectTitle,CreationDate) VALUES(2,N'020 4321',N'Test project 2',GetDate())

INSERT INTO Clients(CountryID,ClientName,CreationDate) VALUES(1,N'Test client 1',GetDate())
INSERT INTO Clients(CountryID,ClientName,CreationDate) VALUES(2,N'Test client 2',GetDate())
GO
select Territory, Country,ProjectCode,ProjectTitle,ClientName  from 
              Projects left join Countries on Projects.CountryID = Countries.CountryID     
			           left join Territories on  Countries.TerritoryID = Territories.TerritoryID
					   left join Clients on Projects.CountryID = Clients.CountryID
					   order by Territory desc , Country,ProjectCode , ProjectTitle , ClientName