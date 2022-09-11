// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Определяем число
Console.Write("ВВедите пятизначное число: ");
string number = Console.ReadLine();

// функция сравнения чисел
void GetPolindromNumber(string number)
    {
        if (number.Length != 5) Console.WriteLine($"В числе {number} не пять цифр!");
        else if (number[0] == number[4] & number[1] == number[3]) Console.WriteLine($"Число {number} палиндромом!");
        else Console.WriteLine($"Число {number} не палиндромом!");
    }

GetPolindromNumber(number); // вызов функции

//////////////

