/*Запросить у пользователя некоторое количество цифр на вход (от 3 до 7)
все цифры сложить в массив по порядку
обработать возможные ошибки через try - catch 
по окончанию ввода от пользователя вывести на экран среднее арифметическое значение всех введённых чисел
*/
using System.Linq.Expressions;

namespace Lesson_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 цифр:");
            int[] massiv = new int[7];

            massiv[0] = Convert.ToInt32(Console.ReadLine());
            massiv[1] = Convert.ToInt32(Console.ReadLine());
            massiv[2] = Convert.ToInt32(Console.ReadLine());
            massiv[3] = Convert.ToInt32(Console.ReadLine());
            massiv[4] = Convert.ToInt32(Console.ReadLine());
            massiv[5] = Convert.ToInt32(Console.ReadLine());
            massiv[6] = Convert.ToInt32(Console.ReadLine());

            double saz = (massiv[0] + massiv[1] + massiv[2] + massiv[3] + massiv[4] + massiv[5] + massiv[6]) / 7;

            Console.Write("Среднее значение равно: ");
            Console.Write(saz);
        }
    }
}