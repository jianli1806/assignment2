namespace UniversityManagementSystem;


public abstract class Person : IPersonService
{
    private string name;
    private DateTime dateOfBirth;
    private List<Address> addresses = new List<Address>();
    private decimal salary;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public DateTime DateOfBirth
    {
        get => dateOfBirth;
        set => dateOfBirth = value;
    }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    public void AddAddress(Address address) => addresses.Add(address);

    public virtual List<string> GetAddresses()
    {
        var result = new List<string>();
        foreach (var addr in addresses)
            result.Add(addr.ToString());
        return result;
    }

    public virtual int CalculateAge()
    {
        var today = DateTime.Today;
        var age = today.Year - dateOfBirth.Year;
        if (dateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    // Virtual for polymorphism
    public virtual decimal CalculateSalary() => Salary;
}
