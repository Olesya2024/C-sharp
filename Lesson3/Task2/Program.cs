﻿void PrintSquares(int limit)//эта функция принимает один параметр limit, 
//который определяет верхнюю границу чисел, квадраты которых нужно напечатать.
{
    int i = 1;//создается переменная i типа int и инициализируется значением 1
    while (i <= limit)//цикл while, который продолжается до тех пор, пока i не превысит limit
    {
        Console.Write($"{i*i} ");//Вычисляется квадрат текущего значения i путем умножения i на i.
     // Результат выводится в консоль с помощью Console.Write.
        i++;//К i прибавляется 1, чтобы перейти к следующему числу
    }
}

PrintSquares(5);//вызывает функцию PrintSquares с limit равным 5, 
//что приводит к выводу квадратов чисел от 1 до 5 включительно
PrintSquares(10);
PrintSquares(15);