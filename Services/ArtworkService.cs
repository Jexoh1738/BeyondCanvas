using Midterm.Models;

namespace Midterm.Services;

public class ArtworkService
{
    private readonly List<Artwork> _art =
    [
        new(1, "Synthetic Bloom", "Ellis Vane", 2.84m, "Abstract",    "/images/synthetic-bloom.jpg"),
        new(2, "Frequency 07",    "Mika Sol",   1.62m, "Generative",  "/images/frequency-07.jpg"),
        new(3, "Soft Machine",    "Rey Kato",   3.10m, "3D",          "/images/soft-machine.jpg"),
        new(4, "Garden of Unspoken Words", "Lleah Matsuda",  0.92m, "Abstract",    "/images/garden-unspoken.jpg"),
        new(5, "Portrait of Self","Unknown",  1.48m, "Generative", "/images/self-insert.jpg"),
        new(6, "Afterglow",       "June Static",2.05m, "Generative",  "/images/afterglow.jpg"),
    ];

    public IReadOnlyList<Artwork> GetAll() => _art;

    public Artwork Featured => _art[0];

    public IEnumerable<string> Categories =>
        new[] { "All" }.Concat(_art.Select(a => a.Category).Distinct());
}
