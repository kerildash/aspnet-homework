using Logic;

namespace Tests;

public class ArrayHandlerTests
{
    ArrayHandler ArrayHandler;

    public ArrayHandlerTests()
    {
        ArrayHandler = new ArrayHandler();
    }

    [Theory]
    [InlineData(new double[] { -3, 5, 8.1, 1, 7, -3 }, 3)]
    [InlineData(new double[] { 1, 2, 7, -8 }, -6)]
    public void OddIndexedElementsSum_ReturnsSum(double[] array, double expected)
    {
        var result = ArrayHandler.OddIndexedElementsSum(array);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(new double[] { 15 })]
    [InlineData(new double[] { })]

    public void OddIndexedElementsSum_ExceptionWnenNoOddElements(double[] array)
    {
        Assert.Throws<ArgumentException>(() => ArrayHandler.OddIndexedElementsSum(array));
    }

    [Fact]
    public void OddIndexedElementsSum_ExceptionWnenArrayIsNull()
    {
        double[] array = null;
        Assert.Throws<ArgumentNullException>(() => ArrayHandler.OddIndexedElementsSum(array));
    }
}
