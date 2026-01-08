using Xunit;

public class CalculatorTest
{

    [Fact]
    public void TestAdd()
    {
        //given
        Calculator calc = new();

        int a = 5;
        int b = 2;
        int expetedResult = 7;

        //when
        int result = calc.Add(a, b);

        //then
        Assert.Equal(expetedResult, result);
    }

}