
using Generics;

StudentStore store = new StudentStore();

store.Add(new Student { Id = 1, Name = "Ahmed" });
store.Add(new Student { Id = 2, Name = "Mohamed" });

Student? student = store.GetById(1);

Console.WriteLine(student?.Name ?? "Not found");

foreach (Student item in store.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

store.Remove(1);

Console.WriteLine(store.GetById(1)?.Name ?? "Not found");
