//  Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


        // Console.Clear();   
        // // Пример массива целых чисел
        // int[] arr = new int[10];
        // int count = 0;
        
        //         for (int i = 0; i < arr.Length;i++)
        // {
        //     arr[i] = new Random().Next(1,101); // Случайные целые числа от 1 до 100.
        // }
        // // Выводим результат всего массива в диапозоне [1,100]
        // Console.WriteLine($"Massive from 10D: [{string.Join(", ", arr)}]");
        // // Перебираем все элементы массива, объявляем element целого числа содержащий текущий элемент массива.
        // foreach (int element in arr)
        // {
        //     // Проверяем, находится ли элемент в диапазоне [20, 90]
        //     if (element >= 20 && element <= 90)
        //     {
        //         count++;
        //     }
        // }

        // // Выводим результат кол-во элементов
        // Console.WriteLine($"Massive element in range [20, 90]: {count}");
    

/* Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
которая определяет количество чётных чисел в массиве.
*/
// Задаем массив из 10 целых чисел.


        // Создаем массив из 10 целых чисел
//         int[] arr = new int[10];
//         int count = 0;

//         // Заполняем массив случайными числами от 1 до 100
//         Random random = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = random.Next(1, 101);
//         }
// Console.WriteLine ($"Massive: [{string.Join(", ", arr)}]");
//         // Перебираем все элементы массива
//         foreach (int number in arr)
//         {
//             // Проверяем, является ли число четным
//             bool even = (number % 2 == 0);
            
//             // Првоеряем если число четное, увеличиваем счетчик  
//             if (even)
//             {
//                 count++;
//             }
//         }

       
        
//         Console.WriteLine($"Even Numbers in Massive: {count}");

/*
Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
 Найдите разницу между максимальным и минимальным элементов массива.



  // Создаем массив из вещественных чисел
        double[] arr = new double[10];
      int count = 0;
      // Заполняем массив случайными вещественными числами из 10 ячеек (елементов)
        Random random = new Random(10);
        for (int i = 0; i < arr.Length; i++)
        {
             arr[i] = Math.Round(random.NextDouble() * 100, 2); // округляем элементы массива до 2х дробных иначе из там больше 10.
            
            
        }

        // Инициализируем переменные для минимального и максимального элементов
        double min = arr[0];
        double max = arr[0];
        
        // Находим минимальный и максимальный элементы
        foreach (double element in arr)
        {
            if (element < min)
            {
                min = element;
            }

            if (element > max)
            {
                max = element;
            }
            count++;
        }

        // округляем мин и макс числа до двух дробных частями.
        min = Math.Round(min, 2);
        max = Math.Round(max, 2);
        // Находим разницу между максимальным и минимальным элементами
        double div = max - min;
        

        // результат
        Console.WriteLine($"Massive: [{string.Join(", ", arr)}]");
        Console.WriteLine($"Min Element: {min}");
        Console.WriteLine($"Max Element: {max}");
        Console.WriteLine($"Div Max - Min: {div}");

        */




