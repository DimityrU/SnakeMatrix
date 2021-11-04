using System;
using System.Linq;

class Exercise
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int n = random.Next(3, 10);
        int m = random.Next(3, 10);
        int i, j, t;
        string s;

        int[,] array = new int[n, m];

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                array[i, j] = random.Next(10);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int zero, one, two, Eplus, Oplus;
        for (zero = 0, one = 1, two = 2, Eplus = 0, Oplus = 1;
              zero <= 4;
              zero++, one++, two++, Eplus += 2, Oplus += 2)
        {
            if (zero != 0)
                Console.Write(" ");

            i = zero;
            for (j = zero; j < m - zero; j++)
            {
                System.Threading.Thread.Sleep(100);
                Console.Write(array[i, j] + " ");
            }

            if((zero==1 && n == 3 && m >= 3) || 
               (zero==2 && n == 5 && m >= 5) || 
               (zero==3 && n == 7 && m >= 7) || 
                zero == 4)
                break;

            j = m - one;
            s = String.Concat(Enumerable.Repeat("  ", m - Oplus));
            for (i = one; i <= n - one; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Eplus, Console.CursorTop + 1);
                Console.Write(s + array[i, j]);
            }

            if ((zero == 1 && m == 3 && n >= 4) || 
                (zero == 2 && m == 5 && n >= 6) || 
                (zero == 3 && m == 7 && n >= 8))
                break;

            i = n - one;
            t = (m - two) * 2;
            for (j = m - two; j >= 0; j--)
            {
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(t, Console.CursorTop);
                Console.Write(array[i, j] + " ");
                t -= 2;
            }

            if ((zero == 1 && n == 4 && m >= 4) ||
                (zero == 2 && n == 6 && m >= 6) || 
                (zero == 3 && n == 8 && m >= 8))
                break;

            j = zero;
            for (i = n - two; i > zero; i--)
            {
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(Eplus, Console.CursorTop - 1);
                Console.Write(array[i, j]);
            }

            if ((zero == 1 &&  m== 4 && n >= 5) || 
                (zero == 2 && m == 6 && n >= 7) || 
                (zero == 3 && m == 8 && n == 9))
                break;
        }
        Console.ReadKey();
    }
}