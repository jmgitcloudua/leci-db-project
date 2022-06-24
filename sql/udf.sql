go
CREATE Function project.ConvertUnits (@Val float, @From varchar(5), @To varchar(5)) returns float
AS BEGIN

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
CREATE FUNCTION project.GetDestinyUnit (@Unit varchar(5), @Mass varchar(5), @Volume varchar(5), @Temperature varchar(5)) returns varchar(5)
AS BEGIN
	declare @Res varchar(5);
	-- print @Unit + ': ' + @Mass + ' ' + @Volume +  ' ' + @Temperature;
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
CREATE FUNCTION project.GetIngredientAmounts (@Recipie varchar(20), @Mass varchar(5), @Volume varchar(5), @Temperature varchar(5)) RETURNS TABLE -- @res table (ingredientName name, quantity float, unit varchar(5))
AS --BEGIN
	return (
		select t.ingName, sum(t.quantity) as amount, t.w
		from (
			select 
				usesIngredient.ingredientName as ingName, 
				project.ConvertUnits(usesIngredient.quantity, usesIngredient.unit, project.GetDestinyUnit(usesIngredient.unit, @Mass, @Volume, @Temperature)) as quantity,
				 project.GetDestinyUnit(usesIngredient.unit, @Mass, @Volume, @Temperature) as w
			from
				usesIngredient join has
				on usesIngredient.stepID = has.stepID
			where has.recipieName = @Recipie
		) as t
		group by t.ingName, t.w
	)
--END
go