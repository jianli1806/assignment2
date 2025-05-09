namespace UniversityManagementSystem;


using System;
using System.Collections.Generic;

// Person-related service interface
public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
}

// Student service inherits person service
public interface IStudentService : IPersonService
{
    double CalculateGPA();
    void EnrollInCourse(Course course, char grade);
}

// Instructor service inherits person service
public interface IInstructorService : IPersonService
{
    int GetYearsOfExperience();
    decimal CalculateBonus();
}

// Course service
public interface ICourseService
{
    void EnrollStudent(Student student, char grade);
    List<Student> GetEnrolledStudents();
}

// Department service
public interface IDepartmentService
{
    Instructor GetHead();
    List<Course> GetCourses();
    decimal GetBudget();
}
