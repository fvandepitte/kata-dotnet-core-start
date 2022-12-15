namespace kata_dotnet_core_start.Lib;

public sealed record Player
{
    public Symbol Symbol { get; init; }

    public static Player CreatePlayerOne() => new() { Symbol = Symbol.X };

    public static Player CreatePlayerTwo() => new() { Symbol = Symbol.O };
}

public enum Symbol
{
    X = 'X',
    O = 'O'
}