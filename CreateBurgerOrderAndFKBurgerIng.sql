--CREATE TABLE BurgerOrder(
--	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	CustName VARCHAR(50) NOT NULL,
--	CustTable INT NOT NULL
--);


CREATE TABLE FK_Burger_Ing(
	FK_BurgerOrder INT NOT NULL,
	FK_Ingredient INT NOT NULL

	FOREIGN KEY(FK_BurgerOrder) REFERENCES BurgerOrder(ID),
	FOREIGN KEY(FK_Ingredient) REFERENCES Ingredient(ID),

	PRIMARY KEY(FK_BurgerOrder, FK_Ingredient)
)