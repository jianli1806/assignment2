namespace UniversityManagementSystem;

public class Department : IDepartmentService
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime BudgetStart { get; set; }
    public DateTime BudgetEnd { get; set; }
    private List<Course> courses = new List<Course>();

    public Instructor GetHead() => Head;
    public List<Course> GetCourses() => courses;
    public decimal GetBudget() => Budget;

    public void AddCourse(Course course) => courses.Add(course);
}
