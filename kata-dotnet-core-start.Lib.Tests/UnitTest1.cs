
namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Given_Player1_SymbolIsX()
    {
        Player player = new Player{Symbol = Symbol.X};

        player.Symbol.Should().Be(Symbol.X);
    }
}