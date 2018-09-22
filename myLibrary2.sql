/* CREATE NEW DATABASE myLibrary IF ALREADY PRESENT DO NOT RUN COMMAND */
CREATE DATABASE myLibrary
GO
USE myLibrary
GO

/* CREATE TABLES FOR myLibrary DATABASE AND INSERT DATA INTO DATABASE */
CREATE TABLE User_Register
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Username VARCHAR(256),
	Password VARCHAR(256),
	UserCreatedOn DATETIME DEFAULT(GETDATE()),
	User_Active BIT DEFAULT(1),
	BooksIssued INT NULL DEFAULT(0)
);
ALTER TABLE User_Register
ADD SecurityAmount BIGINT DEFAULT(1000)
GO
SELECT * FROM User_Register
GO
CREATE TABLE Books_Category
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Category VARCHAR(256)
);
GO
CREATE TABLE Books_Record
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Book VARCHAR(256),
	Category INT FOREIGN KEY REFERENCES Books_Category(Id),
	PricePerBook DECIMAL DEFAULT(0),
	Quantity BIGINT DEFAULT(0),
	Author VARCHAR(256)
);
SELECT * FROM Books_Record
GO
CREATE TABLE Books_Issue
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Bookname VARCHAR(256),
	IssuedTo VARCHAR(256),
	IssuedOn DATE DEFAULT(GETDATE()),
	ReturnOn DATE DEFAULT(DATEADD(month, +1, GETDATE()))
);
GO
CREATE TABLE Books_Return_Charges
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Bookname VARCHAR(256),
	IssuedTo VARCHAR(256),
	IssuedOn DATE DEFAULT(GETDATE()),
	ReturnOn DATE DEFAULT(GETDATE()),
	BookPrice INT DEFAULT(0),
	BookIssueDay AS (DATEDIFF(DAY, IssuedOn, ReturnOn)),
	AmountPaid AS (BookPrice * (DATEDIFF(DAY, IssuedOn, ReturnOn)))
);
GO
SELECT * FROM Books_Issue
SELECT * FROM Books_Return_Charges
GO
INSERT INTO Books_Category(Category) VALUES('Information Technology')
INSERT INTO Books_Category(Category) VALUES('Accounting')
INSERT INTO Books_Category(Category) VALUES('Science & Technology')
INSERT INTO Books_Category(Category) VALUES('Autobiography')
INSERT INTO Books_Category(Category) VALUES('Cooking Books')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Let Us C', 1, 599, 10, 'Denis Ritchie')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('OOPS Using C++', 1, 799, 15, 'S.Balaguruswami')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('C# Programming', 1, 899, 12, 'Pearson')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Javascript', 1, 80, 12, 'Matrix')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Sql Server Training', 1, 1599, 15, 'Microsoft Press')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Debentures', 2, 499, 20, 'Priyalala')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Trading Accounts', 2, 899, 10, 'Carl hooper')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Charted Accounting', 2, 1199, 15, 'Shiv Prasad')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Solar System', 3, 399, 10, 'Harry ORiel')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Galaxy World', 3, 599, 15, 'Vishnu Devi')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Black Hole', 3, 699, 10, 'Denis Fernandis')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Play it my way', 4, 599, 20, 'Sachin Ramesh Tendulkar')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Do it or Hate it', 4, 799, 20, 'Steve Jobs')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Its my way for success', 4, 699, 20, 'Bill Gates')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Healthy Snacks', 5, 599, 15, 'Sanjeev Kapoor')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Badam Halwa', 5, 399, 25, 'Sanjeev Kapoor')
INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
VALUES('Chicken Oats', 5, 299, 30, 'Vishal Thakur')
INSERT INTO User_Register(Username, Password) VALUES('admin', 'admin')
GO
SELECT * FROM User_Register
SELECT * FROM Books_Category
SELECT * FROM Books_Record
SELECT * FROM Books_Issue
SELECT * FROM Books_Return_Charges

GO

/* Stored Procedure For Database CRUD Operation using UI Change ALTER to CREATE For 
	generating First Time */

	-- Stored Procedure for Register User in Database

ALTER PROCEDURE Insert_User
				@Username VARCHAR(256),
				@Password VARCHAR(256)
