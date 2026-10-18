namespace Generics;

public class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> _items = new();

    public void Add(T item)
    {
        if (_items.ContainsKey(item.Id))
        {
            throw new ArgumentException(
                $"An item with ID {item.Id} already exists.");
        }

        _items.Add(item.Id, item);
    }

    public T? GetById(int id)
    {
        if (_items.TryGetValue(id, out T? item))
        {
            return item;
        }

        return default;
    }

    public IReadOnlyDictionary<int, T> GetAll()
    {
        return _items;
    }

    public void Remove(int id)
    {
        _items.Remove(id);
    }
}
