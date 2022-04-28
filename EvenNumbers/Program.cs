// Задача 3. Принять число и проверить, четное ли оно

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0) Console.Write("Число четное");
if(number % 2 != 0) Console.Write("Число нечетное");

