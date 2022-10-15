Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Введите номер порядковый номер задачи ");
Console.ForegroundColor = ConsoleColor.White;
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA_64();
else if (Task == 2) ZADACHA_66();
else if (Task == 3) ZADACHA_68();
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Такой задачи нет в списке!!!");
    Console.ResetColor();
}
void ZADACHA_64()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Задача 64: \nЗадайте значение N.\nНапишите программу, которая выведет все натуральные числа в промежутке от N до 1.\nВыполнить с помощью рекурсии.");
    Console.ResetColor();
    System.Console.WriteLine();


    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void ListOfNumbers(int N)
    {
        if (N > 0)
        {
            Console.Write($"{N} ");
            ListOfNumbers(N - 1);
        }
        else if (N < 0)
        {

            ListOfNumbers(N + 1);
        }

    }




    int N = ReadData("Введите число N: ");
    ListOfNumbers(N);

    Console.WriteLine();


}

void ZADACHA_66()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nЗадача 66: \nЗадайте значения M и N. \nНапишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.ResetColor();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void SumFromMToN(int M, int N, int sum = 0)
    {
        if (M > N) (M, N) = (N, M);
        sum += N;
        if (N <= M)
        {
            Console.Write($"{sum} ");
            return;
        }
        SumFromMToN(M, N - 1, sum);

    }


    int M = ReadData("Введите число  M: ");
    int N = ReadData("Введите число N: ");

    System.Console.Write($"Сумма всех чисел от {M} до {N} = ");
    SumFromMToN(M, N);
}


void ZADACHA_68()
{
    Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"\nЗадача 68: \nНапишите программу вычисления функции Аккермана с помощью рекурсии. \nДаны два неотрицательных числа m и n.");
Console.ResetColor();
    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }
    int FunctionAkkerman(int m, int n)
    {
        if (m == 0 && n > 0)return n + 1;
        else if (m > 0 && n == 0)return FunctionAkkerman(m - 1, 1);
        else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
        
        
    }

    int m = ReadData("Введите неотрицательное число m: ");
    int n = ReadData("Введите неотрицательное число n: ");
    int result=FunctionAkkerman(m, n);
    Console.WriteLine($"Результат функции Аккермана А({m},{n})={result}");

}
