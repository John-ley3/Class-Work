-- SELECT ... FROM
-- Selecting the names for all countries
select name from country;

-- Selecting the name and population of all countries
select name,population from country;

-- Selecting all columns from the city table
select * from city;

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
select * from city where district='Ohio';

-- Selecting countries that gained independence in the year 1776
select * from country where indepyear = 1776;

-- Selecting countries not in Asia
SELECT name,continent FROM country WHERE continent != 'Asia';

-- Selecting countries that do not have an independence year
SELECT * from country where indepyear IS NULL;
-- Selecting countries that do have an independence year
SELECT name from country where indepyear is not null;

-- Selecting countries that have a population greater than 5 million
SELECT * FROM country WHERE population > 5000000;


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
SELECT * FROM city
	WHERE district = 'Ohio'
	AND population > 400000
-- Selecting country names on the continent North America or South America
SELECT name, continent FROM country WHERE continent IN ('North America', 'South America');
SELECT name,continent FROM country WHERE continent = 'North America' OR continent = 'South America'



-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword
SELECT name,population, surfacearea,lifeexpectancy,(population / surfacearea) as Density from country where continent = 'Asia'
SELECT Top 10 name,population, surfacearea,lifeexpectancy,(population / surfacearea) as Density from country where continent = 'Asia'



