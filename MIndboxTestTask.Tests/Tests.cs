namespace MIndboxTestTask.Tests;

public class Tests
{
	[SetUp]
	public void Setup()
	{
	}
	
	[TestCase(2, 12.57)]
	[TestCase(5, 78.54)]
	[TestCase(10, 314.16)]
	public void TestCircle(double radius, double answer)
	{
		Assert.AreEqual(Math.Round(MeasureArea.MeasureCircle(radius), 2), answer);
	}

	[TestCase(new double[]{4, 2, 5}, 3.8, false)]
	[TestCase(new double[]{6, 3, 4}, 5.33, false)]
	[TestCase(new double[]{5, 3, 4}, 6, true)]
	[TestCase(new double[]{10, 6, 8}, 24 , true)]
	public void MeasureTriangle(double[] sides, double answer, bool rightTriangleAnswer)
	{
		var result = MeasureArea.MeasureTriangle(sides, out var rightTriangle);
		Assert.AreEqual(Math.Round(result, 2), answer);
		Assert.AreEqual(rightTriangle, rightTriangleAnswer);
	}

	[TestCase(new double[]{1, 2})]
	[TestCase(new double[]{1, 2, 3, 4})]
	public void MeasureWrongTriangle(double[] sides)
	{
		TestDelegate testDelegate = () => MeasureArea.MeasureTriangle(sides, out var _);
		Assert.Throws<ArgumentException>(testDelegate);
	}
	
}