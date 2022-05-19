/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

int InputN(int border)
{
    int N = 0;
    do
    {
        Console.Write($"Введите число больше {border}: ");
        N = Convert.ToInt32(Console.ReadLine());
        if (N <= border)
        {
            Console.Write("Ошибка!");
            Console.ReadKey();
            Console.Clear();
        }

        else
        {
            return N;
        }
    } while (true);
}

int IntRevers(int number)
{
    int RevNumber = 0;
    int temp = number;
    while (temp != 0)
    {
        RevNumber = RevNumber * 10;
        RevNumber = RevNumber + temp % 10;
        temp = temp / 10;
    }
    return RevNumber;
}

Console.Clear();
int number = InputN(9);

if (number == IntRevers(number))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


