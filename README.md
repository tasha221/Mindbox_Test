# Mindbox_Test

№2
Если данные находятся в разных таблицах, можно воспользоваться left join

SELECT *
FROM
  Products AS p
  LEFT JOIN Categories AS c
    ON p.name = c.product_name


Если данные в одной таблице и надо выбрать все неповторяющиеся пары

SELECT DISTINCT Product, Category FROM Products
WHERE Product is not null;
