// Программа ввода числа N и вывода таблицы кубов от 1 до N 
Console.WriteLine("Введите натуральное число, а я выведу список кубов чисел от 1 до этого числа: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Кубы чисел от 1 до {N}");
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
else
{
    System.Console.WriteLine("Введено некорректное число");
}