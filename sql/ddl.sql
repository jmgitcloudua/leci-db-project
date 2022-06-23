select * from project.step;
select * from project.has;
select * from project.usesIngredient;

CREATE DATABASE dbname;
USE dbname;

create type name from varchar(20);
create type text from varchar(100);

create table recipie (
	recipieName name primary key,
	author name,
	calories int,
	preparingTime int
);
create table utensil (
	utensilName name primary key,
	dimention int,
	unit name
);
create table ingredient (
	ingredientName name primary key,
	description text
);
create table category (
	categoryName name primary key,
	description text,
);
create table step (
	stepID int primary key,
	description text,
	image varchar(20),
);
create table has (
	id int primary key,
	recipieName name references recipie on delete cascade on update cascade,
	stepID int references step on delete set null on update cascade,
	stepNum int,
);
create table usesUtensil (
	id int primary key,
	stepID int references step on delete set null on update cascade,
	utensilName name references utensil on delete cascade on update cascade,
);
create table usesIngredient (
	id int primary key,
	stepID int references step on delete cascade on update cascade,
	ingredientName name references ingredient on delete set null on update cascade,
	quantity int,
	unit name
);
create table belongs (
	recipieName name references recipie on delete cascade on update cascade,
	categoryName name references category on delete cascade on update cascade,
	primary key(recipieName, categoryName)
);

DROP FUNCTION ConvertUnits;
DROP FUNCTION GetDestinyUnit;
DROP FUNCTION dbo.GetIngredientAmounts;

go
CREATE Function dbo.ConvertUnits (@Val float, @From varchar(5), @To varchar(5)) returns float
AS BEGIN
	DECLARE @ExecuteString  varchar(500);
	select @ExecuteString = 'echo ' + STR(@Val) + @From + ' -> ' + @To + ' >> file.txt';
	exec master..xp_cmdshell @ExecuteString, no_output

	declare @Res float
	if @From = @To begin
		return @Val;
	end
	select @Res =
	case @From
		when 'g' then
			case @To
				when 'kg' then
					1000 * @Val
				when 'oz' then
					@Val / 28.34952
				else -500
			end
		when 'kg' then
			case @To
				when 'g' then
					@Val / 1000
				when 'oz' then
					@Val / (1000 * 28.34952)
				else -500
			end
		when 'oz' then
			case @To
				when 'g' then
					28.34952 * @Val
				when 'kg' then
					1000 * 28.34952 * @Val
				else -500
			end
		when 'F' then
			case @To
				when 'C' then
					(@Val - 32) * 5/9
				when 'K' then
					(@Val - 32) * (5 / 9) - 273.15
				else -500
			end
		when 'C' then
			case @To
				when 'F' then
					(9/5 * @Val) + 32
				when 'K' then
					@Val - 273.15
				else -500
			end
		when 'K' then 
			case @To
				when 'C' then
					@Val + 273.15
				when 'F' then
					32 + ((@Val + 273.15) * (9 / 5))
				else -500
			end
		when 'cal' then
			case @To
				when 'J' then
					@Val / 4.1868
				else -500
			end
		when 'J' then
			case @To
				when 'cal' then
					@Val * 4.1868
				else -500
			end
		else -500
	end

	return @Res
END

go
CREATE FUNCTION dbo.GetDestinyUnit (@Unit varchar(5), @Mass varchar(5), @Volume varchar(5), @Temperature varchar(5)) returns varchar(5)
AS BEGIN
	declare @Res varchar(5);
	-- print @Unit + ': ' + @Mass + ' ' + @Volume +  ' ' + @Temperature;
	DECLARE @ExecuteString  varchar(500);
	select @ExecuteString = 'echo ' + @Unit + ': ' + @Mass + ' ' + @Volume +  ' ' + @Temperature + ' >> file.txt';
	exec master..xp_cmdshell @ExecuteString, no_output
	select @Res =
	case @Unit
		when 'g' then  @Mass
		when 'kg' then @Mass
		when 'oz' then @Mass

		when 'F' then @Temperature
		when 'C' then @Temperature
		when 'K' then @Temperature

		when 'cal' then @Volume
		when 'J'   then @Volume
		else null
	end
	return @Res
