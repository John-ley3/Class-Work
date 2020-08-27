-- ********* INNER JOIN ***********

-- Let's find out who made payment 16666:
select * from payment where payment_id=16666
-- Ok, that gives us a customer_id, but not the name. We can use the customer_id to get the name FROM the customer table
select * from customer join payment on customer.customer_id = payment.customer_id where payment_id = 16666

-- We can see that the * pulls back everything from both tables. We just want everything from payment and then the first and last name of the customer:
select first_name,last_name,payment.* from customer join payment on customer.customer_id = payment.customer_id where payment_id = 16666
-- But when did they return the rental? Where would that data come from? From the rental table, so let’s join that.
select first_name,last_name,payment.*,return_date from customer 
	join payment on customer.customer_id = payment.customer_id 
	join rental on payment.rental_id = rental.rental_id
	where payment_id = 16666

-- What did they rent? Film id can be gotten through inventory.
select first_name,last_name,payment.*,return_date,title from customer 
	join payment on customer.customer_id = payment.customer_id 
	join rental on payment.rental_id = rental.rental_id
	join inventory on inventory.inventory_id = rental.inventory_id
	join film on film.film_id = inventory.film_id
	where payment_id = 16666
-- What if we wanted to know who acted in that film?
select customer.first_name as 'Customer First Name',customer.last_name as 'Customer Last Name',actor.first_name,actor.last_name,payment.*,return_date,title from customer 
	join payment on customer.customer_id = payment.customer_id 
	join rental on payment.rental_id = rental.rental_id
	join inventory on inventory.inventory_id = rental.inventory_id
	join film on film.film_id = inventory.film_id
	join film_actor on film_actor.film_id = film.film_id
	join actor on film_actor.actor_id = actor.actor_id
	where payment_id = 16666

select actor.first_name,actor.last_name from film 
	join film_actor on film.film_id = film_actor.film_id
	join actor on actor.actor_id = film_actor.actor_id
	where film.film_id IN (select inventory.film_id from customer 
	join payment on customer.customer_id = payment.customer_id 
	join rental on payment.rental_id = rental.rental_id
	join inventory on inventory.inventory_id = rental.inventory_id
	join film on film.film_id = inventory.film_id
	where payment_id = 16666)
-- What if we wanted a list of all the films and their categories ordered by film title
select film.title,category.name from film 
	join film_category on film.film_id = film_category.film_id
	join category on film_category.category_id = category.category_id
	order by film.title
-- Show all the 'Comedy' films ordered by film title
select film.title,category.name from film 
	join film_category on film.film_id = film_category.film_id
	join category on film_category.category_id = category.category_id
	where category.name = 'Comedy'
	order by film.title
-- Finally, let's count the number of films under each category
select count(film.title),category.name from film 
	join film_category on film.film_id = film_category.film_id
	join category on film_category.category_id = category.category_id
	group by category.name
	order by category.name

-- ********* LEFT JOIN ***********

-- (There aren't any great examples of left joins in the "dvdstore" database, so the following queries are for the "world" database)

-- A Left join, selects all records from the "left" table and matches them with records from the "right" table if a matching record exists.
	use World
	go
	SELECT c.name, ci.name
	FROM country c
	JOIN city ci ON c.capital = ci.id
-- Let's display a list of all countries and their capitals, if they have some.
	use world
	go
	select country.name, city.name from country
	join city on city.id = country.capital
-- Only 232 rows
-- But we’re missing entries:

-- There are 239 countries. So how do we show them all even if they don’t have a capital?
-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. If we want to show data FROM the left side table everytime, we can use a different join:
SELECT c.name, ci.name
FROM country c
LEFT JOIN city ci ON c.capital = ci.id
-- *********** UNION *************

-- Back to the "dvdstore" database...

-- Gathers a list of all first names used by actors and customers
-- By default removes duplicates
select first_name from actor
union
select first_name from customer
-- Gather the list, but this time note the source table with 'A' for actor and 'C' for customer
select first_name, 'A' AS Source from actor
union
select first_name, 'C' AS Source from customer
