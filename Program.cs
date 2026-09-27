// int number = 1_000_000;
// byte[] bytes = BitConverter.GetBytes(number);

// Console.WriteLine($"Число: {number}");
// Console.Write("Байты: ");
// foreach (byte b in bytes) {
//     Console.Write($"{b:X2} ");
// }

int max = int.MaxValue;
Console.WriteLine($"int.MaxValue = {max}");

int overflowed = max + 1;
Console.WriteLine($"int.MaxValue + 1 = {overflowed}");

int min = int.MinValue;
Console.WriteLine($"int.MinValue = {min}");

int underflowed = min - 1;
Console.WriteLine($"int.MinValue - 1 = {underflowed}");


Console.Write("max:        ");
foreach (byte b in BitConverter.GetBytes(max)) {
    Console.Write($"{b:X2} ");
}
Console.WriteLine();
Console.Write("overflowed: ");
foreach (byte b in BitConverter.GetBytes(overflowed)) {
    Console.Write($"{b:X2} ");
}
Console.WriteLine();