/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
int summ = n;

recurSum(m, n - 1, summ);     

void recurSum(int m, int n, int summ)
{   
    summ = summ + n;
    if (n <= m)
    {
      Console.Write($"Сумма элементов = {summ} ");
      return;
    }
    recurSum(m, n - 1, summ);
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
