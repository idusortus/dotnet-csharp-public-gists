using FluentAssertions;
using Katas.Lib;

namespace Katas.Tests;

// Create a simple String calculator with a method int Add(string numbers). 
// The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0). 
// For example "" or "1" or "1,2"
// Start with the simplest test case of an empty string and move to 1 and two numbers
// Remember to solve things as simply as possible so that you force yourself to write tests you did
// not think about
// Remember to refactor after each passing test
public class UnitTest1
{
    [Theory]
    // [InlineData("//[***]\n1***2***3", 6)]    
    // [InlineData("//[***][eat]\n1***2***3eat9", 15)]    

    [InlineData("1,2,3", 6)]
    // [InlineData("1,2", 3)]
    // [InlineData("1,", 1)]
    // [InlineData("1\n2,3", 6)]
    // [InlineData("", 0)]
    // [InlineData("1,\n",1)]
    // [InlineData("//;\n1;2",3)]
    // [InlineData("//!\n3!3!3",9)]    
    public void GetNumbersFromString_AndSum(string input, int expectedSum)
    {
        // Arrange
        var sc = new StringCalculator();
        // Act
        var result = sc.Add(input);
        // Assert
        result.Should().Be(expectedSum);
    }

    [Theory]
    [InlineData("-1","-1")]
    [InlineData("1,-1","-1")]
    [InlineData("5,-1,3,-9","-1,-9")]
    public void RejectNegatives(string input, string negativeNumbers )
    {
        // arrange
        var sut = new StringCalculator();
        // act
        Action act = () => sut.Add(input);
        //assert
        act.Should().Throw<InvalidOperationException>()
            .WithMessage("negatives not allowed: " + negativeNumbers);
    }

    [Theory]
    [InlineData("5,1000,1001",1005)]
    [InlineData("2,1001",2)]
    public void IgnoreOver1k(string input, int expectedSum)
    {
        //arrange
        var sut = new StringCalculator();
        //act
        // Action act = () => sut.Add(input);
        var result = sut.Add(input);
        //assert
        result.Should().Be(expectedSum);
    }
}
