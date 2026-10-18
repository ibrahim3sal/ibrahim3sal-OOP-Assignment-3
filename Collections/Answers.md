# task 2.1

1. What is IReadOnlyDictionary<TKey, TValue>?

IReadOnlyDictionary<TKey, TValue> is an interface that represents a collection of key-value pairs that can be read but not modified through this interface. It provides operations such as accessing a value by its key and checking whether a key exists.

2. How is IReadOnlyDictionary different from Dictionary, and why return it from a public method?

Dictionary<TKey, TValue> allows adding, updating, and removing entries, while IReadOnlyDictionary<TKey, TValue> exposes only read operations. A public method can return IReadOnlyDictionary to limit the operations available to callers and hide the concrete collection type. However, this interface alone does not guarantee that the underlying collection cannot be modified through another reference.

3. What is SortedDictionary<TKey, TValue>?

SortedDictionary<TKey, TValue> is a collection of unique keys and their values that keeps its entries sorted by key. It uses a binary search tree to store and retrieve entries.

4. How is SortedDictionary different from Dictionary in ordering and lookup speed, and when would you choose it?

Dictionary<TKey, TValue> does not guarantee a particular enumeration order and provides average O(1) lookup by key. SortedDictionary<TKey, TValue> keeps entries sorted by key and provides O(log n) lookup, insertion, and removal. I would choose SortedDictionary when I need to iterate through entries in sorted key order, and Dictionary when fast key-based lookup is more important than ordering.


# task 2.2

### S1
**Collection:** `Dictionary`

**Reason:** A Dictionary provides average O(1) lookup by key, making it suitable for frequent searches using a national ID.

### S2
**Collection:** `HashSet`

**Reason:** A HashSet stores unique elements and prevents duplicate tags.

### S3
**Collection:** `List`

**Reason:** A List preserves the order in which grades are added and allows duplicate values.

### S4
**Collection:** `IReadOnlyDictionary`

**Reason:** IReadOnlyDictionary allows callers to read key-value pairs without exposing add, update, or remove operations through the returned interface.

### S5
**Collection:** `SortedDictionary`

**Reason:** A SortedDictionary maintains entries sorted by key, so sessions are enumerated in start-time order.

### S6
**Collection:** `IEnumerable`

**Reason:** IEnumerable supports iteration without requiring the method to build and return an entire collection in advance.