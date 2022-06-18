use dbname;
create index belongsCatName on belongs(categoryName) 

drop proc [dbo].[CreateRandomString];

-- Utilities (https://jarrettmeyer.com/2017/11/14/creating-random-strings-in-sql-server)

go
CREATE FUNCTION [dbo].[fn_RandIntBetween]
(
	@lower  INT,
	@upper  INT,
	@rand   FLOAT
)
RETURNS INT
AS
BEGIN
	DECLARE @result INT;
	DECLARE @range INT = @upper - @lower + 1;
	SET @result = FLOOR(@rand * @range + @lower);
	RETURN @result;
END

go
CREATE FUNCTION [dbo].[fn_PickRandomChar]
(
	@chars VARCHAR(MAX),
	@rand  FLOAT
)
RETURNS CHAR(1)
AS BEGIN
	DECLARE @result CHAR(1) = NULL;
	DECLARE @resultIndex INT = NULL;
	IF @chars IS NULL
		SET @result = NULL;
	ELSE IF LEN(@chars) = 0
		SET @result = NULL
	ELSE BEGIN
		SET @resultIndex = [dbo].[fn_RandIntBetween](1, LEN(@chars), @rand);
		SET @result = SUBSTRING(@chars, @resultIndex, 1);
	END

	RETURN @result;
END

go
CREATE PROCEDURE [dbo].[CreateRandomString]
	@minLength INT = 1,
	@maxLength INT = 50,
	@chars VARCHAR(200) = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ',
	@randomString VARCHAR(MAX) = NULL OUTPUT
AS BEGIN
	SET NOCOUNT ON;

	-- Get the length of our string.
	DECLARE @stringLength INT = [dbo].[fn_RandIntBetween](@minLength, @maxLength, RAND());
	-- DECLARE @randomString varchar(MAX);

	-- Set our random string to an empty string.
	SET @randomString = '';

	-- If our string is not yet the appropriate length, add another character to the string.
	WHILE LEN(@randomString) < @stringLength
	BEGIN
		SET @randomString = @randomString + [dbo].[fn_PickRandomChar](@chars, RAND());
	END
	-- print @randomString
	-- return @randomString
END

declare @str varchar(100)
exec CreateRandomString 4, 20, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @str output;
print @str


---/---------------|
--<		BENCHMARKS |
---\---------------|

-- INDEXES
-- create index belongsCatName on belongs(categoryName) 

drop index hasRecName
-- drop index hasStepNum
drop index recipieName
-- drop index recipieAuthor

create index hasRecName on has(recipieName) 
--create index hasStepNum on has(stepNum) 

create index recipieName on recipie(name) 
--create index recipieAuthor on recipie(author) 
-- TO CHANGE EVERY SCRIPT RUN

-- Record the Start Time
DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time
-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 500;
SET nocount ON

WHILE @val <= @nelem
BEGIN
	DBCC DROPCLEANBUFFERS; -- need to be sysadmin
	
	-- recipie e has
	/*
	declare @catName varchar(20), @catDesc varchar(50);
	exec CreateRandomString 4, 20, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @catName output;
	exec CreateRandomString 10, 50, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @catDesc output;

	INSERT category
	SELECT
	@catName, @catDesc
	*/
	declare @recName varchar(20), @aut varchar(20), @cals int, @prep int;
	exec CreateRandomString 4, 20, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @recName output;
	exec CreateRandomString 4, 20, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @aut output;
	set @cals = FLOOR(RAND() * (500-0+1)) + 0;
	set @prep = FLOOR(RAND() * (500-0+1)) + 0;

	INSERT recipie 
	(recipieName, author, calories, preparingTime)
	SELECT
	@recName, @aut, @cals, @prep
	/*
	INSERT belongs
	SELECT
	@recName, @catName
	*/

	declare @Nsteps int, @i int;
	set @Nsteps = FLOOR(RAND() * (100-5+1)) + 5;
	set @i = 0;

	WHILE @val <= @nelem
	BEGIN
		declare @stID int, @desc varchar(20), @img varchar(20);
		set @stID = FLOOR(RAND() * (500000000000-0+1)) + 0;
		exec CreateRandomString 4, 20, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @desc output;
		exec CreateRandomString 4, 20, 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ', @img output;

		insert step
		select 
		@stID, @desc, @img

		declare @hasID int;
		set @hasID = FLOOR(RAND() * (500000000000-0+1)) + 0;

		insert has
		select
		@hasID, @recName, @stID, @i;

		set @i = @i + 1;
	END
	/*
	INSERT mytemp (rid, at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem*40000) as int), cast((RAND()*@nelem) as int),
		cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
		'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	*/
	SET @val = @val + 1;
END
PRINT 'Inserted ' + str(@nelem) + ' total records'
-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
@start_time, @end_time))

-- Qual a percentagem de fragmentação dos índices e de ocupação das páginas dos índices?

SELECT * FROM sys.dm_db_index_physical_stats (DB_ID('dbname'), object_id('dbo.recipie'),null, null, 'DETAILED');
SELECT * FROM sys.dm_db_index_physical_stats (DB_ID('dbname'), object_id('dbo.has'),null, null, 'DETAILED');
