using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void FindNotMonotonus(int number)//Передача самой первой позиции "1" в векторе
        {
            int[] vector = new int[8];
            vector[number] = 1;
            int[] zeros;
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

        }
        static void Main(string[] args)
        {
            for (int i = 6; i >=0; i--)
            {

            }
        }
    }
}
