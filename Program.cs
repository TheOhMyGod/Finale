string[] array1 = {"на", "двойка", "три", "это", "четыре"};
string[] array2 = new string[array1.Length];
int g = 0;

for (int i = 0; i < array2.Length; i++)
{
    for (int j = g; j < array1.Length; j++)
    {
        if (array1[j].Length <= 3)
        {
            array2[i] = array1[j];
            break;
        }
        break;
    }
    g++;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != null)
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array2);
