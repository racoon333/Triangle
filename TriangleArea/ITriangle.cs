using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    public interface ITriangle
    {
        /// <summary>
        /// Первый катет прямоугольного треугольника
        /// </summary>
        double Cathetus1 { get; set; }
        /// <summary>
        /// Второй катет прямоугольного треугольника
        /// </summary>
        double Cathetus2 { get; set; }
        /// <summary>
        /// Гипотенуза прямоугольного треугольника
        /// </summary>
        double Hypotenuse { get; set; }
        /// <summary>
        /// Метод, вычисляющий площать прямоугольного треугольника по заданным длинам его сторон
        /// </summary>
        /// <returns>Возвращает площадь прямоугольного треугольника</returns>
        double GetTriangleArea();
    }
}
