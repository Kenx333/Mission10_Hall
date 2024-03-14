namespace Mission10API.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<object> GetBowlersWithTeams();
    }
}
