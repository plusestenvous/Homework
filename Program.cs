/* Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($"чисел: {numbers.Length}, четные: {count}");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(10,100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32((Console.ReadLine()));
int[] array = new int[size];
Random random = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = random.Next(10, 100);
    Console.Write("{0} {1}", array[i], "  ");
}
int Summa = 0;
for (int i = 0; i < array.Length; i++)
  if (array[i]%1 == 0)
    Summa += array[i];
  else
  break;
Console.Write("Сумма = : " + Summa);
Console.ReadKey();


/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. */

Console.Write("Задайте массив: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass  = new int[size];
Random random = new Random(); 
for( int i = 0; i < size; i++ ) {
  mass[i] = random.Next(-10, 100);
  Console.Write($" {mass[i]} ");
}
int min = 0;
int max = 0;
foreach ( int i in mass ) {
  if ( min > i ) min = i;
  if ( max < i ) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");