//Задача 4. Принять число N и вывести четные числа от 1 до N

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 2) {
    Console.WriteLine("При числе N = " + number + " нельзя вывести четные числа от 1 до N. Введите в следующий раз число побольше");
}
else{
    int count = 2;
    Console.Write("Четные числа в промежутке от 1 до " + number + ": ");
    while(count <= number) {
Console.Write(count + " ");
count = count + 2;
    }
}
