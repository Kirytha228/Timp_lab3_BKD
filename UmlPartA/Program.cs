var first = new CopyPlan("Первый", 4, 15);
var second = new CopyPlan("Второй", 0, 15);
var third = new CopyPlan("Третий", 1, 2);
var own = new CopyPlan("Свой", 12, 8);
BackupPlan named = first;
IValue value = first;
var calc = new Calculator();

void Check(string title, int expected, int actual)
{
    string status = expected == actual ? "OK" : "ОШИБКА";
    Console.WriteLine($"{title}: ожидается {expected}, получено {actual} - {status}");
}

Console.WriteLine("Резервное копирование, объём копии в МБ");
Check($"{named.Name} (через BackupPlan и IValue)", 60, value.GetValue());
Check(second.Name, 0, second.GetValue());
Check(third.Name, 2, third.GetValue());
Check(own.Name, 96, own.GetValue());

IValue[] items = { first, second };
Check("Всего (Первый + Второй)", 60, calc.Total(items));
Check("Повтор", 60, calc.Total(items));
Check("Пустой набор", 0, calc.Total(Array.Empty<IValue>()));

IValue[] mixed = { first, new ConstantValue() };
Check("Разные типы (Первый + ConstantValue)", 67, calc.Total(mixed));

IValue[] custom = { first, third, own, new ConstantValue() };
Check("Свой набор (Первый + Третий + Свой + ConstantValue)", 165, calc.Total(custom));
