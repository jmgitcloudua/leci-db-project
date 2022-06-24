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