namespace Lozenge.Command.Domain.Tests;

using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // arrange
        var number1 = 2;
        var number2 = 4;

        // act
        var result = number1 + number2;

        // assert
        result.Should().Be(6);
    }

    [Fact]
    public  async Task Test2()
    {
        // arrange 
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        // act
        var result = await client.GetStringAsync("/");
        
        // assert
        result.Should().Be("Hello World!");
    }
}