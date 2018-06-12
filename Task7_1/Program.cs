using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        static bool FindNotMonotonus(int number, string chislo)//Передача количества "1" в векторе
        {
            //Пусть number - количество единиц без последней
            List<int> zero = new List<int>();//Массив позиций, на хотя бы одной из которых должен быть "0"
            string temp = chislo;
            int dif = 0;
            for (int i = 0; i < number; i++)
            {
                int index = temp.IndexOf('1');
                dif += temp.Length - temp.Substring(index + 1).Length;
                int pos = dif - 1;//Позиция следующей единицы
                temp = temp.Substring(index + 1);
                switch (pos)
                {
                    //Определение номеров позиций, на хотя бы одной из которых должен быть "0"
                    //В зависимости от первой единицы в числе
                    case 6:
                        //Если "1" на 6 позиции (для пользователя - 7), то только "0" на следующей за ней позиции обратит функцию в немонотонную
                        if (!zero.Contains(7))
                            zero.Add(7);
                        break;
                    case 5:
                        //Если "1" на 5 позиции, то "0" может быть только на 7 позиции
                        if (!zero.Contains(7))
                            zero.Add(7);
                        break;
                    case 4:
                        //Если "1" на 4 позиции, то "0" может быть только на 5 или 6 или 7 позиции
                        if (!zero.Contains(7))
                            zero.Add(7);
                        if (!zero.Contains(5))
                            zero.Add(5);
                        if (!zero.Contains(6))
                            zero.Add(6);
                        break;
                    case 3:
                        //Если "1" на 3 позиции, то "0" может быть только на 7 позиции
                        if (!zero.Contains(7))
                            zero.Add(7);
                        break;
                    case 2:
                        //Если "1" на 2 позиции, то "0" может быть только на 3 или 6 или 7 позиции
                        if (!zero.Contains(7))
                            zero.Add(7);
                        if (!zero.Contains(3))
                            zero.Add(3);
                        if (!zero.Contains(6))
                            zero.Add(6);
                        break;
                    case 1:
                        //Если "1" на 1 позиции, то "0" может быть только на 3 или 5 или 7 позиции
                        if (!zero.Contains(7))
                            zero.Add(7);
                        if (!zero.Contains(3))
                            zero.Add(3);
                        if (!zero.Contains(5))
                            zero.Add(5);
                        break;
                    case 0:
                        //Если "1" самая первая цифра в строке, значит "0" на любой позиции обратит функцию в не монотонную 
                        for (int j = 0; j < 7; j++)
                        {
                            if (!zero.Contains(j))
                                zero.Add(j);
                        }
                        break;
                }
            }
            bool OK = false;
            //Если хотя бы на одной из позиций из массива zeros стоит "0" значит функция не монотонна
            foreach (int k in zero)
            {
                OK = chislo[k] == '0' || OK;
            }
            return OK;

        }
        static void Main(string[] args)
        {
            int k = 0;
            string vector;
            for (int i = 0; i < 256; i++)
            {
                //Представление числа в двоичной системе
                vector = Convert.ToString(i, 2);
                //temp - количество незначащих нулей перед самим числом
                //Так как функции от 3 аргументов двоичное число должно быть 8-значным
                int temp = 8 - vector.Length;
                //Добавление нулей
                for (int j = 0; j < temp; j++)
                {
                    vector = "0" + vector;
                }
                //count - количество единиц в векторе
                int count = vector.ToCharArray().Where(p => p == '1').Count();
                {
                    //FindNotMonotonus(Количество_единиц, сам_вектор)
                    //Если функция не монотонна - вывод пользователю
                    if (FindNotMonotonus(count, vector))
                    {
                        Console.WriteLine(vector);
                        k++;
                    }
                }
            }
            Console.WriteLine("Было выведено " + k + " векторов!");
            Console.ReadLine();
        }
    }
}
