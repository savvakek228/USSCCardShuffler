# USSCCardShuffler
Сортировщик колод. Реализован с помощью .NET Core 3.1.
Подумать об использовании БД - сюда отлично встает MS SQL Server + Dapper.
Dapper - достаточно быстрая и легкая ORM, но можно и любую другую(NHibernate, EF Core).
В этом случае интерфейс для операций с колодами мог бы быть реализован по паттерну "Репозиторий", а сущности бы были такие:

Колода (ID(INT, PRIMARY KEY IDENTITY(1,1)), Название(NVARCHAR(50), Карта(ID Карты)) 1->M Карта(ID Карты,Масть(INT, для удобства работы с Enum при маппинге),Вес(INT, для того же))

