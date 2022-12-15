namespace kata_dotnet_core_start.Lib;

public sealed record Cell
{
    public bool IsEmpty => Owner is null;

    private Player? Owner { get; set; }

    public void IsTakenBy(Player player)
    {
        Owner = player;
    }
}
