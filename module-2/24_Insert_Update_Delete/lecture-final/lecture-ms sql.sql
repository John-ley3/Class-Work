-- INSERT

-- 1. Add Klingon as a spoken language in the USA
insert into countrylanguage VALUES('USA','Klingon',1,.9)
-- 2. Add Klingon as a spoken language in Great Britain
insert into countrylanguage VALUES('GBR','Klingon',1,75)


-- UPDATE

-- 1. Update the capital of the USA to Houston
update country set capital=(select top 1 id from city where name='Houston') where code='USA'
select * from country join city on country.capital = city.id where code='USA'
-- 2. Update the capital of the USA to Washington DC and the head of state
update country set capital=(select top 1 id from city where district='District of Columbia' and name='Washington'),headofstate='Tom Medvitz' where code='USA'

-- DELETE

-- 1. Delete English as a spoken language in the USA
select * from countrylanguage where countrycode = 'USA' and language='English'
delete countrylanguage where countrycode = 'USA' and language='English'
-- 2. Delete all occurrences of the Klingon language 
select * from countrylanguage where language='Klingon'
delete countrylanguage where language='Klingon'

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
insert into countrylanguage(language) values ('Pig Latin') -- I need the other values for this to work
-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
insert into countrylanguage(percentage,countrycode,language,isofficial) values(.3,'ZZZ','Pig Latin',0)
-- 3. Try deleting the country USA. What happens?
delete from country where code='USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA
insert into countrylanguage values('USA','English',1,95)
-- 2. Try again. What happens?
insert into countrylanguage values('USA','English',1,95)
-- 3. Let's relocate the USA to the continent - 'Outer Space'
update country set continent='Outer Space' where code='USA'

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
BEGIN TRANSACTION
delete from countrylanguage
select * from countrylanguage
ROLLBACK TRANSACTION
select * from countrylanguage
-- 2. Try updating all of the cities to be in the USA and roll it back
BEGIN TRANSACTION
update city set countrycode='USA'
select * from city
commit TRANSACTION
select * from city

