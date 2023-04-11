//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int ns, nf, summ;
summ = 0;
Console.WriteLine("Введи начало промежутка");
ns = int.Parse(Console.ReadLine());
Console.WriteLine("Введи конец промежутка");
nf = int.Parse(Console.ReadLine());
for (int i = ns; i < nf + 1; i++)
{
    summ = summ + i;
}
Console.WriteLine(summ);
