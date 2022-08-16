// Method4 - пример метода, который на входе принимает аргументы, и возвращает некоторый аргумент.

//Возвращать будем строку string, передавать будем int. Мы будем string компоновать друг за другом count раз.
string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i < count)
    {
    result = result + text;
    i++;
    }
return result;
}

string res = Method4(6, "С добрым утром! ");
Console.Write(res);
