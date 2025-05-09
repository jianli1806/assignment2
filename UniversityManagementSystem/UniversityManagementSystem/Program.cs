using System;


namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            var address1 = new Address { Street = "123 Main St", City = "Springfield", State = "IL", Zip = "62701" };
            var address2 = new Address { Street = "456 Oak Ave", City = "Springfield", State = "IL", Zip = "62702" };

            // Create instructor
            var instructor = new Instructor
            {
                Name = "Dr. Smith",
                DateOfBirth = new DateTime(1980, 5, 15),
                Salary = 80000m,
                JoinDate = new DateTime(2010, 8, 1)
            };
            instructor.AddAddress(address1);

            // Create department
            var department = new Department
            {
                Name = "Computer Science",
                Head = instructor,
                Budget = 500000m,
                BudgetStart = new DateTime(2025, 1, 1),
                BudgetEnd = new DateTime(2025, 12, 31)
            };
            instructor.Department = department;
            instructor.IsHeadOfDepartment = true;

            // Create courses
            var course1 = new Course { CourseName = "Algorithms" };
            var course2 = new Course { CourseName = "Databases" };
            department.AddCourse(course1);
            department.AddCourse(course2);

            // Create student
            var student = new Student
            {
                Name = "Alice Johnson",
                DateOfBirth = new DateTime(2003, 3, 20),
                Salary = 0m // Students usually don't have a salary
            };
            student.AddAddress(address2);

            // Student enrolls in courses and receives grades
            student.EnrollInCourse(course1, 'A');
            student.EnrollInCourse(course2, 'B');

            // Output information
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Age: {student.CalculateAge()}");
            Console.WriteLine("Addresses:");
            foreach (var addr in student.GetAddresses())
                Console.WriteLine($"  {addr}");
            Console.WriteLine($"GPA: {student.CalculateGPA():F2}");

            Console.WriteLine();

            Console.WriteLine($"Instructor: {instructor.Name}");
            Console.WriteLine($"Age: {instructor.CalculateAge()}");
            Console.WriteLine($"Years of Experience: {instructor.GetYearsOfExperience()}");
            Console.WriteLine($"Salary: {instructor.CalculateSalary():C}");
            Console.WriteLine("Addresses:");
            foreach (var addr in instructor.GetAddresses())
                Console.WriteLine($"  {addr}");

            Console.WriteLine();

            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Head: {department.Head.Name}");
            Console.WriteLine($"Budget: {department.GetBudget():C}");
            Console.WriteLine("Courses Offered:");
            foreach (var c in department.GetCourses())
                Console.WriteLine($"  {c.CourseName}");

            Console.WriteLine();

            Console.WriteLine($"Course '{course1.CourseName}' enrolled students:");
            foreach (var s in course1.GetEnrolledStudents())
                Console.WriteLine($"  {s.Name}");
        }
    }
}
