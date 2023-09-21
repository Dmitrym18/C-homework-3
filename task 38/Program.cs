// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int min = Workwithuser("Введите минимальное число массива: ");
int max = Workwithuser("Введите максимальное число массива: ");
int[] numbers = new int[4];
Fillarrayrandomnum(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");

void Fillarrayrandomnum(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Workwithuser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}