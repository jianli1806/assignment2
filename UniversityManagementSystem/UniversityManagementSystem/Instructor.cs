namespace UniversityManagementSystem;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; set; }
    public bool IsHeadOfDepartment { get; set; }
    public DateTime JoinDate { get; set; }
    public decimal BonusPerYear { get; set; } = 1000m;

    public int GetYearsOfExperience()
    {
        var today = DateTime.Today;
        int years = today.Year - JoinDate.Year;
        if (JoinDate.Date > today.AddYears(-years)) years--;
        return years;
    }

    public decimal CalculateBonus()
    {
        return GetYearsOfExperience() * BonusPerYear;
    }

    public override decimal CalculateSalary()
    {
        return base.CalculateSalary() + CalculateBonus();
    }
}
