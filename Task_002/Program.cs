// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

double numA;
double numB;
double max;
string exit = "";
string userAnswer1;
string userAnswer2;

while (exit != "n")
{
    Console.Write("Введите первое число: ");
    userAnswer1 = Console.ReadLine();
    Console.Write("Введите второе число: ");
    userAnswer2 = Console.ReadLine();
    if (double.TryParse(userAnswer1, out numA) && double.TryParse(userAnswer2, out numB))
    {
        if (numA > numB)
        {
            max = numA;
        }
        else
        {
            max = numB;
        }
        Console.WriteLine("a = " + numA + "; b = " + numB + " -> max = " + max);
    }
    else
    {
        Console.WriteLine("Ошибка ввода, данные не являются числами!");
    }
    Console.Write("Продолжить? (y/n): ");
    exit = Console.ReadLine();
}


