using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    /// <summary>
    /// Класс Triangle позволяет вычислить площать прямоугольного треугольника
    /// </summary>
    public class Triangle : ITriangle
    {
        /// <summary>
        /// Первый катет прямоугольного треугольника
        /// </summary>
        public double Cathetus1 { get; set; }
        /// <summary>
        /// Второй катет прямоугольного треугольника
        /// </summary>
        public double Cathetus2 { get; set; }
        /// <summary>
        /// Гипотенуза прямоугольного треугольника
        /// </summary>
        public double Hypotenuse { get; set; }
        /// <summary>
        /// Пустой конструктор без значений сторон
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Конструктор с установкой значений сторон треугольника
        /// </summary>
        /// <param name="a">Длина стороны треугольника</param>
        /// <param name="b">Длина стороны треугольника</param>
        /// <param name="c">Длина стороны треугольника</param>
        public Triangle(double a, double b, double c)
        {
            var sides = new double[] { a, b, c };
            sides.OrderBy(r => r);
            this.Cathetus1 = sides[0];
            this.Cathetus2 = sides[1];
            this.Hypotenuse = sides[2];
        }
        /// <summary>
        /// Конструктор с установкой значений сторон треугольника
        /// </summary>
        /// <param name="sides">Массив сторон прямоугольного треугольника</param>
        public Triangle(double[] sides)
        {
            if (sides.Length != 3)
                throw new Exception("Неверное количество сторон треугольника!");
            sides.OrderBy(r => r);
            this.Cathetus1 = sides[0];
            this.Cathetus2 = sides[1];
            this.Hypotenuse = sides[2];
        }

        /// <summary>
        /// Метод, вычисляющий площать прямоугольного треугольника по заданным длинам его сторон
        /// </summary>
        /// <returns>Возвращает площадь прямоугольного треугольника</returns>
        public double GetTriangleArea()
        {
            if (Math.Pow(this.Hypotenuse, 2) == Math.Pow(this.Cathetus1, 2) + Math.Pow(this.Cathetus2, 2))
            {
                double area = (this.Cathetus1 * this.Cathetus2) / 2;
                return area;
            }
            throw new Exception("Треугольник не является прямоугольным!");
        }
        /// <summary>
        /// Метод, вычисляющий площать прямоугольного треугольника по заданным длинам его сторон
        /// </summary>
        /// <param name="a">Длина стороны треугольника</param>
        /// <param name="b">Длина стороны треугольника</param>
        /// <param name="c">Длина стороны треугольника</param>
        /// <returns>Возвращает площадь прямоугольного треугольника</returns>
        public static double GetTriangleArea(double a, double b, double c)
        {
            return GetTriangleArea(new double[] { a, b, c });
        }
        /// <summary>
        /// Метод, вычисляющий площадь прямоугольного треугольника по заданному массиву длин его сторон
        /// </summary>
        /// <param name="sides">Массив длин сторон прямоугольного треугольника</param>
        /// <returns>Возвращает площадь прямоугольного треугольника</returns>
        public static double GetTriangleArea(double[] sides)
        {
            if (sides.Length != 3)
                throw new Exception("Неверное количество сторон треугольника!");
            sides.OrderBy(r => r);
            if (Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))
            {
                double area = (sides[0] * sides[1]) / 2;
                return area;
            }
            throw new Exception("Треугольник не является прямоугольным!");
        }
    }
}
