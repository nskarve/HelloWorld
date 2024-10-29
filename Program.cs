// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World N!");
Decimal num1 = 6;
Decimal num2 = 4;
Decimal num3 = num1 * num2;
Console.WriteLine($" {num1} * {num2}  equals to {num3}!");
Console.WriteLine($" {num1} + {num2}  equals to {num3}!");

var names = new List <string> {"Ge", "ge"};
foreach (var name in names) {
    Console.WriteLine($"The namaew are {name.ToLower()}");
}
