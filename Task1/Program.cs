//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"//

int n = InputInt("Задайте число N: ");
int count = 2;
Console.WriteLine($"Натуральные числа от {n} до 1 равны: ");
Console.Write(NaturalNumber(n, count));
Console.Write(", 1");

int NaturalNumber(int n, int count)
{
    if (count >= n)
    {
       return n;
    } 
      else
    {
       Console.Write($"{NaturalNumber(n, count + 1)}, ");
    }

    return count;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
