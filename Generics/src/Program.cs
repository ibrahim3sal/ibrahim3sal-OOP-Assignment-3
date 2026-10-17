using Generics;

Store<Student> studentStore = new();
Store<Course> courseStore = new();

studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mohamed" });

courseStore.Add(new Course { Id = 1, Title = "C#", Price = 1500m });
courseStore.Add(new Course { Id = 2, Title = ".NET", Price = 2000m });

Student? student = studentStore.GetById(1);
Course? course = courseStore.GetById(2);

Console.WriteLine(student?.Name ?? "Not found");
Console.WriteLine(course?.Title ?? "Not found");
