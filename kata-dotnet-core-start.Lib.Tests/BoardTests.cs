
namespace kata_dotnet_core_start.Lib.Tests;

public class BoardTests
{
    [Fact]
    public void Given_Board_HasNineCells()
    {
        var board = new Board();
        board.Cells.Should().HaveCount(9);
    }
}

public record Board
{
    public Board()
    {
        Cells = Enumerable.Range(1, 9)
            .Select(c => new Cell())
            .ToArray();
    }

    public bool TryTakeCell(int cellIndex, Player player)
    {
        throw new NotImplementedException();
    }

    public bool HasPlayerWon(Player player)
    {
        /*
        [0][1][2]
        [3][4][5]
        [6][7][8]
        */

        // Horizontals
        if (Cells[0].Owner == player && Cells[1].Owner == player && Cells[2].Owner == player) return true;
        if (Cells[3].Owner == player && Cells[4].Owner == player && Cells[5].Owner == player) return true;
        if (Cells[6].Owner == player && Cells[7].Owner == player && Cells[8].Owner == player) return true;
        
        // Verticals
        if (Cells[0].Owner == player && Cells[3].Owner == player && Cells[6].Owner == player) return true;
        if (Cells[1].Owner == player && Cells[4].Owner == player && Cells[7].Owner == player) return true;
        if (Cells[2].Owner == player && Cells[5].Owner == player && Cells[8].Owner == player) return true;
        
        // Diagonals
        if (Cells[0].Owner == player && Cells[4].Owner == player && Cells[8].Owner == player) return true;
        if (Cells[2].Owner == player && Cells[4].Owner == player && Cells[6].Owner == player) return true;

        return false;
    }

    public Cell[] Cells { get; set; }
}