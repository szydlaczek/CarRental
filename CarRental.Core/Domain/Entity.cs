namespace CarRental.Core.Domain
{
    public interface Entity<TKey> where TKey : struct
    {
        TKey Id { get; }
    }
}