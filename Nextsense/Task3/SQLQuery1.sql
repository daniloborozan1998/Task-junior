CREATE TABLE [dbo].[People](
	[Id] [int] NOT NULL,
	[MotherId] [int] NULL,
	[FatherId] [int] NULL,
	[Name] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


insert into People (Id, MotherId, FatherId, [Name], Age) 
values (1, null, null, 'Adam', 50)

insert into People (Id, MotherId, FatherId, [Name], Age) 
values (2, null, null, 'Eve', 50)

insert into People (Id, MotherId, FatherId, [Name], Age) 
values (3, 2, 1, 'Cain', 30)

insert into People (Id, MotherId, FatherId, [Name], Age) 
values (4, 2, 1, 'Seth', 20)


/* Write a query that selects the names of all parents together with the age of their youngest child 
Answer: */

/*Youngest child of each parent */
SELECT MotherID, MIN(Age) As Age FROM People GROUP BY MotherID HAVING MotherID IS NOT NULL;

SELECT FatherID, MIN(Age) As Age FROM People GROUP BY FatherID HAVING FatherID IS NOT NULL;

/*Name of parent */

SELECT a.Name, b.Age FROM People a
JOIN (SELECT MotherID, MIN(Age) As Age FROM People GROUP BY MotherID HAVING MotherID IS NOT NULL) b ON a.ID = b.MotherId;

SELECT a.Name, c.Age FROM People a
JOIN (SELECT FatherID, MIN(Age) As Age FROM People GROUP BY FatherID HAVING FatherID IS NOT NULL) c ON a.ID = c.FatherId;
