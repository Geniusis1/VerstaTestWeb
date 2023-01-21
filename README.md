# VerstaTestWeb
## Это тестовое задание на вакансию разработчик C# для компании Versta24

### Запуск приложения


**>Entity Framework был скачен только под SQL Server**


1. В `VerstaTestWeb.Models.Order.cs` строка 33, поменять параметр подключения к БД
2. В консоле пакетного менаджера ввести `Update-Database`

### Окно просмотра
`http://yourHost:port/orders`

![Image http://yourHost:port/orders)](https://github.com/Geniusis1/VerstaTestWeb/blob/master/Images/1.png)

### Окно добавления заказов
`http://yourHost:port/orders/new`

![Image http://yourHost:port/orders/new)](https://github.com/Geniusis1/VerstaTestWeb/blob/master/Images/2.png)

### Структура БД

```
CREATE TABLE [dbo].[orders] (
    [id]                INT            IDENTITY (1, 1) NOT NULL,
    [sender_city]       NVARCHAR (MAX) NOT NULL,
    [sender_country]    NVARCHAR (MAX) NOT NULL,
    [recipient_city]    NVARCHAR (MAX) NOT NULL,
    [recipient_country] NVARCHAR (MAX) NOT NULL,
    [cargo_weight]      REAL           NOT NULL,
    [pickupDate]        DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ([id] ASC)
);
```
