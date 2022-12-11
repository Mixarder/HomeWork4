/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


void ToDegree(int a, int b)
{

    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }

        Console.WriteLine($"Число {a} в натуральной степени {b} будет {result}");
    
}
Console.Write("Ведите число А: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Ведите число B: ");
int numB = int.Parse(Console.ReadLine());

ToDegree(numA, numB);
