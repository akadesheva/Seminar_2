// 11 Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа:

int num = new Random().Next(100, 1000);
int result = (num/100)*10 + num%10;
//Console.WriteLine($"{num} -> {result}"); alternative way to solve this issue
Console.WriteLine($"{num} -> {num/100}{num%10}");