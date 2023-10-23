//порождающий (creational) паттерн gang of four использующий специальный объект 
//для создания других объектов, абстрагируясь (получая интефейс) от создания конкретного объекта
//этот паттерн особенно полезен в стратегиях для уменьшения зависимости (reduce coupling) в коде
using Factory;
using AbstractFactory = Factory.Factory;
//было:

//var middleware = new Middleware1();
//middleware.DoAction();

//стало:

var factory = new AbstractFactory();

var middleware = factory.GetMiddleware(1);
middleware.DoAction();

middleware = factory.GetMiddleware(2);
(middleware as IMiddleware).DoAction();
