Select film.title 
from
(select film_id, count(film_id) as cnt 
from film_actor
where actor_id in (105, 122)
group by film_id 
order by cnt desc) abc

inner join film
on abc.film_id = film.film_id
where cnt=2 order by title asc