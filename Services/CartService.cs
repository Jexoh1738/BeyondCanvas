using Midterm.Models;

namespace Midterm.Services;

/// <summary>Scoped (per-circuit) cart. Components subscribe to OnChange to re-render.</summary>
public class CartService
{
    public const decimal FeeRate = 0.025m;
    public const decimal EthUsd = 3250m;

    private readonly List<Artwork> _items = [];

    public IReadOnlyList<Artwork> Items => _items;
    public int Count => _items.Count;
    public decimal Subtotal => _items.Sum(i => i.Price);
    public decimal Fee => Subtotal * FeeRate;
    public decimal Total => Subtotal + Fee;

    public event Action? OnChange;

    public void Add(Artwork item)
    {
        _items.Add(item);
        OnChange?.Invoke();
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _items.Count) return;
        _items.RemoveAt(index);
        OnChange?.Invoke();
    }

    public void Clear()
    {
        _items.Clear();
        OnChange?.Invoke();
    }
}
