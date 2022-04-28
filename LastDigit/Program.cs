// Дополнительная задача. Принять трехзначное число и вывести его последнюю цифру

Console.WriteLine("Введите трехзначное число");
int ThreeDigit = Convert.ToInt32(Console.ReadLine());
int TwoDigit, goal;

if(ThreeDigit < 0) {
    TwoDigit = -ThreeDigit % 100;
    goal = TwoDigit % 10;
    ThreeDigit = -ThreeDigit;
}
else {
    TwoDigit = ThreeDigit % 100;
    goal = TwoDigit % 10;
}

if(ThreeDigit / 100 < 10 & ThreeDigit / 100 > 0) {                                                                           // алгоритм ведь сработает,
    Console.WriteLine("Последняя цифра этого числа: " + goal);                                                               // даже если число не будет
}                                                                                                                            // трехзначным
else {                                                                                                                       // это лишняя сложность,
    Console.WriteLine("Вводить было нужно трехзначное число. Впрочем, последняя цифра этого числа все равно " + goal);       // но, пока проект учебный и простой,
}                                                                                                                            // хотелось бы учесть и это решение

