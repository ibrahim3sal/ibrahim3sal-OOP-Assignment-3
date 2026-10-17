using Generics;

Store<Student> studentStore = new();

studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mohamed" });
studentStore.Add(new Student { Id = 3, Name = "Ali" });
studentStore.Add(new Student { Id = 4, Name = "Omar" });
studentStore.Add(new Student { Id = 5, Name = "Mahmoud" });

Store<Course> courseStore = new();

courseStore.Add(new Course { Id = 1, Title = "C#", Price = 1500m });
courseStore.Add(new Course { Id = 2, Title = ".NET", Price = 2000m });
courseStore.Add(new Course { Id = 3, Title = "SQL", Price = 1000m });

Student? student = studentStore.GetById(1);
Course? course = courseStore.GetById(2);

Console.WriteLine(student?.Name ?? "Not found");
Console.WriteLine(course?.Title ?? "Not found");

try
{
    studentStore.Add(new Student { Id = 1, Name = "New Student" });
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Page 2:");

foreach (Student item in studentStore.GetAll().Values.Page(2, 2))
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

List<Course> courses = new()
{
    new Course { Id = 1, Title = "C#", Price = 1500m },
    new Course { Id = 2, Title = ".NET", Price = 2000m },
    new Course { Id = 3, Title = "SQL", Price = 1000m }
};

Course? foundCourse = courses.FindById(2);

Console.WriteLine(foundCourse?.Title ?? "Not found");

// Store<string> stringStore = new();
