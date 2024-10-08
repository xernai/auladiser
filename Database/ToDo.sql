USE master
GO
CREATE DATABASE ToDo
GO
USE ToDo
GO
CREATE TABLE ToDoList (
    ToDoListID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name varchar(50) NOT NULL
);
GO
CREATE TABLE Person (
    PersonID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name varchar(50) NOT NULL
);
GO
CREATE TABLE Items (
    ItemID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PersonID int NOT NULL,
    ToDoListID int NOT NULL,
	DueDate datetime,
	Completed bit,
	CONSTRAINT FK_PersonItems FOREIGN KEY (PersonID) REFERENCES Person(PersonID),
	CONSTRAINT FK_ToDoListItems FOREIGN KEY (ToDoListID) REFERENCES ToDoList(ToDoListID)
);
GO