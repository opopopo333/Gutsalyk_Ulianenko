using System;

/// <summary>
/// Демонстрационный класс, иллюстрирующий работу с массивами символов и чисел.
/// </summary>
class ArrayExample
{
    /// <summary>
    /// Точка входа в программу. 
    /// Инициализирует массивы, формирует строку имени и выводит сообщения в цикле.
    /// </summary>
    static void Main()
    {
        // Исходный массив символов для формирования имени
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];

        for (int i = 0; i < letters.Length; i++)
        {
            // Постепенное накопление символов в строку
            name += letters[i];

            // Заполнение массива целыми числами от 1 до 10
            a[i] = i + 1;

            // Вызов вспомогательного метода для вывода данных
            SendMessage(name, a[i]);
        }

        Console.ReadKey();
    }

    /// <summary>
    /// Выводит персонализированное приветствие и текущее числовое значение в консоль.
    /// </summary>
    /// <param name="name">Имя или часть имени для отображения.</param>
    /// <param name="msg">Целочисленное значение счетчика.</param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}