go
CREATE TRIGGER insertStepInTheMiddle on project.has
AFTER INSERT
AS BEGIN
	declare @newStep as int;
	select @newStep = inserted.stepNum;

	update has
	set has.stepNum = has.stepNum + 1
	where has.stepNum >= @newStep
END