// Задача 2. Взять 3 числа и вывести максимальное

Console.WriteLine("Введите первое число");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
double number3 = Convert.ToDouble(Console.ReadLine());
double max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;
Console.Write("Наибольшее число: " + max);


