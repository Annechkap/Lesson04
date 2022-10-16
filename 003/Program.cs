// 3. Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.

int[] Created_Array()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0 , 10);
    }
    return array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

int[] arr = Created_Array();
Print(arr);