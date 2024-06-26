﻿//задача №1. вычислить факториал от натурального числа namespace Name
// N! = 1*2*...*N
// 3! = 1*2*3 = 6
// 5! = 1*2*3*4*5 = 120
// 10! =3 628 800
// 1! = 1
// 0! = 1

//(N-1)! - рекурсивный вызов 
//N! = N* (N-1)*...*1 - N! = N* (N-1)! упрощение задачи
//3! = 3 * 2!
// 2! = 2 *1!
// 1! = 1 - остановка рекурсии

// Вычислить факториал от натурального
// числа N
int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop reqursion: n = {n}");
        return 1;
    }
    
    Console.WriteLine(n);
    return n * Fact(n - 1);
}

Console.Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (До след. точки)