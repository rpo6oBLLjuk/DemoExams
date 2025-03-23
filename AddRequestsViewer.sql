-- Создание нового пользователя
CREATE USER 'RequestsViewer'@'localhost' IDENTIFIED BY 'viewerPassword';

-- Назначение прав на базу данных
GRANT SELECT ON demoexam2024.requests TO 'RequestsViewer'@'localhost';

-- Применение изменений
FLUSH PRIVILEGES;