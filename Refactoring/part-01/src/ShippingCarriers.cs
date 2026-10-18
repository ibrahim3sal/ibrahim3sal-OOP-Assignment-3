namespace RefactoringLab;

public interface IShippingCarrier
{
    decimal CalculateCost(decimal weightKg);
}

public class AramexCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedExCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 15m;
    }
}

public class DhlCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 18m;
    }
}
public class UpsCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 20m;
    }
}
