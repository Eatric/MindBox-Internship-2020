CREATE TABLE IF NOT EXISTS `categories` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
 
INSERT INTO `categories` (`id`, `name`) VALUES
    (1, 'Продукты'),
    (2, 'Хозяйственные товары'),
    (3, 'Товары для дома');
 
CREATE TABLE IF NOT EXISTS `products` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  `category_id` INT(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
 
INSERT INTO `products` (`id`, `name`, `category_id`) VALUES
    (1, 'Молоко', 1),
    (2, 'Хлеб', 1),
    (3, 'Шампунь', 2),
    (4, 'Молоко', 3),
    (5, 'Хлеб', 3),
    (6, 'Газировка', 0);
 
SELECT products.name AS ProductName, categories.name AS CategoryName FROM `products` LEFT JOIN `categories` ON products.category_id = categories.id;