AS
BEGIN
	DECLARE @Result INT
	If(@Username = 'admin')
	BEGIN
		SELECT 'User not Register'
		SET @Result = 0		-- User not register
	END
	ELSE
	BEGIN
		SET @Result = (SELECT COUNT(Username) FROM User_Register
						WHERE Username = @Username)
		IF(@Result > 0)
		BEGIN
			SET @Result = 2	-- User already registered
		END
		ELSE
		BEGIN
			INSERT INTO User_Register(Username, Password)
			VALUES(@Username, @Password)
			SET @Result = 1		-- User Register
		END
	END
	SELECT @Result
END
GO
EXEC Insert_User 'rvd', 'rvd@123'
GO
-- Stored Procedure For Check User Exist or Not
CREATE PROCEDURE Validate_User
				@Username VARCHAR(256),
				@Password VARCHAR(256)
AS
BEGIN
	DECLARE @User INT
	SET @User = (SELECT COUNT(Username) FROM User_Register
				WHERE Username = @Username AND Password = @Password)
				If(@User > 0)
				BEGIN
					SET @User = 1	-- User Log In
				END
				ELSE
				BEGIN
					SET @User = 0	-- User Not Log In
				END
	SELECT @User
END
GO
EXEC Validate_User 'admin', 'admin'
GO

-- Stored Procedure For Change Password of user
CREATE PROCEDURE UpdatePassword
				@Username VARCHAR(256),
				@Password VARCHAR(256)
AS
BEGIN
	DECLARE @User INT
	SET @User = (SELECT COUNT(Username) FROM User_Register
				WHERE Username = @Username)
				If(@User > 0)
				BEGIN
					UPDATE User_Register
					SET Password = @Password
					WHERE Username = @Username
					SET @User = 1			-- Password Changes
				END
				ELSE
				BEGIN
					SET @User = 0			-- Password not updated
				END
	SELECT @User
END
GO
EXEC UpdatePassword 'dhoru', 'admin'
GO

-- Stored Procedure For Add Books Category
CREATE PROCEDURE AddCategory
				@Book_Category VARCHAR(256)
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT COUNT(Category) FROM Books_Category
					WHERE Category = @Book_Category)
					If(@result > 0)
					BEGIN
						SET @result = 0		-- Book Category already present
					END
					ELSE
					BEGIN
						INSERT INTO Books_Category(Category) VALUES(@Book_Category)
						SET @result = 1		-- book Category insert
					END
	SELECT @result
END
GO
SELECT * FROM Books_Category
EXEC AddCategory 'Autobiographies'
GO

-- Stored Procedure For Remove Category From Database
CREATE PROCEDURE RemCategory
				@Category INT
AS
BEGIN
	DECLARE @Cat INT
	SET @Cat = (SELECT COUNT(Category) FROM Books_Category
				WHERE Id = @Category)
				If(@Cat > 0)
				BEGIN
					DELETE FROM Books_Category
					WHERE Id = @Category
					SET @Cat = 1				-- Record Deleted
				END
				ELSE
				BEGIN
					SET @Cat = 0
				END
	SELECT @Cat
END
GO
EXEC RemCategory 9
GO

-- Stored Procedure for Adding Book to Database
CREATE PROCEDURE AddBook
				@Book VARCHAR(256),
				@Category INT,
				@Price DECIMAL,
				@Quantity INT,
				@Author VARCHAR(256)
AS
BEGIN
	DECLARE @BookName INT
	SET @BookName = (SELECT COUNT(Book) FROM Books_Record
					WHERE Book = @Book)
					If(@BookName = 0)
					BEGIN
						INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
						VALUES(@Book, @Category, @Price, @Quantity, @Author)
						SET @BookName = 1		-- Record Inserted
					END
				ELSE
				BEGIN
					SET @BookName = 0			-- Record Already Present
				END
		SELECT @BookName
END
GO
EXEC AddBook 'Let Us C', 1, 500, 5, 'Henry Ford'
GO

-- Stored Procedure For Remove Book From Database
CREATE PROCEDURE RemBook
				@BookName VARCHAR(256),
				@Quantity INT
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT Quantity FROM Books_Record
					WHERE Book = @BookName)
				IF(@result > @Quantity)
				BEGIN
					UPDATE Books_Record
					SET Quantity = (@result - @Quantity)
					WHERE Book = @BookName
					SET @result = 1					-- Record Updated
				END
				ELSE IF(@result = @Quantity)
				BEGIN
					DELETE FROM Books_Record
					WHERE Book = @BookName
					SET @result = 0					-- Record Deleted
				END
				ELSE
				BEGIN
					SET @result = -1				-- Record Error
				END
	SELECT @result
