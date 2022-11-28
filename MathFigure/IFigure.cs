using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
	/// <summary>
	/// Интерфейс для геометрической фигуры.
	/// </summary>
	public interface IFigure
	{
		/// <summary>
		/// Получить площадь.
		/// </summary>
		/// <returns>Площадь.</returns>
		float GetSquare();
	}
}
