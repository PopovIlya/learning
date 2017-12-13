using System;

public class rTriangle
{
    public double Main(double sideA, double sideB, double sideC)
    {
        double s;

        try
        {
            // расчёт площади прямоугольного треугольника

            if ((sideA > 0) & (sideB > 0) & (sideC > 0))  //проверка существования сторон
            {
                if ((sideA < sideB + sideC) & (sideB < sideA + sideC) & (sideC < sideA + sideB))
                {       //проверка существования треугольника
                    if (sideA == Math.Sqrt(sideB * sideB + sideC * sideC))
                    {       //проверка: является ли треугольник прямоугольным, а сторона а гипотенузой?
                        try
                        {
                            s = (sideB * sideC) / 2;        //вычисление площади прямоугольного треугольника
                            return (s);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message); //если площадь треугольника слишком велика
                            return (0);
                        }
                    }
                    else if (sideB == Math.Sqrt(sideA * sideA + sideC * sideC))
                    {      //проверка: является ли треугольник прямоугольным, а сторона b гипотенузой?
                        try
                        {
                            s = (sideA * sideC) / 2;        //вычисление площади прямоугольного треугольника                      
                            return (s);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message); //если площадь треугольника слишком велика
                            return (0);
                        }
                    }
                    else if (sideC == Math.Sqrt(sideA * sideA + sideB * sideB))
                    {       //проверка: является ли треугольник прямоугольным, а сторона c гипотенузой?
                        try
                        {
                            s = (sideA * sideB) / 2;        //вычисление площади прямоугольного треугольника                       
                            return (s);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message); //если площадь треугольника слишком велика
                            return (0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введены данные не прямоугольного треугольника");
                    }
                }
                else
                {
                    Console.WriteLine("Треугольник с такими параметрами не существует, попробуйте ввести длины сторон ещё раз");
                }
            }
            else
            {
                Console.WriteLine("Введены неверные значения сторон");
            }
            return (0);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return (0);
        }
    }
}
