# WebTurist


Учебный проект по посторению БД и веб-приложения для туристичесткого агенства.

Структура:

1. WebTurist.csproj - Asp.Net Core Razor Pages.
2. Models.csproj - Модели для работы со страницами.
3. DataBaseLib.csproj - подключение к БД с помощью Entity Framework Core.
4. Contract.csproj - Контракты. 
5. ServiceData.csproj - Сервис, реализующий контракт. Получение данных из БД с помощью инструментов Entity Framework Core и Dapper.
6. DataTest.csproj - Проект для тестов.

База данных:

При проектировании проекта использовался подход Database-first. БД -Microsoftsql Server.


