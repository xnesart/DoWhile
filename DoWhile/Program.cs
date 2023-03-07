//Задание 1) Пользователь вводит пароль до тех пор, пока введенное значение не будет равно "Pass123!"
Console.WriteLine("Задание 1");
Console.WriteLine("Введите пароль");
string pass = Console.ReadLine();
string truePass = "Pass123!";
do
{
    if (pass == truePass)
    {
        Console.WriteLine("пароль верный");
    }
    else
    {
        Console.WriteLine("пароль неверный");
        Console.WriteLine("Введите пароль");
        pass = Console.ReadLine();
    }
} while (pass != truePass);
//Задание 2) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0
//(больше 0 не встречается в последовательности). Найти самое большое число последовательности.
Console.WriteLine("Задание 2");
int max = 0;
int value;
do
{
    Console.WriteLine("Введите число");
    value = int.Parse(Console.ReadLine());
    if (value > max)
    {
        max = value;
    }

} while (value != 0);
Console.WriteLine($"самое большое число последовательности {max}");
//Задание 3) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0
//(больше 0 не встречается в последовательности).
//Найти количество чисел в последовательности, которые делятся на 3, 7 или 11.
Console.WriteLine("Задание 3");
int element;
int counter = 0;
do
{
    Console.WriteLine("Введите число");
    element = int.Parse(Console.ReadLine());
    if (element % 3 == 0 || element % 7 == 0 || element % 11 == 0)
    {
        counter++;
    }

} while (element != 0);
Console.WriteLine($"количество чисел в последовательности, которые делятся на 3, 7 или 11 = {counter}");
//4) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 
//    (больше 0 не встречается в последовательности).
//    Определить модуль суммы каких чисел больше, положительных или отрицательных.
Console.WriteLine("Задание 4");
Console.WriteLine("Введите количество чисел в последовательности");
int sumOfNegativeNumbers = 0;
int sumOfPositiveNumbers = 0;
int quantityValue;
do
{
    Console.WriteLine("Введите число");
    quantityValue = int.Parse(Console.ReadLine());
    if (quantityValue > 0)
    {
        sumOfPositiveNumbers += quantityValue;
    }
    else if (quantityValue < 0)
    {
        sumOfNegativeNumbers += (quantityValue * -1);
    }

} while (quantityValue != 0);
if (sumOfNegativeNumbers < sumOfPositiveNumbers)
{
    Console.WriteLine($"сумма положительных чисел больше, она равна {sumOfPositiveNumbers}");
}
else if (sumOfNegativeNumbers > sumOfPositiveNumbers)
{
    Console.WriteLine($"сумма отрицательных чисел больше, она равна {sumOfNegativeNumbers}");
}
else
{
    Console.WriteLine($"сумма положительных и отрицательных чисел равны, {sumOfPositiveNumbers} = {sumOfNegativeNumbers}");
}