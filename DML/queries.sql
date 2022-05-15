use dbname;

-- Insert dummy data

insert into recipie
(recipieName, author, calories, preparingTime)
values
('Target', 'Me', 90, 10),
('Another', 'Someone', 900, 100);
insert into utensil
()
values
(),
insert into ingredient
(ingredientName, description)
values
('Tomate', 'fruta'),
('Carne', 'muito específico'),
('Leite', 'I forgor 💀');
insert into category
()
values
(),
insert into step
(stepID, description, image)
values
(1, 'Certa 1', 'img.png'),
(2, 'Certa 2', 'img.png'),
(3, 'Certa 3', 'img.png'),
(4, 'Errada 1', 'img.png'),
(5, 'Errada 2', 'img.png');
insert into has
(id, recipieName, stepID, stepNum)
values
(1, 'Target', 1, 1),
(2, 'Target', 2, 2),
(3, 'Target', 3, 3),
(4, 'Another', 4, 4),
(5, 'Another', 5, 5);
insert into usesUtensil
()
values
(),
insert into usesIngredient
(id, stepID, ingredientName, quantity, unit)
values
(1, 1, 'Tomate', 2, 'g'),
(2, 2, 'Leite', 4, 'kg'),
(3, 3, 'Tomate', 6, 'L'),
(4, 4, 'Carne', 100, 'nC');
insert into belongs
()
values
();

-- List ingredients

select * from ingredient;
select * from usesIngredient;

select * from (
		ingredient join usesIngredient
		on ingredient.ingredientName = usesIngredient.ingredientName
	);

select distinct ingredient.ingredientName
from
	(
		ingredient join usesIngredient
		on ingredient.ingredientName = usesIngredient.ingredientName
	) join (
		has join step
		on has.stepID = step.stepID
	) on usesIngredient.stepID = step.stepID
where has.recipieName = 'Target';