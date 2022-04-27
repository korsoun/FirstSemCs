// Прием двух чисел и вывод большего
// допустим, тип Double подходит

//Console.WriteLine("Введите первое число");
//double number1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//double number2 = Convert.ToDouble(Console.ReadLine());
//if(number1 > number2) Console.Write("Большее число: " + number1);
//if(number2 > number1) Console.Write("Большее число: " + number2);
//if(number1 == number2) Console.Write("Эти числа равны");

// взять 3 числа и вывести максимальное

// снова Double


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