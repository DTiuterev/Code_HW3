// Проверка палиндромности вводимого пятизначного числа 
Console.WriteLine("Введите пятизначное число, а я проверю, является ли оно палиндромом: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
if (stringNumber.Length == 5)
    if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
        Console.WriteLine("Число является полиадромом");
    else
        Console.WriteLine("Число не является полиадромом");
else
    Console.WriteLine("Введено некорректное число");
