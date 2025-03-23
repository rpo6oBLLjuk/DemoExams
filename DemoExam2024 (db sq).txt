create database DemoExam2024;
use DemoExam2024;
-- Создание таблицы для хранения информации о клиентах
CREATE TABLE Clients (
    ClientID INT PRIMARY KEY AUTO_INCREMENT,
    ClientName VARCHAR(255) NOT NULL,
    ContactInfo VARCHAR(255)
);

-- Создание таблицы для хранения информации об исполнителях
CREATE TABLE Executors (
    ExecutorID INT PRIMARY KEY AUTO_INCREMENT,
    ExecutorName VARCHAR(255) NOT NULL,
    ContactInfo VARCHAR(255)
);

-- Создание таблицы для хранения информации о заявках
CREATE TABLE Requests (
    RequestID INT PRIMARY KEY AUTO_INCREMENT,
    RequestNumber VARCHAR(50) NOT NULL UNIQUE,
    DateAdded DATETIME NOT NULL,
    Equipment VARCHAR(255) NOT NULL,
    FaultType VARCHAR(255) NOT NULL,
    ProblemDescription TEXT,
    ClientID INT,
    Status ENUM('в ожидании', 'в работе', 'выполнено') DEFAULT 'в ожидании',
    ExecutorID INT,
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
    FOREIGN KEY (ExecutorID) REFERENCES Executors(ExecutorID)
);

-- Создание таблицы для хранения комментариев исполнителей
CREATE TABLE Comments (
    CommentID INT PRIMARY KEY AUTO_INCREMENT,
    RequestID INT,
    ExecutorID INT,
    CommentText TEXT,
    CommentDate DATETIME NOT NULL,
    FOREIGN KEY (RequestID) REFERENCES Requests(RequestID),
    FOREIGN KEY (ExecutorID) REFERENCES Executors(ExecutorID)
);

-- Создание таблицы для хранения истории изменений статусов заявок
CREATE TABLE StatusHistory (
    StatusHistoryID INT PRIMARY KEY AUTO_INCREMENT,
    RequestID INT,
    OldStatus ENUM('в ожидании', 'в работе', 'выполнено'),
    NewStatus ENUM('в ожидании', 'в работе', 'выполнено'),
    ChangeDate DATETIME NOT NULL,
    FOREIGN KEY (RequestID) REFERENCES Requests(RequestID)
);