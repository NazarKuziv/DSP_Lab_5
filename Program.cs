using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_5
{
    internal class Program
    {

        static String[] Decart(String[] A, String[] B, String[] C)
        {
            String[] D = new String[A.Length * B.Length * C.Length];
            int j = 0;
            for (int iB = 0; iB < B.Length; iB++)
            {
                for (int iC = 0; iC < C.Length; iC++)
                {
                    for (int iA = 0; iA < A.Length; iA++)
                    {
                        D[j] = " " + B[iB] + " " + C[iC] + " " + A[iA];
                        j++;
                    }

                }
            }
            return D;
        }
        static int[] makeBit(int[] A, int[] U)
        {
            int[] Bit = new int[U.Length];

            for (int i = 0; i < Bit.Length; i++)
                Bit[i] = 0;

            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < U.Length; j++)
                    if (U[j] == A[i])
                    {
                        Bit[j] = 1;
                        break;
                    }

            return Bit;
        }

        static int[] LogicNot(int[] A)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1)
                    D[i] = 0;
                else
                    D[i] = 1;

            return D;
        }
        static int[] And(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 && B[i] == 1)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }
        static int[] Or(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 || B[i] == 1)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }

        static int[] Difference(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == 1 && B[i] == 0)
                    D[i] = 1;
                else
                    D[i] = 0;

            return D;
        }
        static int[] XOR(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
                if (A[i] == B[i])
                    D[i] = 0;
                else
                    D[i] = 1;

            return D;
        }
        static void Main(string[] args)
        {
            // Завдання 1
            String[] A = { "a", "b", "c" };
            String[] B = { "x", "y", "z" };
            String[] C = { "0", "1" };
            String[] D = Decart(A, B, C);

            Console.WriteLine("1) ВxСxА: ");
            Array.ForEach(D, Console.WriteLine);
            Console.WriteLine();
            // Завдання 2

            int[] U = { 1, 2, 3, 4, 5, 6 };
            int[] A1 = { 1, 4, 6 };
            int[] B1 = { 2, 3 };

            int[] bA = makeBit(A1, U);
            int[] bB = makeBit(B1, U);
            Console.WriteLine("2)");
            Console.WriteLine(" U:    " + string.Join(" ", U));
            Console.WriteLine(" A:    " + string.Join(" ", bA));
            Console.WriteLine(" B:    " + string.Join(" ", bB));
            Console.WriteLine("Not A: " + string.Join(" ", LogicNot(bA)));
            Console.WriteLine("A && B:" + string.Join(" ", And(bA, bB)));
            Console.WriteLine("A || B:" + string.Join(" ", Or(bA, bB)));
            Console.WriteLine("A / B: " + string.Join(" ", Difference(bA, bB)));
            Console.WriteLine("AxorB: " + string.Join(" ", XOR(bA, bB)));



            Console.ReadKey();

        }
    } 
}
