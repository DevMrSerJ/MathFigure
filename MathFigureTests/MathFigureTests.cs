using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure.Tests
{
	/// <summary>
	/// Тесты для библиотеки вычисления площадь фигур.
	/// </summary>
	[TestClass()]
	public class MathFigureTests
	{
		/// <summary>
		/// Создать круг с нулевым радиусом.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateCircleZeroRadius()
		{
			var circle = new Circle(0);
		}

		/// <summary>
		/// Создать круг с отрицательным радиусом.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateCircleNegativeRadius()
		{
			var circle = new Circle(-153.589f);
		}

		/// <summary>
		/// Создать круг с правильным радиусом.
		/// </summary>
		[TestMethod()]
		public void CreateCircle()
		{
			var radius = 15f;
			var circle = new Circle(radius);

			Assert.AreEqual(circle.Radius, radius);
		}

		/// <summary>
		/// Создать треугольник с нулевыми сторонами.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateTriangleZeroSide()
		{
			var triangle = new Triangle(0, 0, 0);
		}

		/// <summary>
		/// Создать треугольник с одной отрицательной стороной.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateTriangleNegativeSide()
		{
			var triangle = new Triangle(15, 3, -18);
		}

		/// <summary>
		/// Создать несуществующий треугольник.
		/// </summary>
		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void CreateNotExistsTriangle()
		{
			var triangle = new Triangle(2, 3, 7);
		}

		/// <summary>
		/// Создать треугольник с правильными сторонами.
		/// </summary>
		[TestMethod()]
		public void CreateTriangle()
		{
			var firstSide = 15f;
			var secondSide = 12f;
			var thirdSide = 9f;

			var triangle = new Triangle(firstSide, secondSide, thirdSide);

			Assert.IsTrue(triangle.FirstSide == firstSide && triangle.SecondSide == secondSide && triangle.ThirdSide == thirdSide);
		}

		/// <summary>
		/// Вычислить площадь треугольника.
		/// </summary>
		[TestMethod()]
		public void CalculateSquareTriangule()
		{
			var firstSide = 3f;
			var secondSide = 4f;
			var thirdSide = 5f;

			var triangle = new Triangle(firstSide, secondSide, thirdSide);

			var square = CalculateSquare.GetSquare(triangle);
			var calcSquare = firstSide * secondSide / 2;

			Assert.AreEqual(square, calcSquare);
		}

		/// <summary>
		/// Вычислить площадь круга.
		/// </summary>
		[TestMethod()]
		public void CalculateSquareCircle()
		{
			var radius = 4.5f;

			var circle = new Circle(radius);

			var square = CalculateSquare.GetSquare(circle);
			var calcSquare = (float)(Math.PI * Math.Pow(radius, 2));

			Assert.AreEqual(square, calcSquare);
		}
	}
}