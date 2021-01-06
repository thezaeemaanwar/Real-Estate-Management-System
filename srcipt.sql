CREATE TABLE [dbo].[UserTable]
(
	[username] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [type] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[ApartmentTable]
(
	[id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [description] VARCHAR(50) NOT NULL, 
    [percievedVal] FLOAT NOT NULL, 
    [materialPrice] FLOAT NOT NULL,
    [workForcePrice] FLOAT NOT NULL,
    [currentExpenditure] FLOAT NOT NULL,
    [squareMeters] INT NOT NULL,
    [noRooms] INT NOT NULL,
    [percievedComfort] INT NOT NULL,
    [metroProximity] BIT NOT NULL,
)