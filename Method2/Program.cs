// Method2 - метод, который на входе принимает аргументы, но ничего не возвращает.
void Method2(string msg) 
{
    Console.WriteLine(msg); 
}
Method2("Мой дядя самых честных правил");
Console.WriteLine(); 

void Method21(string msg, int count)
{
int i = 0;
while (i < count)
{
    Console.WriteLine(msg); 
    i++;
}
Console.WriteLine(); 
}
Method21("Самый лучший день  ", 4);

Method21(msg: "Какой хороший пень  ", count: 3);
//Явно указывая наименование аргумента, не обязательно писать их по порядку.
