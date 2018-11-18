CREATE TABLE IngType(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TypeName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Ingredient(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IngName VARCHAR(50) NOT NULL,
	Cost INT NOT NULL,
	FK_IngType INT NOT NULL

	CONSTRAINT fk_Orders_Customers
		FOREIGN KEY(FK_IngType)
		REFERENCES IngType(ID)
);

----INSERT INTO IngType (TypeName) VALUES ('Brød');
----INSERT INTO IngType (TypeName) VALUES ('Kød');
----INSERT INTO IngType (TypeName) VALUES ('Grønt');
----INSERT INTO IngType (TypeName) VALUES ('Ost');
----INSERT INTO IngType (TypeName) VALUES ('Dressing');
----INSERT INTO IngType (TypeName) VALUES ('Drinks');