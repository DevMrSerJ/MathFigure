using System;
using System.Collections.Generic;
using System.Linq;

namespace MathFigure
{
	/// <summary>
	/// Класс для вычисления площадей геометрических фигур.
	/// </summary>
	public static class CalculateSquare
	{
		/// <summary>
		/// Получить площадь фигуры.
		/// </summary>
		/// <param name="figure">Объект фигуры.</param>
		/// <returns>Площадь фигуры.</returns>
		public static float GetSquare(IFigure figure)
		{
			if (figure == null)
			{
				throw new ArgumentNullException("Фигура оказалась null.");
			}

			return figure.GetSquare();
		}
	}
}