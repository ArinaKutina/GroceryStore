# Программный продукт для магазина продуктов «Grocery Store».
### Название приложения: GroceryStore
### Описание приложения:
**Продукт «GroceryStore» предназначен для отображения информации о товарах, их цене, производителе, скидке. Пользователь может выбрать интересующий товар, при желании удалить его из корзины, а также получить чек.**

# Функции, реализованные в программе:
1. **Просмотр всего товара.** На главном экране присутствует кнопка, при нажатии на которую пользователь переходит в окно, где можно просмотреть весь список товаров и их характеристики.
2. **Добавление товара в корзину.** Нужно выбрать товар и нажать на него правой кнопкой мыши для вызова контекстного меню с кнопкой «Добавить в корзину». 
3. **Получение чека.** После добавления товаров в корзину нужно нажать кнопку «Перейти к Чеку». Пользователю будет представлен чек с названием магазина, списком всех купленных товаров, общей ценой с учетом и без учета скидки.
4. **Удаление товара из корзины.** При желании пользователь может удалить единицу товара в окне Корзина, при условии что будет введен PIN-код. Если пользователь ввел PIN-код, то вызвав контекстное меню пользователь может удалить товар. Если пользователь не введет PIN-код или PIN-код будет неверным, то появится соответсвующее сообщение.
5. **Поиск по штрихкоду.** При нажатии на кнопку «Найти товар по штрихкоду» откроется окно, где пользователь может ввести штрихкод желаемого товара и соответсвующий результат выведется в таблицу.
6. **Запись логов.** Благодаря классу Logger происходит запись логов каждой нажатой кнопки в файл log.txt. 
7. **Юнит-тестирование DLL.** В рамках проекта было проведено юнит-тестирование DLL, которая используется в приложении. Юнит-тесты были разработаны для каждого метода в DLL, что позволило проверить корректность её работы.

# Технологии, которые были использованы для разработки приложения:
- **C#** - объектно-ориентированный язык программирования.
- **Visual Studio Community 2022** - интегрированная среда разработки (IDE), которая обеспечивает удобное создание, отладку и развертывание приложений.
- **Windows Presentation Foundation** - система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем, графическая подсистема в составе .NET Framework, использующая язык XAML.
- **Microsoft SQL Server** - система управления реляционными базами данных (РСУБД), разработанная корпорацией Microsoft.
- **Entity Framework** - это набор технологий в ADO.NET, которые поддерживают разработку программных приложений, ориентированных на данные.
- **MSTest** - это фреймворк для модульного тестирования в Visual Studio, который предоставляет классы и члены в пространстве имен Microsoft.VisualStudio.TestTools.UnitTesting для написания модульных тестов.

# Описание базы данных:
#### Файл базы данных называется GroceryStore.bacpac <br/>
Файл базы данных расположен по пути **https://github.com/ArinaKutina/GroceryStore/tree/master/GroceryStore** </br>
В базе данных находятся 4 таблиц _Products_, _Producers_, _Promotions_, _ComposeOfCheck_.

- **Таблица «Products»** _(idProduct, nameProduct, numBarcode, idProducer, expirationDate, idPromotion, discount, count, price)_ содержит информацию о товарах
- **Таблица «Producers»** _(idProducer, nameProducer)_ содержит информацию о производителе товара
- **Таблица «Promotions»** _(idPromotion, statePromotion)_ содержит информацию о скидке
- **Таблица «ComposeOfCheck»** _(idCheck, idProduct, count, fullPrice, price)_ содержит информацию о типах товаров

# Скриншоты приложения:

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/Mainwindow.png">
</br>Главная страница
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/AddToBasket.png">
</br>Добавление в корзину
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/RemoveFromBasket.png">
</br>Удаление из корзины
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/ErrorRemove.png">
</br>Удаление из корзины(ошибка)
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/Check.png">
</br>Чек
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/Stock.png">
</br>Просмотр товаров на складе
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/Search.png">
</br>Поиск товара по штрихкоду
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/log.png">
</br>Лог-файл
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GroceryStore/blob/master/GroceryStore/Screenshots/Unit tests.png">
</br>Юнит-тестирование DLL
</br> </br> </br>
</p>
