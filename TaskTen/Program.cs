using System;
using System.IO;

namespace MiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISumCalculator sumCalculator = new SumCalculator();
            double number1 = 0;
            double number2 = 0;

            try
            {
                Console.WriteLine("Введите первое число:");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                number2 = Convert.ToDouble(Console.ReadLine());

                double result = sumCalculator.Sum(number1, number2);
                Console.WriteLine($"Сумма равна: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введенное значение не является числом");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное значение слишком велико или слишком мало");
            }
            finally
            {
                Console.WriteLine("Вычисление завершено");
            }
        }
    }

    public interface ISumCalculator
    {
        double Sum(double num1, double num2);
    }

    public class SumCalculator : ISumCalculator
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}