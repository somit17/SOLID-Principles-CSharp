public interface IEmployee
{
    int Id { get; set; }
    string Name { get; set; }
    decimal CalculateBonus(decimal salary);
}

public class PermenantEmployee : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PermenantEmployee(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
    public decimal CalculateBonus(decimal salary)
    {
        return salary * 10;
    }
}

public class TemporaryEmployee : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TemporaryEmployee(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
    public decimal CalculateBonus(decimal salary)
    {
        return salary * 15;
    }
}