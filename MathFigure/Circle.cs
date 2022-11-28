using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
	/// <summary>
	/// Геометрическая фигура - круг.
	/// </summary>
	public class Circle : IFigure
	{
		/// <summary>
		/// Радиус.
		/// </summary>
		public float Radius { get; private set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="radius">Радиус.</param>
		public Circle(float radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException("Радиус круга не может быть отрицательным.");
			}

			Radius = radius;
		}

		/// <summary>
		/// Получить площадь.
		/// </summary>
		/// <returns>Площадь.</returns>
		public float GetSquare()
		{
			return (float)(Math.PI * Math.Pow(Radius, 2));
		}
	}
}
