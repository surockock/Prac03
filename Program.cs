int number = 1_000_000;
byte[] bytes = BitConverter.GetBytes(number);

Console.WriteLine($"Число: {number}");
Console.Write("Байты: ");
foreach (byte b in bytes) {
    Console.Write($"{b:X2} ");
}