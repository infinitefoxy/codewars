Select 
c.customer_id, 
email, 
COUNT(p.customer_id)::INT AS payments_count,
SUM(amount)::FLOAT as total_amount
FROM customer AS c, payment AS p
WHERE c.customer_id = p.customer_id
GROUP BY c.customer_id
ORDER BY total_amount DESC
LIMIT 10
;