//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.

string[] arrayFirst = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst = ResultArray(arrayFirst, countFirst);


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine("Массив строк, длина которых равна или менее 3-х символов:");
            Console.Write($"[{array[i]}].");
        }
    }
    Console.WriteLine();
}

int CountStringLessThreeChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] ResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

PrintArray(resultFirst);
