-- Создание нового пользователя
CREATE USER 'CustomAdmin'@'localhost' IDENTIFIED BY 'adminPassword';

-- Назначение прав на базу данных
GRANT ALL PRIVILEGES ON demoexam2024.* TO 'CustomAdmin'@'localhost';

-- Применение изменений
FLUSH PRIVILEGES;