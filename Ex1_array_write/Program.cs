// Ex1 - пример применения цикла for для вывода на экран массива внутри метода
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]}  ");
}
Console.WriteLine();
}
PrintArray(arr);
