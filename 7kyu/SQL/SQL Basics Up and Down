SELECT
  (CASE mod(sum(number1), 2) WHEN 1 THEN min(number1) ELSE max(number1) END) AS number1,
  (CASE mod(sum(number2), 2) WHEN 1 THEN min(number2) ELSE max(number2) END) AS number2
FROM numbers;