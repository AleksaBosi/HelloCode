Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void getMaxNumber()
{
    Console.Write("Введите число: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    number = number < temp ? temp : number;
}

getMaxNumber();
getMaxNumber();

Console.WriteLine($"Наибольшее число = {number}");