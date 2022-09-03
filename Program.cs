﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
//-------------------------------------------методы---------------------------------------------------------------------------------------
int [] Generate_massiv(int size)                                          // метод генерация рандом массива
{
    int[] newarr = new int[size];                                         // объявляем массив с размером size
    for (int i = 0; i < size; i++)                                        // задаем цикл
    {
        newarr[i] = new Random().Next(100,1000);                          // непосредственно генерация значений элементов массива от 100 до 999
        Console.Write(newarr[i]+" ");                                     // для удобства вывод значений массива
    }
    Console.WriteLine();                                                  // выводим пукстую строку для удлбства и читабельности
    return newarr;                                                        // возврат массива
}
int Poisk_chet(int size, int [] newarray)                                 // метод подсчета количества четных, на входе size чтобы не искать длину массива array.Lenth
{
    int count = 0;                                                        // подсчетная переменная равна 0
    for (int i=0; i<size; i++)                                            // организовывается цикл по массиву от 0 до size
    {
        if (newarray[i] % 2 == 0) count +=1;                              // условие если i-й элемен т массива четный то 
    }
return count;                                                             // к возврату количество четных в переменной count
}
//-------------------------------------------основная программа---------------------------------------------------------------------------

Console.WriteLine("введите размер массива");                              // запрос размера массива
int size = Convert.ToInt32(Console.ReadLine());                           // присваивание значения с клавиатуры переменной size
int[] newarray = Generate_massiv(size);                                   // присваивание значений массива при помощи метода Generate_massiv
int kolich = Poisk_chet(size, newarray);                                  // присваивание количества четных при помощи метода Poisk_chet
Console.WriteLine ("Количество четных чисел равно - "+kolich);            // вывод на экран результата  
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
//-------------------------------------------методы---------------------------------------------------------------------------------------
int [] Generate_massiv(int size)                                          // генерация массива
{
    int[] array = new int[size];                                          // объявляем массив с размером size 
    for (int i = 0; i <size; i++)                                         // запучкаем цикл 
    {
        array[i] = new Random().Next (0,100);                             // генерим число и присваиваем его элементу массива
        Console.Write(array[i]+" ");                                      // для удобства печатаем его на экран
    }
Console.WriteLine();
return array;
}
int Summa(int[] array)                                                    // подсчет значений на нечетных элементах


{
    int sum = 0;                                                          // объявляем переменную
    for (int i = 0; i<array.Length; i++)                                  // проходим по массиву   
    {
        if (i % 2 == 1)                                                   // если элемент нечетный 
        sum += array[i];                                                  // то присваиваем его значение и складываем его со значением переменной
    }
return sum;                                                               // возвращаем переменную
}
//-------------------------------------------основная программа---------------------------------------------------------------------------

Console.WriteLine("Введите размер массива ");                             // начало программы  с предложением ввести размер массива
int size = Convert.ToInt32(Console.ReadLine());                           // "захват" значения с клавиатуры конвертация и присвоение переменной size
int[] array = Generate_massiv(size);                                      // объявление массива и вызов метода Generate_massiv
int sum = Summa(array);                                                   // объявление переменной и вызов метода   
Console.WriteLine();                                                      // прорисовка пустой строки для удобства
Console.WriteLine($"Сумма элементов на нечетных позициях - {sum}");       // вывод на экран результата
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//-------------------------------------------методы---------------------------------------------------------------------------------------
int [] Generate_massiv(int size)                                          // генерация массива
{
    int[] array = new int[size];                                          // объявляем массив с размером size 
    Console.Write("Array - ");
    for (int i = 0; i <size; i++)                                         // запучкаем цикл 
    {
        array[i] = new Random().Next (0,100);                             // генерим число и присваиваем его элементу массива
        Console.Write(array[i]+" ");                                      // для удобства печатаем его на экран
    }
Console.WriteLine();
return array;
}
int Search(int[] array)                                                   // метод поиска мин и макс значение и вычисление результата
{
    int min = array[0];                                                   // объявление переменных для удобства сразу присваиваем значение нулевого элемента массива
    int max = array[0];
    int rezult = 0;
    for(int i = 0; i < array.Length; i++)                                   // поиск MIN посредством цикла
    {
        if (array[i] < min) min = array[i];                               // если элемент меньше min то присваиваем его min

    }
Console.WriteLine("Минимальное значение - " + min);                                  // пишем min на экран
    for(int j =0; j < array.Length; j++)                                    // поиск MAX 
    {
        if (array[j] > max) max = array[j];                               // если элемент  юбольше max то присваиваем его max
    }
Console.WriteLine("Максимальное значение - " + max);                                 // пишем max на экран
rezult = max - min;                                                       // вычисляенм результат
return rezult;                                                            // возвращаем его
}
//-------------------------------------------основная программа---------------------------------------------------------------------------

Console.WriteLine("Введите размер массива ");                             // предлагаем ввести массив
int size = Convert.ToInt32(Console.ReadLine());                           // присваиваем переменной size через конверсию
int[] array = Generate_massiv(size);                                      // вызов метода и присваиваем его масиву 
int raznost = Search(array);                                              // вызов метода и присваивание результата
Console.WriteLine($"Разность значений между min и max равно - {raznost}"); // вывод на экран




