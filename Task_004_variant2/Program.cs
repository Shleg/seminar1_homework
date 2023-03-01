// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

double numA;
double numB;
double numC;
double max;
string exit = "";
string userAnswer1;
string userAnswer2;
string userAnswer3;

while (exit != "n")
{
    Console.Write("Введите первое число: ");
    userAnswer1 = Console.ReadLine();
    Console.Write("Введите второе число: ");
    userAnswer2 = Console.ReadLine();
    Console.Write("Введите третье число: ");
    userAnswer3 = Console.ReadLine();


    if (double.TryParse(userAnswer1, out numA) && double.TryParse(userAnswer2, out numB) 
    && double.TryParse(userAnswer3, out numC)) //проверка на число вводимых данных
    {
        double[] numArray = {numA, numB, numC};
        max = numArray.Max();
        Console.WriteLine("a = " + numA + "; b = " + numB + "; c = " + numC + " -> max = " + max);
    }
    else
    {
        Console.WriteLine("Ошибка ввода, не все данные являются числами!");
    }
    Console.Write("Продолжить? (y/n): ");
    exit = Console.ReadLine();
}