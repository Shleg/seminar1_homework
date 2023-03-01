// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int num;
string exit = "";
string userAnswer;

while (exit != "n")
{
    Console.Write("Введите целое число: ");
    userAnswer = Console.ReadLine();

    if (int.TryParse(userAnswer, out num)) //проверка на целое число вводимых данных
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Число " + num + " делиться на 2 нацело");
        }
        else
        {
            Console.WriteLine("Число " + num + " не делиться на 2 нацело");
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода, необходимо ввести целое число!");
    }
    Console.Write("Продолжить? (y/n): ");
    exit = Console.ReadLine();
}