END
go

create table usesIngredient (
	id int primary key,
	stepID int references step on delete cascade on update cascade,
	ingredientName name references ingredient on delete set null on update cascade,
	quantity int,
	unit name
);
go
CREATE FUNCTION dbo.GetIngredientAmounts (@Recipie varchar(20), @Mass varchar(5), @Volume varchar(5), @Temperature varchar(5)) RETURNS TABLE -- @res table (ingredientName name, quantity float, unit varchar(5))
AS --BEGIN
	return (
		select t.ingName, sum(t.quantity) as amount, t.w
		from (
			select 
				usesIngredient.ingredientName as ingName, 
				dbo.ConvertUnits(usesIngredient.quantity, usesIngredient.unit, dbo.GetDestinyUnit(usesIngredient.unit, @Mass, @Volume, @Temperature)) as quantity,
				 dbo.GetDestinyUnit(usesIngredient.unit, @Mass, @Volume, @Temperature) as w
			from
				usesIngredient join has
				on usesIngredient.stepID = has.stepID
			where has.recipieName = @Recipie
		) as t
		group by t.ingName, t.w
	)
--END
go

drop proc AddStep;
go
CREATE PROC project.AddStep (@recipieName name, @stepNum int, @description text, @image varchar(20))
AS BEGIN
BEGIN TRAN
	declare @lenStep int;
	select @lenStep = count(*)+1 from step;
	declare @lenHas int;
	select @lenHas = count(*)+1 from has;

	insert into step
	(stepID, description, image)
	values
	(@lenStep, @description, @image);
	insert into has
	(id, recipieName, stepID, stepNum)
	values
	(@lenHas, @recipieName, @lenStep, @stepNum);
COMMIT TRAN

return @lenStep;
END

select * from recipie;
select * from step;
select * from has;

declare @res as int
exec @res=dbo.AddStep 'alksjdf', 0, 'Something else', 'img.png'

drop proc project.AddIngredient;
go
CREATE PROC project.AddIngredient (@ingredientName varchar(20), @description text, @quantity float, @unit varchar(5))
AS BEGIN
BEGIN TRAN
	declare @lenUse int;
	select @lenUse = count(*) from usesIngredient;

	declare @lenStep int;
	select @lenStep = count(*) from step;

	insert into ingredient
	(ingredientName, description)
	values
	(@ingredientName, @description);

	insert into usesIngredient
	(id, stepID, ingredientName, quantity, unit)
	values
	(@lenUse, @lenStep, @ingredientName, @quantity, @unit);

	if @@ERROR <> 0
		ROLLBACK TRAN
COMMIT TRAN
END

-- trigger to automatically inser step in the midle of the list.
go
CREATE TRIGGER insertStepInTheMiddle on dbo.has
AFTER INSERT
AS BEGIN
	declare @newStep as int;
	select @newStep = inserted.stepNum;

	update has
	set has.stepNum = has.stepNum + 1
	where has.stepNum >= @newStep
END

-- indexes
create index belongsCatName on belongs(categoryName) 
-- create index idx_name on usesIngredient(id) 
-- create index idx_name on usesUtensil(id) 

create index hasRecName on has(recipieName) 
create index hasStepNum on has(stepNum) 

-- create index idx_name on category() 
-- create index idx_name on ingredient() 
-- create index idx_name on utensil() 

create index recipieName on recipie(name) 
create index recipieAuthor on recipie(author) 

-- this turns on advanced options and is needed to configure xp_cmdshell
EXEC sp_configure 'show advanced options', '1'
RECONFIGURE
-- this enables xp_cmdshell
EXEC sp_configure 'xp_cmdshell', '1' 
RECONFIGURE
select * from dbo.GetIngredientAmounts ('Target', 'kg', 'L', 'C');
