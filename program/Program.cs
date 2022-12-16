
string[] GetStringArrayFromUser(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] GetLessThreeCharsArray(string[] arrayRes)
{
    int count = 0;
    for (int i = 0; i < arrayRes.Length; i++)
    {
        if (arrayRes[i].Length <= 3)
        {
            count++;
        }      
    }

    string[] resArray = new string[count];
    int j = 0;

    for (int i = 0; i < arrayRes.Length; i++)
    {
        if (arrayRes[i].Length <= 3)
        {
           resArray[j] = arrayRes[i];
           j++;
        }    
    }

    return resArray;
}

void ShowArray(string[] array)
{
    Console.Write("Готовый массив: ");

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}


Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] arrayStr = GetStringArrayFromUser(sizeArray);
string[] resArray = GetLessThreeCharsArray(arrayStr);
ShowArray(resArray);
