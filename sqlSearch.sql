Select Product.Name, Category.name from Product 
left join ProductCategory on Product.id = ProductCategory.ProductId
left join Category on Category.id = ProductCategory.categoryid;