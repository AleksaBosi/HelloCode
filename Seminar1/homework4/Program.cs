Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i += 2) if (number == i) Console.Write(i);
    else Console.Write($"{i}, ");
