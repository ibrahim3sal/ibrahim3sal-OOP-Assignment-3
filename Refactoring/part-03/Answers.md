# Part 03 — answers

---

## BlockedUsers

- Time complexity before: `O(n × m)`
- Time (ms) before: 33 ms
- What did you change? =>HashSet<int> to make lookups faster.
- Time complexity after: `O(n + m)` on average
- Time (ms) after: 4 ms

---

## Students

- What was the problem? `GetAllStudents()` created and stored one million students in a list, even though the program printed only the first three.
- What did you change? Changed the return type to `IEnumerable<Student>` and used `yield return` to generate students lazily, so only the requested students are created.
