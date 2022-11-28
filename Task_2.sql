SELECT p.Id, p.CategoryId
FROM Product p
LEFT JOIN Category c
ON p.CategoryId = c.Id