// Method2 - метод, который на входе принимает аргументы, но ничего не возвращает.
void Method2(string msg) 
{
    Console.WriteLine(msg); 
}
Method2("Мой дядя самых честных правил");


void Method21(string msg, int count)
{
int i = 0;
while (i < count)
{
    Console.WriteLine(msg); 
    i++;
}
}
Method21("Самый лучший день  ", 4);
