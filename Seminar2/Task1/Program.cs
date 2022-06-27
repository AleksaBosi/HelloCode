int n1, n2, n;
n = new Random().Next(9, 100);
Console.WriteLine(n);
n1 = n / 10;
n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);

