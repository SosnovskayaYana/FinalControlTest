// Программа из имеющегося массива строк создает новый массив из строк, длина которых меньше или равна 3 символа


int CountElementsArray(string[] array2D)
{
    int count = 0;

    for (int i = 0; i < array2D.Length; i++)
    {
        if (array2D[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}



Console.WriteLine("Введите элементы массива через запятую и нажмите Enter ");

string? temp = Console.ReadLine();


if (temp != null)
{

    string[] arrayLocal = temp.Split(",");

    Console.WriteLine($"Полученный массив: [{String.Join("; ", arrayLocal)}]");

    int countElemArray = CountElementsArray(arrayLocal);

}

else Console.WriteLine("Некорректный ввод ");