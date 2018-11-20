CREATE TABLE IngType(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TypeName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Ingredient(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IngName VARCHAR(50) NOT NULL,
	Cost INT NOT NULL,
	FK_IngType INT NOT NULL

		FOREIGN KEY(FK_IngType) REFERENCES IngType(ID)
);

CREATE TABLE Resturant(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ResName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE FK_Res_Ing(
	FK_Resturant INT NOT NULL,
	FK_Ingredient INT NOT NULL

	FOREIGN KEY(FK_Resturant) REFERENCES Resturant(ID),

	FOREIGN KEY(FK_Ingredient) REFERENCES Ingredient(ID),

	PRIMARY KEY(FK_Resturant, FK_Ingredient)
);

CREATE TABLE BurgerOrder(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CustName VARCHAR(50) NOT NULL,
	CustTable INT NOT NULL
);


CREATE TABLE FK_Burger_Ing(
	FK_BurgerOrder INT NOT NULL,
	FK_Ingredient INT NOT NULL

	FOREIGN KEY(FK_BurgerOrder) REFERENCES BurgerOrder(ID),
	FOREIGN KEY(FK_Ingredient) REFERENCES Ingredient(ID),

	PRIMARY KEY(FK_BurgerOrder, FK_Ingredient)
)

/*Types Create*/
INSERT INTO IngType (TypeName) VALUES ('Brød');
INSERT INTO IngType (TypeName) VALUES ('Kød');
INSERT INTO IngType (TypeName) VALUES ('Grønt');
INSERT INTO IngType (TypeName) VALUES ('Ost');
INSERT INTO IngType (TypeName) VALUES ('Dressing');
INSERT INTO IngType (TypeName) VALUES ('Drinks');

/*Bread Create*/
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Ciabatta', 25, 1);
INSERT INTO Ingredient (IngName, Cost,  FK_IngType) VALUES ('Hvede', 20, 1);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Grov', 25, 1);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Brioche', 30, 1);

/*Meat Create*/
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Okse', 25, 2);
INSERT INTO Ingredient (IngName, Cost,  FK_IngType) VALUES ('Kylling', 25, 2);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Vegetar', 25, 2);

/*Cheese Create*/
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Mozerella', 10, 4);
INSERT INTO Ingredient (IngName, Cost,  FK_IngType) VALUES ('Gauda', 15, 4);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Cheddar', 10, 4);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Mild', 10, 4);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('Havati', 20, 4);
INSERT INTO Ingredient (IngName, Cost, FK_IngType) VALUES ('DanBo', 18, 4);

/*Ingridients in resturant TEST data*/
INSERT INTO Resturant (ResName) VALUES ('Roskilde');
INSERT INTO Resturant (ResName) VALUES ('København');
/*Roskilde*/
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 2);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 3);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 4);

INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 8);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 9);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 10);

INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1008);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1009);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1010);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1011);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1012);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (1, 1013);
/*Kobenhavn*/
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 1);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 2);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 3);

INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 8);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 9);

INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 1008);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 1009);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 1010);
INSERT INTO FK_Res_Ing (FK_Resturant, FK_Ingredient) VALUES (2, 1011);
