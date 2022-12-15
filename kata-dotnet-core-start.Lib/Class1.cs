namespace kata_dotnet_core_start.Lib;

public sealed record Player
{
    public Symbol Symbol { get; init; }
}

public enum Symbol
{
    X = 'X',
    O = 'O'
}