// Программа из имеющегося массива строк создает новый массив из строк, длина которых меньше или равна 3 символа



Console.WriteLine("Введите элементы массива через запятую и нажмите Enter ");

string? temp = Console.ReadLine();


if (temp != null)
{

    string[] arrayLocal = temp.Split(",");

    Console.WriteLine($"Полученный массив: [{String.Join("; ", arrayLocal)}]");

}

else Console.WriteLine("Некорректный ввод ");