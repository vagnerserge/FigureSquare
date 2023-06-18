
SELECT p.Name, c.Name
FROM Products p
-- Using LEFT JOIN to join the Products table with the ProductCategory table
LEFT JOIN ProductCategory pc 
ON p.Id = pc.ProductId
-- Using LEFT JOIN to join the ProductCategory table with the Categories table
LEFT JOIN Categories ñ
ON pc.CategoryId = c.Id;