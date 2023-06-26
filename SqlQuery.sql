SELECT 
    p.ProductName AS 'Имя продукта',
    ISNULL(c.CategoryName, 'Категория не указана') AS 'Имя категории'
FROM 
    Products p
LEFT JOIN 
    ProductCategoryLink pcl ON p.ProductID = pcl.ProductID
LEFT JOIN 
    Categories c ON pcl.CategoryID = c.CategoryID