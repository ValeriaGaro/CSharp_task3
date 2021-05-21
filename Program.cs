using System;
using System.IO;
using System.Text;
using System.Linq;

namespace TestSpace
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 2, 55, 8, -999, 2, 7, 6, 1, 0, 5, 5, 0, 3, 5, 4, 8, 260, 703 };

            // 1.   Посчитать среднее арифметическое всех элементов массива array

            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum / array.Length / 2);

            // 2.   Найти сумму всех четных положительных элементов массива array

            int sum_elements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] % 2 == 0)
                {
                    sum_elements += array[i];
                }
            }
            Console.WriteLine(sum_elements);

            // 3.   Найти результат деления суммы положительных элементов на сумму отрицательных. Результат должен быть дробным числом (не целым).

            double sum_plus = 0;
            double sum_minus = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum_plus += array[i];
                }
                else
                    sum_minus += array[i];
            }
            Console.WriteLine(sum_plus / sum_minus);

            // 4.   Отсортировать элементы массива array по возрастанию 
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            { Console.Write(array[i] + " "); }
            Console.WriteLine("\n");
            // 5.   Преобразовать массив array в строку, состояющую из элементов массива, идущих в таком же порядке как и в массиве.
            //      Между элементами массива вставить разделитель (пробел или ,)
            string result = string.Join(" ", array);
            Console.WriteLine(result);

            // 6.   Зеркально отразить строку, полученную в #5

            string result_reverse = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result_reverse += result[i];
            }
            Console.WriteLine(result_reverse);

            // 7.   Удалить из полученной строки знаки минуса там, где они не имеют математического смысла (после числа и перед разделителем)

            result_reverse = result_reverse.Remove(result_reverse.IndexOf('-'));
            Console.WriteLine(result_reverse);

            // 8.   Преобразовать строку, полученную в #7 обратно в массив целочисленных значений и записать его в переменную array
           
            int[] array1 = result_reverse.Split(' ').Select(int.Parse).ToArray();
            
            Console.WriteLine(string.Join(" " , array1));
            // 9.   Создать массив byte[] и заполнить его такими же значениями как и массив array, если число слишком велико для типа byte - заменить его на значение по умолчанию для типа byte

            byte[] byte_array = new byte[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] >= 0 && array1[i] < 256)
                    byte_array[i] = Convert.ToByte(array1[i]);
                else
                    byte_array[i] = default;
                Console.Write($"{byte_array[i]} ");
            }
            Console.ReadKey();
        }
    }
}