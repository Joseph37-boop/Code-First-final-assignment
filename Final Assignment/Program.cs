using System.Data.Entity;


public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Grade { get; set; }
}



public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }

}



class Program
{
    static void Main()
    {
        using (var context = new StudentContext())
        {
            //context.Database.EnsureCreated();

            var newStudent = new Student
            {
                Name = "Joseph",
                Grade = 95.5
            };

            context.Students.Add(newStudent);
            context.SaveChanges();

            Console.WriteLine("Student added to the database.");
        }
    }
}

