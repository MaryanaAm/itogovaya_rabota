//Объявление массива;
string[] array = new string[4] {"hello", "2", "world", ":-)"};
//Объявление нового массива для записи результатов проверки условия;
string[] newArray = new string[array.Length];

//Вывод массива в консоль для наглядного сравнения с результатом
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
//Создание цикла и проверка условия
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newArray[i] = array[i];
    }
}
 Console.WriteLine();

 Console.WriteLine("Результат: ");
//Вывод результата в консоль.
for (int i = 0; i < array.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
