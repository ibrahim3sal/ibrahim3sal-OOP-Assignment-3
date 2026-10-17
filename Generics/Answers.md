## Step 2

**same**

Both `StudentStore` and `CourseStore` use a `List<T>` to store objects and provide the same four operations: `Add`, `GetById`, `GetAll`, and `Remove`.

**different**

`StudentStore` stores `Student` objects with `Id` and `Name`, while `CourseStore` stores `Course` objects with `Id`, `Title`, and `Price`. Their implementations are almost identical, but they operate on different types and their properties differ.


## Step 3

**Compiler error:**

error CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

**Why does the compiler reject it?**

The compiler does not know that T has an Id property because T can represent any type.