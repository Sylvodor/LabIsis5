Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int res;
Console.WriteLine("Введите операцию (+-*/):");
char c = Convert.ToChar(Console.ReadLine());
if (c == '+')
{
    res = a + b;
    Console.WriteLine("Результат - " + res);
}
else if (c == '-')
{
    res = a - b;
    Console.WriteLine("Результат - " + res);
}
else if (c == '*')
{
    res = a * b;
    Console.WriteLine("Результат - " + res);
}
else if (c == '/')
{
    res = a / b;
    Console.WriteLine("Результат - " + res);
}
else
{
    Console.WriteLine("Оператор не распознан!!!");
}