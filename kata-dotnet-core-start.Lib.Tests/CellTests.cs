
namespace kata_dotnet_core_start.Lib.Tests;

public class CellTests
{
    [Fact]
    public void Given_NewCell_CellStateShouldBeEmpty()
    {
        var cell = new Cell();
        cell.IsEmpty.Should().BeTrue();
    }
    
    [Fact]
    public void Given_CellIsTakenByPlayer_CellIsNoLongerEmpty()
    {
        // Arrange
        var cell = new Cell();
        var player = Player.CreatePlayerOne();

        // Act
        cell.IsTakenBy(player);

        // Assert
        cell.IsEmpty.Should().BeFalse();
        cell.Owner.Should().Be(player);
    }
    
    [Fact]
    public void Given_CellIsTakenByPlayer_CellOwnerStaysThatPlayer()
    {
        // Arrange
        var cell = new Cell();
        var playerOne = Player.CreatePlayerOne();
        cell.IsTakenBy(playerOne);

        var playerTwo = Player.CreatePlayerTwo();

        // Act
        cell.IsTakenBy(playerTwo);
        
        // Assert
        cell.Owner.Should().Be(playerOne);
    }
}
