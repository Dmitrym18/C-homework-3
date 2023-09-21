// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
  

int[] array = new int[4];

void FillArrayrandomnum (int[] array)
{
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next (100,1000);    
Console.Write(array[i] + " ");  
}
}

int Findeven(int[] array)
{
int Findeven = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0) 
Findeven = Findeven + 1;
}
return Findeven;
}

FillArrayrandomnum (array);
Console.Write($"\nКоличество чётных чисел в массиве: {Findeven(array)}");


