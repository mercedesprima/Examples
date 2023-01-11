// Вид 1: не принимают аргументы и не возвращают
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2: принимают аргументы, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{

    int i = 0;

    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент -  увеличение на 1
    }
}
// Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "новый текст");

// Вид 3: не принимают аргументы, но возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4: принимают аргументы, но возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "fhjv ");
Console.WriteLine(res);

// Задача. 
// Вывести таблицу умножения на экран

for (int i = 1; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы "к" заменить большими "К ",
// а большие "С" заменить маленькими "с".
// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прксского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);