// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет


Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());
if (a * a == b || b * b == a) {
    Console.WriteLine("да");
}else {
    Console.WriteLine("нет");
}
