namespace UniversityManagementSystem;

public class Student : Person, IStudentService
{
    private Dictionary<Course, char> courseGrades = new Dictionary<Course, char>();

    public void EnrollInCourse(Course course, char grade)
    {
        courseGrades[course] = grade;
        course.EnrollStudent(this, grade);
    }

    public double CalculateGPA()
    {
        if (courseGrades.Count == 0) return 0.0;
        double totalPoints = 0;
        int count = 0;
        foreach (var g in courseGrades.Values)
        {
            totalPoints += GradeToPoint(g);
            count++;
        }
        return totalPoints / count;
    }

    private double GradeToPoint(char grade)
    {
        switch (grade)
        {
            case 'A': return 4.0;
            case 'B': return 3.0;
            case 'C': return 2.0;
            case 'D': return 1.0;
            case 'F': return 0.0;
            default: return 0.0;
        }
    }
}
