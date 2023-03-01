// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int num;

string exit = "";
string userAnswer;

while (exit != "n")
{
    Console.Write("Введите целое число больше 1: ");
    userAnswer = Console.ReadLine();
    int count = 1;

    if (int.TryParse(userAnswer, out num) && num > 1) //проверка на целое число больше 1  
    {
        Console.Write(num + " -> ");

        while (count <= num)
        {
            if (count % 2 == 0)
            {
                Console.Write(count + ", ");
            }
            count++;
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Ошибка ввода, необходимо ввести целое число больше 1!");
    }
    Console.Write("Продолжить? (y/n): ");
    exit = Console.ReadLine();
}