END
GO
EXEC RemBook 'Do it or Hate it', 1
GO

-- Stored Procedure For Search Book
CREATE PROCEDURE GetDetailsByBook
				@Bookname VARCHAR(256)
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT COUNT(Book) FROM Books_Record
					WHERE Book = @Bookname)
			IF(@result <> 0)
			BEGIN
				SELECT r.Id, r.Book, c.Category, r.Author, r.Quantity, r.PricePerBook
				FROM Books_Record r INNER JOIN
				Books_Category c
				ON r.Category = c.Id 
				WHERE r.Book = @Bookname
			END
			ELSE
			BEGIN
				PRINT 'No Record Found'
				SET @result = 0						-- No Record Found
			END
END
GO
EXEC GetDetailsByBook 'play it my way'
GO

-- Stored Procedure for Search Details by Category Name
CREATE PROCEDURE GetDetailsByCategory
				@catname VARCHAR(256)
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT COUNT(c.Category) 
					FROM Books_Record r INNER JOIN
					Books_Category c 
					ON r.Category = c.Id
					WHERE c.Category = @catname)
			IF(@result <> 0)
			BEGIN
				SELECT r.Id, r.Book, c.Category, r.Author, r.Quantity, r.PricePerBook
				FROM Books_Record r INNER JOIN
				Books_Category c
				ON r.Category = c.Id 
				WHERE c.Category = @catname
			END
			ELSE
			BEGIN
				PRINT 'No Record Found'
				SET @result = 0						-- No Record Found
			END
END
GO
EXEC GetDetailsByCategory 'Cooking Books'
SELECT * FROM Books_Category
GO

-- Stored Procedure for Issue Book to User and also check how many books issued to user
-- selected book is already issued to user or not

ALTER PROCEDURE IssueBook
				@user VARCHAR(256),
				@Bookname VARCHAR(256)
AS
BEGIN
	DECLARE @bookissue INT
	DECLARE @book INT
	DECLARE @bookPrice INT
	DECLARE @UserAmount INT
	SET @bookissue = (SELECT BooksIssued FROM User_Register
						WHERE Username = @user)
	SET @UserAmount = (SELECT SecurityAmount FROM User_Register
						WHERE Username = @user)
			IF(@bookissue = '3')
			BEGIN
				PRINT 'You have already issued 3 Books'
				SET @bookissue = 0
			END
			ELSE IF(@bookissue < 3)
			BEGIN
				SET @bookPrice = (SELECT PricePerBook FROM Books_Record
									WHERE Book = @Bookname)SELECT * FROM Books_Record
				SET @book = (SELECT COUNT(Bookname) FROM Books_Issue
								WHERE Bookname = @Bookname AND IssuedTo = @user)
				IF(@UserAmount > @bookPrice * 2 AND @book <> 0)
				BEGIN
					PRINT 'Book is Already Issued'
					SET @bookissue = 1
				END
				ELSE
				BEGIN
						UPDATE User_Register
						SET BooksIssued = BooksIssued + 1
						WHERE Username = @user
							
						INSERT INTO Books_Issue(Bookname, IssuedTo)
						VALUES(@Bookname, @user)

						INSERT INTO Books_Return_Charges(Bookname, IssuedTo, BookPrice)
						VALUES(@Bookname, @user, @bookPrice)
							
						UPDATE Books_Record
						SET Quantity = Quantity - 1
						WHERE Book = @Bookname
							
						SET @bookissue = 2
				END
				END
			END
			ELSE
			BEGIN
				PRINT 'User does not have sufficient amount left'
				SET @bookissue = -1
			END
	SELECT @bookissue
END
GO
EXEC ReturnBook 'Chicken Oats', 'rvd'
EXEC IssueBook 'rvd', 'Chicken Oats'
SELECT * FROM User_Register
SELECT * FROM Books_Issue
SELECT * FROM Books_Return_Charges
TRUNCATE TABLE Books_Return_Charges
SELECT * FROM Books_Record
GO

-- Stored Procedure for Return issuing Book to Record
ALTER PROCEDURE ReturnBook
				@bookname VARCHAR(256),
				@username VARCHAR(256)
