--CREATE TABLE Resturant(
--	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	ResName VARCHAR(50) UNIQUE NOT NULL
--);

--CREATE TABLE FK_Res_Ing(
--	FK_Resturant INT NOT NULL,
--	FK_Ingredient INT NOT NULL

--	FOREIGN KEY(FK_Resturant)
--	REFERENCES Resturant(ID),

--	FOREIGN KEY(FK_Ingredient)
--	REFERENCES Ingredient(ID),

--	PRIMARY KEY(FK_Resturant, FK_Ingredient)
--);

INSERT INTO Resturant (ResName) VALUES ('Roskilde');
INSERT INTO Resturant (ResName) VALUES ('København');

INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 2);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 3);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 4);

INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 1);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 2);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 3);