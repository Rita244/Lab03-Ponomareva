// Console.WriteLine("Hello, World!");

Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;
Console.WriteLine($"После пополения на 500: {balance}");

balance -= 200;
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05;
Console.WriteLine($"После начисления на 5%: {balance}");

balance /= 2;
Console.WriteLine($"После деления пополам: {balance}");