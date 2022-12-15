
namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Given_PlayerOneIsCreated_PlayerSymbolShouldBeX()
    {
        var playerOne = Player.CreatePlayerOne();
        playerOne.Symbol.Should().Be(Symbol.X);
    }
    
    [Fact]
    public void Given_PlayerTwoIsCreated_PlayerSymbolShouldBeO()
    {
        var playerOne = Player.CreatePlayerTwo();
        playerOne.Symbol.Should().Be(Symbol.O);
    }
}