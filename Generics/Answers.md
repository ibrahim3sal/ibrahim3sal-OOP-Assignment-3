## Step 2

**same**

Both `StudentStore` and `CourseStore` use a `List<T>` to store objects and provide the same four operations: `Add`, `GetById`, `GetAll`, and `Remove`.

**different**

`StudentStore` stores `Student` objects with `Id` and `Name`, while `CourseStore` stores `Course` objects with `Id`, `Title`, and `Price`. Their implementations are almost identical, but they operate on different types and their properties differ.