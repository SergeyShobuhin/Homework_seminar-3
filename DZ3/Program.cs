// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// функция вычисления
int[] GetSquaresNumer(int numer)
{
    int[] squaresNumers = new int[numer]; // создаём пустой массив

    // Заполнение массива результата
    for (int i = 1; i <= numer; i++)
    {
        squaresNumers[i - 1] = i * i * i; 
    }

    return squaresNumers;
}

// //Вводим число
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

// счетаем числа от 1 до N, запускаем фунцию для каждого числа массива и помещаем в массив результатов чисел в кубе.
int[] result = GetSquaresNumer(num);
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}

//////