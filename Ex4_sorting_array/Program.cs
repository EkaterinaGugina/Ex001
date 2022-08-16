// See https://aka.ms/new-console-template for more information
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)   // метод вывода на экран массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort_vozr(int[] array)         // Метод сортировки по возрастанию
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) 
                {   
                    minPosition = j;
                }
            }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
SelectionSort_vozr(arr);
PrintArray(arr);

void SelectionSort_ubav(int[] array)         // Метод сортировки по убыванию
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] > array[maxPosition]) 
                {   
                    maxPosition = j;
                }
            }
        int current = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = current;
    }
}
SelectionSort_ubav(arr);
PrintArray(arr);
