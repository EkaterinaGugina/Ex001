// Ex2 - пример применения цикла for для вывода таблицы умножения.
for (int i = 2; i <= 10; i++)
{
for (int j = 2; j <= 10; j++)
{
Console.Write($"{j} * {i} = {i * j}     ");
}
Console.WriteLine();
}
