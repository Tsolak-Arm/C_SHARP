﻿// Задача №1 • Вычислить факториал от натурального числа N.

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n-1);
}

//Fact(5);
Console.Write(Fact(5));
// Домашнее задание: Добавить в код отладочный вывод,
// который позволит увидеть «раскручивание» рекурсии,
// то есть процесс возвратов
// к местам рекурсивного вызова функции на строке 11.

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (до следущей точки)