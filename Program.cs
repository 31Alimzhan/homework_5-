﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
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
Console.WriteLine("введите размер массива");                              // запрос размера массива
int size = Convert.ToInt32(Console.ReadLine());                           // присваивание значения с клавиатуры переменной size
int[] newarray = Generate_massiv(size);                                   // присваивание значений массива при помощи метода Generate_massiv
int kolich = Poisk_chet(size, newarray);                                  // присваивание количества четных при помощи метода Poisk_chet
Console.WriteLine ("Количество четных чисел равно - "+kolich);            // вывод на экран результата  
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] Generate_massiv(int size)

{
    int[] array = new int[size];
    for (int i = 0; i <size; i++)
    {
        array[i] = new Random().Next (0,100);
        Console.Write(array[i]+" ");
    }
return array;
}
int Summa(int[] array)
{
    int sum = 0;

return sum;
}
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = Generate_massiv(size);
int sum = Summa(array);
 


