using System;

namespace WagesCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation obj = new Calculation();
            obj.CalculateWage(new double[] { 9, 17, 30, 1.5 });  //"$240.00"
            obj.CalculateWage(new double[] { 16, 17, 30, 1.8 }); //"$84.00"
            obj.CalculateWage(new double[] { 12, 20, 30, 1.5 });	//"$52.50"
        }
    }
        public class Calculation
        {
        public double wage = 0;
        public  void CalculateWage(double[] data)
            {
                double[] array1 = new double[4];
                //exact regular hours
                if (data[0] <= 9 && data[1] <= 17)
                {
                    wage = (double)(8 * 30);
                    Console.WriteLine($"$ {wage}");
                }
                //additional hours
                if (data[1] > 17)
                {
                    if (data[0] < 9 && data[1] > 17)
                    {
                        double value = data[1] - 17;
                        double value1 = value * 30; Console.WriteLine(value1);
                        double value2 = value1 * data[3];
                        double value3 = 17 - data[0];
                        double value4 = value3 * 30;
                        wage = value2 + value4;
                        Console.WriteLine($"$ {wage}");

                    }
                    if (data[0] > 9 && data[1] > 17)
                    {
                        double value = data[1] - 17;
                        double value1 = value * 30;
                        double value2 = value1 * data[3];
                        double value3 = 17 - data[0];
                        double value4 = value3 * 30;
                        wage = value2 + value4;
                        Console.WriteLine($"$ {wage}");

                    }
                }
                else if ((data[0] >= 9 && data[1] < 17) || (data[0] > 9 && data[1] >= 17))
                {
                    double result = data[1] - data[0];
                    wage = result * 30;
                    Console.WriteLine($"$ {wage}");
                }
                else
                {

                }
            }

        }
    }

