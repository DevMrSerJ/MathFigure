using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
	/// <summary>
	/// Геометрическая фигура - треугольник.
	/// </summary>
	public class Triangle : IFigure
	{
		/// <summary>
		/// Первая сторона.
		/// </summary>
		public float FirstSide { get; private set; }

		/// <summary>
		/// Вторая сторона.
		/// </summary>
		public float SecondSide { get; private set; }

		/// <summary>
		/// Третья сторона.
		/// </summary>
		public float ThirdSide { get; private set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="firstSide">Первая сторона.</param>
		/// <param name="secondSide">Вторая сторона.</param>
		/// <param name="thirdSide">Третья сторона.</param>
		public Triangle(float firstSide, float secondSide, float thirdSide)
		{
			if (firstSide <= 0f)
			{
				throw new ArgumentException($"Сторона {nameof(firstSide)} оказалась отрицательной");
			}

			if (secondSide <= 0f)
			{
				throw new ArgumentException($"Сторона {nameof(secondSide)} оказалась отрицательной");
			}

			if (thirdSide <= 0f)
			{
				throw new ArgumentException($"Сторона {nameof(thirdSide)} оказалась отрицательной");
			}

			if (firstSide + secondSide < thirdSide ||
				firstSide + thirdSide < secondSide ||
				secondSide + thirdSide < firstSide)
			{
				throw new ArgumentException("Такой треугольник не существует");
			}

			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		/// <summary>
		/// Получить площадь.
		/// </summary>
		/// <returns>Площадь.</returns>
		public float GetSquare()
		{
			var listSide = new List<float>()
			{
				FirstSide,
				SecondSide,
				ThirdSide
			};

			var hypotenuse = listSide.Max();

			var isRectaungle = listSide
				.Where(x => x != hypotenuse)
				.Sum(x => Math.Pow(x, 2)) == Math.Pow(hypotenuse, 2);

			var square = 1f;

			if (isRectaungle)
			{
				foreach (var item in listSide)
				{
					if (item != hypotenuse)
					{
						square *= item;
					}
				}

				square /= 2;
			}
			else
			{
				var perimetr = listSide.Sum() / 2;
				square = (float)Math.Sqrt(perimetr * (perimetr - listSide[0]) * (perimetr - listSide[1]) * (perimetr - listSide[2]));
			}

			return square;
		}
	}
}
