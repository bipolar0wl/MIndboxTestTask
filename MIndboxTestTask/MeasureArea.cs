namespace MIndboxTestTask;

public class MeasureArea
{
	public static double MeasureCircle(double radius) => Math.Pow(radius, 2) * Math.PI;

	public static double MeasureTriangle(double[] sides, out bool? rightTriangle)
	{
		rightTriangle = false;
		if (sides.Length != 3)
		{
			throw new ArgumentException("Must be 3 sides");
		}

		Array.Sort(sides);
		if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
		{
			rightTriangle = true;
		}

		var halfPerimeter = 0.5 * (sides[0] + sides[1] + sides[2]);
		return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) *
		                 (halfPerimeter - sides[2]));
	}
}