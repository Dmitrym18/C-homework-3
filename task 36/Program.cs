// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int min = Workwithuser("Введите минимальное число массива: ");
int max = Workwithuser("Введите максимальное число массива: ");
int[] numbers = new int[2];
FillArrayrandomnum(numbers);


int Workwithuser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayrandomnum(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
        Console.Write(array[i] + " ");
    }
}

int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result = result + numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечётных позиций = {result}");

