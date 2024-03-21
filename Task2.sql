SELECT products.name, categories.name FROM products
    LEFT JOIN product_category ON products.id = product_category.product_id
    LEFT JOIN categories ON categories.id = product_category.category_id