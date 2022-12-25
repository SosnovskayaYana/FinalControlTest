// Программа из имеющегося массива строк создает новый массив из строк, длина которых меньше или равна 3 символа


/// метод принимает на вход массив.
/// подсчитывает количество элементов, подходящих под параметр. Возвращает переменную
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


/// метод принимает на вход массив и переменную. 
/// заполняет новый массив элементами, подходящими под параметр. Возвращает новый массив
string[] CreateNewArray(string[] array, int coutnElements)
{
    string[] newArray = new string[coutnElements];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}



Console.WriteLine("Введите элементы массива через запятую и нажмите Enter ");

string? temp = Console.ReadLine();


if (temp != null)   // проверка введенных данных
{


    string[] arrayLocal = temp.Split(",");   // методом split делим строку "запятой" на элементы

    Console.WriteLine($"Полученный массив: [{String.Join("; ", arrayLocal)}]");   // выводим массив с элементами


    int countElemArray = CountElementsArray(arrayLocal);   // вызов метода

    string[] createNewArray = CreateNewArray(arrayLocal, countElemArray);   // вызов метода


    Console.WriteLine($"new массив: [{String.Join("; ", createNewArray)}]");   // вывод результата


}

else Console.WriteLine("Некорректный ввод ");