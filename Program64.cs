// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = FindNumbers("Введите n: ");
int count = 2;
FindNumber(n, count);
Console.Write(1);

void FindNumber(int n, int count)
{
  if (count > n) return;
  FindNumber(n, count + 1);
  Console.Write(count + ", ");
}

int FindNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}