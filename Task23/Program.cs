/* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void CubeN(int N)
{
    if (N < 1)
    {
        Console.WriteLine("Число N меньше 1. Ошибка!");
        return;
    }
    for (int i = 1; i<=N; i++)
    {
        Console.Write($"{i*i*i}");
        if (i<N)
        {
           Console.Write(", ");
        }
    }
}

int Number = -1;
string s = "";
do
{
    Console.Clear();
    Console.WriteLine("Для выхода нажмите 'q'.");
    Console.WriteLine("Введите число N больше 1:");
    s = Console.ReadLine();

    if (s == "q")
    {
        break;
    }

    Number = Convert.ToInt32(s);

    CubeN(Number);
    Console.ReadKey();

} while (true);