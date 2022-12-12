/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. */

int Extent (int nA, int nB) {
  int result = 1;
  for(int i = 1; i <= nB; i++){
    result = result * nA;
  }
    return result;
}
  Console.Write("Введите число A: ");
  int nA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int nB = Convert.ToInt32(Console.ReadLine());

  int extent = Extent(nA, nB);
  Console.WriteLine("Ответ: " + extent);


/* Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
  int Summa(int number) {   
    int count = Convert.ToString(number).Length;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < count; i++) {
      sum = number - number % 10;
      result = result + (number - sum);
      number = number / 10;
    }
   return result;
  }
int numberSumma = Summa(number);
Console.WriteLine("Сумма цифр: " + numberSumma);


/* Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран. */

// Не выполнено, не поняла задание :(