-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT * FROM film
JOIN film_actor on film.film_id = film_actor.film_id
WHERE actor_id= (SELECT actor_id FROM actor WHERE first_name='Nick' AND last_name='Stallone');


-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT * FROM film
JOIN film_actor on film.film_id = film_actor.film_id
WHERE actor_id= (SELECT actor_id FROM actor WHERE first_name='Rita' AND last_name='Reynolds');

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT * FROM film
JOIN film_actor on film.film_id = film_actor.film_id
WHERE actor_id= (SELECT actor_id FROM actor WHERE first_name='Judy' AND last_name='Dean')
OR actor_id= (SELECT actor_id FROM actor WHERE first_name='River' AND last_name='Dean');

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT * FROM film
JOIN film_category on film.film_id = film_category.film_id
WHERE category_id= (SELECT category_id FROM category WHERE name='Documentary');


-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT * FROM film
JOIN film_category on film.film_id = film_category.film_id
WHERE category_id= (SELECT category_id FROM category WHERE name='Comedy');

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT * FROM film
JOIN film_category on film.film_id = film_category.film_id
WHERE category_id= (SELECT category_id FROM category WHERE name='Children')
AND rating='G';

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT * FROM film
JOIN film_category on film.film_id = film_category.film_id
WHERE category_id= (SELECT category_id FROM category WHERE name='Family')
AND rating='G'
AND length < 120;

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT * FROM film
JOIN film_actor on film.film_id = film_actor.film_id
WHERE actor_id= (SELECT actor_id FROM actor WHERE first_name='Matthew' AND last_name='Leigh')
AND rating='G';

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT * FROM film
JOIN film_category on film.film_id = film_category.film_id
WHERE category_id= (SELECT category_id FROM category WHERE name='Sci-Fi')
AND release_year='2006';

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT * FROM film
JOIN film_category on film.film_id = film_category.film_id
JOIN film_actor on film.film_id = film_actor.film_id
WHERE category_id= (SELECT category_id FROM category WHERE name='Action')
AND actor_id= (SELECT actor_id FROM actor WHERE first_name='Nick' AND last_name='Stallone')

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT * FROM store
JOIN address on store.address_id = address.address_id;


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT store.store_id, address, first_name, last_name FROM store
JOIN address on store.address_id = address.address_id
JOIN staff on store.manager_staff_id = staff.staff_id;


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP 10 first_name, last_name, count(rental.customer_id) AS rentalcount FROM rental 
JOIN customer on rental.customer_id = customer.customer_id
GROUP BY first_name, last_name 
ORDER BY rentalcount desc;

-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP 10 first_name, last_name, SUM(amount) AS rentalsum FROM payment 
JOIN customer on payment.customer_id = customer.customer_id
GROUP BY first_name, last_name 
ORDER BY rentalsum desc;

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10 title, COUNT(film.film_id) AS film_id_count FROM rental
JOIN inventory on inventory.inventory_id = rental.inventory_id
JOIN film on film.film_id = inventory.film_id
GROUP BY film.title
order by film_id_count desc;


-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP 10 title, COUNT(film_category.film_id) AS film_id_count FROM rental
JOIN inventory on inventory.inventory_id = rental.inventory_id
JOIN film on film.film_id = inventory.film_id
JOIN film_category on film_category.film_id = film.film_id
GROUP BY category.name
order by film_id_count desc;

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)


-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
