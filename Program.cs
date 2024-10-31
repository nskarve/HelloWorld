Console.WriteLine("Hello, World N!");
Decimal num1 = 6;
Decimal num2 = 4;
Decimal num3 = num1 * num2;
Console.WriteLine($" {num1} * {num2}  equals to {num3}!");
Console.WriteLine($" {num1} + {num2}  equals to {num3}!");

var names = new List <string> {"Nikolaos", "Giorgos"};
foreach (var name in names) {
    Console.WriteLine($"The names are {name.ToUpper()} \"--\" {name.ToLower()}");
}

names.Sort();

foreach (var name in names) {
    Console.WriteLine($"The names are {name.ToUpper()} \"++\" {name.ToLower()}");
}

// example last changes in Zografou Pitta Pappou