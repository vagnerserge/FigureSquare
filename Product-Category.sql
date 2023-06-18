
SELECT p.Name, c.Name
FROM Products p
-- ���������� LEFT JOIN ��� ����� ������� Products � �������� ProductCategory
LEFT JOIN ProductCategory pc 
ON p.Id = pc.ProductId
-- ���������� LEFT JOIN ��� ����� ������� ProductCategory � �������� Categories
LEFT JOIN Categories �
ON pc.CategoryId = c.Id;