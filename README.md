# ИДЗ 3. UML и реализация классов на C#

Вариант 2 «Резервное копирование».

## Что где лежит

- `UmlPartA/` – часть А, классы по готовой диаграмме: `Model.cs` (BackupPlan, IValue, CopyPlan, Calculator, ConstantValue) и `Program.cs` с проверками.
- `UmlPartB/` – часть Б, код из задания: `Model.cs` (Operator, Crew, CopyRecord, BackupLog) и `Program.cs`.
- `diagrams/` – диаграммы классов в PlantUML: `PartA.puml`, `PartB.puml` и картинки `PartA.png`, `PartB.png`.

## Запуск

Из корня репозитория:

```
dotnet run --project UmlPartA
dotnet run --project UmlPartB
```

Или `dotnet run` в папке нужного проекта.

## Ожидаемый вывод

Часть А: все проверки с OK (60, 0, 2, 96, всего 60, повтор 60, пустой набор 0, с ConstantValue 67, свой набор 165).

Часть Б:

```
Участник: Анна
Первый журнал: 1
Второй журнал: 0
После добавления: 1
Первый без изменений: 1
```

## Версия SDK

.NET SDK 10.0 или новее, проекты net10.0.

Диаграммы редактируются в любом редакторе PlantUML, например на plantuml.com или в расширении PlantUML для VS Code.
