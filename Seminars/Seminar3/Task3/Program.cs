﻿// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]
// (элемент 7 не имеет пары)

// Задаем исходный массив

int[] arr = new int[7] {1, 3, 2, 4, 2, 3, 7};

// определяем размер массива

int size = arr.Length / 2;

//Создаем новый массив

int[] result = new int[size];

//Через цикл заполняем новый массив произведением пар чисел

for (int i = 0; i < result.Length; i++)
{
    result[i] = arr[i] * arr [arr.Length -1 -i]; // левый элемент умножаем на правый
    //arr[i] левый элемент - arr[i] * arr [arr.Length -1 -i] правый элемент
}

// выводим результирующий массив в терминал

for (int i =0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}