AS
BEGIN
	DECLARE @result INT
	DECLARE @amt INT
	SET @result = (SELECT COUNT(Bookname) FROM Books_Issue
					WHERE Bookname = @bookname AND IssuedTo = @username)
		IF(@result <> 0)
		BEGIN
			UPDATE Books_Return_Charges
			SET ReturnOn = GETDATE(), ReturnBook = 1
			WHERE Bookname = @bookname AND IssuedTo = @username AND ReturnBook = 0

			SET @amt = (SELECT AmountPaid FROM Books_Return_Charges
						WHERE Bookname = @bookname AND IssuedTo = @username AND ReturnBook = 1)

			DELETE FROM Books_Issue
			WHERE Bookname = @bookname AND IssuedTo = @username

			UPDATE User_Register
			SET BooksIssued = BooksIssued - 1, SecurityAmount = SecurityAmount - @amt
			WHERE Username = @username

			UPDATE Books_Record
			SET Quantity = Quantity + 1
			WHERE Book = @bookname
			
			SET @result = 1
			PRINT 'Book Return Successfully'
		END
		ELSE
		BEGIN
			RAISERROR('User Does not issuing this book', 0, 0)
			SET @result = 0
		END
	SELECT @result
END
GO
EXEC ReturnBook 'C# Programming', 'rvd'
GO

-- A View to Get Details of Library Books
CREATE VIEW ReadLibraryData
AS
SELECT r.Id AS [Book Id], r.Book AS [Book Name], c.Category AS [Category Name], 
r.Author AS [Author Name], r.Quantity, r.PricePerBook AS [Book Price], r.TotalPrice AS [Total Price]
FROM Books_Category c
INNER JOIN
Books_Record r
ON
c.Id = r.Category
GO

-- Stored Procedure for Search Issued Books via User
ALTER PROCEDURE BooksRecordViaUser
				@Username VARCHAR(256)
AS
BEGIN
	If(@Username = 'admin' OR @Username = 'administrator' OR @Username = 'Administrator')
	BEGIN
		SELECT Id, Bookname, IssuedTo, IssuedOn, ReturnOn
		FROM Books_Issue
	END
	ELSE
	BEGIN
		SELECT Id, Bookname, IssuedTo, IssuedOn, ReturnOn
		FROM Books_Issue
		WHERE IssuedTo = @Username
	END
END
GO
EXEC BooksRecordViaUser 'admin'
GO

/* Stored Procedure To Get the Users Security Amount */
ALTER PROCEDURE GetSecurityAmountViaUser
				@Username VARCHAR(256)
AS
BEGIN
	IF(@Username = 'admin' OR @Username = 'administrator' OR @Username = 'Administrator')
	BEGIN
		SELECT Id, Username, UserCreatedOn AS [User Registration Date], 
		BooksIssued AS [Current Books Issued], SecurityAmount AS [User Security Amount],
		User_Active AS [User Available]
		FROM User_Register
	END
	ELSE
	BEGIN
		SELECT Id, Username, UserCreatedOn AS [User Registration Date], 
		User_Active AS [User Available], BooksIssued AS [Current Books Issued], 
		SecurityAmount AS [User Security Amount]
		FROM User_Register
		WHERE Username = @Username
	END
END
GO

EXEC GetSecurityAmountViaUser 'admin'
GO
/* View To List all the books Issue and return to/from library */
CREATE VIEW DisplayIssueData
AS
	SELECT Bookname, IssuedTo AS [Issued To], IssuedOn AS [Issue Date], 
	ReturnOn AS [Book Valid Upto], BookPrice AS [Book Charge/Day], 
	BookIssueDay AS [Book Issuing Days], AmountPaid AS [Book Total Charge], 
	ReturnBook AS [Return Or Not]
	FROM Books_Return_Charges
GO

-- NOW TRUNCATE ALL TABLES AND RESET ALL DATA AGAIN
TRUNCATE TABLE User_Register
TRUNCATE TABLE Books_Issue
TRUNCATE TABLE Books_Record
TRUNCATE TABLE Books_Category
TRUNCATE TABLE Books_Return_Charges
GO
SELECT * FROM Books_Record ORDER BY PricePerBook ASC
SELECT * FROM User_Register
SELECT * FROM Books_Issue
SELECT * FROM Books_Return_Charges
SELECT * FROM DisplayIssueData
GO
EXEC IssueBook 'rvd', 'Javascript'
EXEC ReturnBook 'Javascript', 'rvd'
GO
