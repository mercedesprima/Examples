// Задача. Задать массив из N положительных чисел и найти в нем сумму двухзначных элементов. 
int[] elements = new int[10];

int length = elements.Length;
int index = 0;
int sum = 0;

while (index < length)
{
    int current = Random.Shared.Next(30);
    elements[index] = current;

Console.WriteLine(elements[index]);

    if (current >= 10 && current <= 99)
    { 
        sum = sum + current;
    }
    index = index +1;
}
Console.WriteLine("--");
Console.WriteLine(sum);

