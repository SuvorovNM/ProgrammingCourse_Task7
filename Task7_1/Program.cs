using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        static bool FindNotMonotonus(int number, string chislo)//Передача самой первой позиции "1" в векторе
        {
            int[] zeros=new int[1];
            switch (number)
            {
                case 6:
                    zeros = new int[1];
                    zeros[0] = 7;
                    break;
                case 5:
                    zeros = new int[1];
                    zeros[0] = 7;
                    break;
                case 4:
                    zeros = new int[3];
                    zeros[0] = 5;
                    zeros[1] = 6;
                    zeros[2] = 7;
                    break;
                case 3:
                    zeros = new int[1];
                    zeros[0] = 7;
                    break;
                case 2:
                    zeros = new int[3];
                    zeros[0] = 3;
                    zeros[1] = 6;
                    zeros[2] = 7;
                    break;
                case 1:
                    zeros = new int[3];
                    zeros[0] = 3;
                    zeros[1] = 5;
                    zeros[2] = 7;
                    break;
                case 0:
                    zeros = new int[7];
                    for (int i = 0; i < 7; i++)
                    {
                        zeros[i] = i + 1;
                    }
                    break;
            }
            bool OK = false;
            foreach (int k in zeros)
            {
                OK = chislo[k] == '0'||OK;
            }
            return OK;

        }
        static void Main(string[] args)
        {
            string vector;
            for (int i = 2; i < 256; i++)
            {
                vector = Convert.ToString(i, 2);
                int temp = 8 - vector.Length;
                for (int j = 0;j< temp; j++)
                {
                    vector = "0" + vector;
                }
                int FirstOne = vector.IndexOf('1');
                if (FirstOne != -1)
                {
                    if (FindNotMonotonus(FirstOne, vector))
                    {
                        Console.WriteLine(vector);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
