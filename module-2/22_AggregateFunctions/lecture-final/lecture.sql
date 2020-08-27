-- ORDERING RESULTS

-- Populations of all countries in descending order
select name,population from country order by population desc;
--Names of countries and continents in ascending order
select name,continent from country order by continent,name;
-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
select top 10 name,lifeexpectancy from country order by lifeexpectancy desc;
-- 10 lowest life expectancies
select top 10 name,lifeexpectancy from country where lifeexpectancy is not null order by lifeexpectancy asc;

-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city
select name + ', ' + district from city
where district in ('California','Oregon','Washington')
order by district,name;
-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World
SELECT AVG(lifeexpectancy)
FROM country;
-- Total population in Ohio
select sum(population) from city
where district='Ohio';
-- The surface area of the smallest country in the world
select min(surfacearea) from country;
-- The 10 largest countries in the world
select top 10 * from country
order by surfacearea desc;
-- The number of countries who declared independence in 1991
select count(*) from country where indepyear = 1991;
-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
select language,count(countrycode) as 'Countries' from countrylanguage
group by language
order by Countries desc
-- Count the number of language in each country, ordered from most countries to least
select countrycode,count(countrycode) as 'Countries' from countrylanguage
group by countrycode
-- Average life expectancy of each continent ordered from highest to lowest
SELECT continent, AVG(lifeexpectancy) AS avg_lifeexpectancy
FROM country
GROUP BY continent
ORDER BY avg_lifeexpectancy DESC;

-- Exclude Antarctica from consideration for average life expectancy
SELECT continent, AVG(lifeexpectancy) AS avg_lifeexpectancy
FROM country
where continent != 'Antarctica'
GROUP BY continent
ORDER BY avg_lifeexpectancy DESC;
-- Sum of the population of cities in each state in the USA ordered by state name
select district,sum(population) from city
where countrycode = 'USA'
group by district
order by district
-- The average population of cities in each state in the USA ordered by state name
select district,avg(population) from city
where countrycode = 'USA'
group by district
order by district
-- SUBQUERIES
-- Find the names of cities under a given government leader
select name from city where countrycode in (select code from country where headofstate like 'Eli%')
-- Find the names of cities whose country they belong to has not declared independence yet
select name from city where countrycode in (select code from country where indepyear is null)
-- Additional samples
-- You may alias column and table names to be more descriptive
select name as 'City Name' from city as C where C.countrycode in (select code from country where indepyear is null)

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)
SELECT name, population
FROM city
WHERE countryCode = 'USA'
ORDER BY name ASC, population DESC;
-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.
SELECT (name + ' is in the state of ' + district) AS city_state
FROM city
WHERE countryCode = 'USA';

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table
SELECT COUNT(name) AS city_count
FROM city;

select count(indepyear) from country
select count(name) from country
-- Also counts the number of rows in the city table
SELECT COUNT(population)
FROM city;
-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.
SELECT SUM(population) AS total_city_population, COUNT(population) AS number_of_cities, AVG(population) AS avergage_population
FROM city;

-- Gets the MIN population and the MAX population from the city table.
SELECT MIN(population) AS smallest_population, MAX(population) AS largest_population
FROM city;
-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
SELECT countrycode, MIN(population), MAX(population)
FROM city
GROUP BY countrycode;