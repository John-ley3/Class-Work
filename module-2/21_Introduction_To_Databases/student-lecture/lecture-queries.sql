-- SELECT ... FROM
-- Selecting the names for all countries
select name from country

-- Selecting the name and population of all countries
select name,population from country

-- Selecting all columns from the city table
select * from country

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
select * from city where district='Ohio'

-- Selecting countries that gained independence in the year 1776
select * from country where indepyear= 1776

-- Selecting countries not in Asia
SELECT name,continent FROM country where continent != 'Asia'

-- Selecting countries that do not have an independence year
SELECT * from country where indepyear Is Null

-- Selecting countries that do have an independence year
SELECT * from country where indepyear Is Not Null

-- Selecting countries that have a population greater than 5 million
SELECT * FROM country WHERE population > 5000000


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
SELECT * FROM city 
		WHERE district = 'Ohio' 
		AND population > 400000


-- Selecting country names on the continent North America or South America
SELECT name, continent FROM country WHERE continent IN ('North American', 'South America')



-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword
SELECT name, population, surfacearea, lifeexpectancy, (population /surfacearea ) AS Density FROM country WHERE continent ='Asia'

--Getting to top n amount of records from a query

--in the lecture final 


