CREATE DATABASE dbname;
USE dbname;

create schema project;

create type name from varchar(20);
create type text from varchar(100);

create table project.recipie (
	recipieName name primary key,
	author name,
	calories int,
	preparingTime int
);
create table project.utensil (
	utensilName name primary key,
	dimention int,
	unit name
);
create table project.ingredient (
	ingredientName name primary key,
	description text
);
create table project.category (
	categoryName name primary key,
	description text,
);
create table project.step (
	stepID int primary key,
	description text,
	image varchar(20),
);
create table project.has (
	id int primary key,
	recipieName name references recipie on delete cascade on update cascade,
	stepID int references step on delete set null on update cascade,
	stepNum int,
);
create table project.usesUtensil (
	id int primary key,
	stepID int references step on delete set null on update cascade,
	utensilName name references utensil on delete cascade on update cascade,
);
create table project.usesIngredient (
	id int primary key,
	stepID int references step on delete cascade on update cascade,
	ingredientName name references ingredient on delete set null on update cascade,
	quantity int,
	unit name
);
create table project.belongs (
	recipieName name references recipie on delete cascade on update cascade,
	categoryName name references category on delete cascade on update cascade,
	primary key(recipieName, categoryName)
);

create index belongsCatName on belongs(categoryName) 

create index hasRecName on has(recipieName)

create index recipieName on recipie(author)