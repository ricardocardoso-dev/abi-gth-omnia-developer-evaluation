namespace Ambev.DeveloperEvaluation.Domain.ValueObjects;

public class Rating
{
    public decimal Rate { get; private set; }
    public int Count { get; private set; }

    public Rating(decimal rate, int count)
    {
        Rate = rate;
        Count = count;
    }

    // Optional: Factory method for initial rating
    public static Rating CreateInitial(decimal rate) => new Rating(rate, 1);

    public Rating AddRating(decimal newRate)
    {
        if (newRate < 0 || newRate > 5)
            throw new ArgumentOutOfRangeException(nameof(newRate), "Rating must be between 0 and 5.");

        var total = (Rate * Count) + newRate;
        var newCount = Count + 1;
        var newRateAvg = total / newCount;

        return new Rating(newRateAvg, newCount);
    }

    // Value equality overrides (important!)
    public override bool Equals(object? obj)
    {
        if (obj is not Rating other) return false;
        return Rate == other.Rate && Count == other.Count;
    }

    public override int GetHashCode() => HashCode.Combine(Rate, Count);
}
