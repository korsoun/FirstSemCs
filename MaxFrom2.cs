// Прием двух чисел и вывод большего
// допустим, тип Double подходит

Console.WriteLine("Введите первое число");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double number2 = Convert.ToDouble(Console.ReadLine());
if(number1 > number2) Console.Write("Большее число: " + number1);
if(number2 > number1) Console.Write("Большее число: " + number2);
if(number1 == number2) Console.Write("Эти числа равны");


Console.WriteLine("проба");