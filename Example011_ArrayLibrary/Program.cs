﻿void FillArray(int[] collection) // Заполняется массив
{
    int length = collection.Length; // получаем длину массива
    int index = 0; // по умолчанию 0
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1
        index++;
    }
}

void PrintArray(int[] collection)
{
int count = collection.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine(collection[position]);
    position++;
}
}
int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        } 

        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);