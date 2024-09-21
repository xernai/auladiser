-- cRud
SELECT * FROM [dbo].[Person]

SELECT Name FROM [dbo].[Person]
WHERE PersonID = 1

-- ON-PREMISES

-- Crud
INSERT INTO [dbo].[Person] ([Name]) VALUES ('Juan')

INSERT INTO [dbo].[Person] ([Name]) VALUES ('Maya')

INSERT INTO [dbo].[Person] ([Name]) VALUES ('Laura')

-- CrUd
UPDATE [dbo].[Person] SET
[Name] = 'Laura'

UPDATE [dbo].[Person] SET
[Name] = 'Javier'
WHERE PersonID = 2

UPDATE [dbo].[Person] SET
[Name] = 'Maya'
WHERE PersonID = 3

-- cruD
DELETE FROM [dbo].[Person] 
WHERE PersonID = 6

