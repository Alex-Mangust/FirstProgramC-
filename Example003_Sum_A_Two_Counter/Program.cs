/* Console.Write("Введите первое число: ");
Console.Read();
int count_first = Console.Read();
Console.Write("Введите второе число: ");
Console.Read();
int count_second = Console.Read();
int sum = count_first + count_second;
Console.Write("Сумма чисел равна ");
Console.WriteLine(sum); */

int count_first = new Random().Next(1, 10);
int count_second = new Random().Next(1, 10);
Console.WriteLine(count_first);
Console.WriteLine(count_second);
int sum = count_first + count_second;
Console.Write("Сумма чисел равна ");
Console.WriteLine(sum);