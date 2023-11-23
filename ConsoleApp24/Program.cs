using System;

internal class Program
{
    static void Main(string[] args)
    {
        meow:
        Console.WriteLine("Введите размерность матрицы:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] m = new int[n, n];

        if (n > 100)
        {
            Console.WriteLine("Матрица должна быть <= 100! Введите новвое значение..") ;
            goto meow;
        }
       
        
        matrixinput:
        Console.WriteLine("Введите элементы матрицы:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = Convert.ToInt32(Console.ReadLine());

                if (n>100)
                {
                    Console.WriteLine("Ваша матрица имеет недопустимые значения, введите элемент <= 100!");
                    goto matrixinput;
                }
            }
        }

        if (IsMatrixSymmetric(m, n))
        {
            Console.WriteLine("YYEEESSS");
        }
        else
        {
            Console.WriteLine("NO!!");
        }
    }

    private static bool IsMatrixSymmetric(int[,] m, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (m[i, j] != m[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}