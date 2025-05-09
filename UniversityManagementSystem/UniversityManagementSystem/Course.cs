namespace UniversityManagementSystem;

public class Course : ICourseService
{
    public string CourseName { get; set; }
    private Dictionary<Student, char> enrolledStudents = new Dictionary<Student, char>();

    public void EnrollStudent(Student student, char grade)
    {
        enrolledStudents[student] = grade;
    }

    public List<Student> GetEnrolledStudents()
    {
        return new List<Student>(enrolledStudents.Keys);
    }
}
