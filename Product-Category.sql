
SELECT p.Name, c.Name
FROM Products p
-- Используем LEFT JOIN для связи таблицы Products с таблицей ProductCategory
LEFT JOIN ProductCategory pc 
ON p.Id = pc.ProductId
-- Используем LEFT JOIN для связи таблицы ProductCategory с таблицей Categories
LEFT JOIN Categories с
ON pc.CategoryId = c.Id;