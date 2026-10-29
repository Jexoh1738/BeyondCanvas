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
        new(6, "Afterglow","June Static",2.05m, "Generative",  "/images/afterglow.jpg"),
        new(7, "Crescent Silver","D Marshall",2.05m, "Generative",  "/images/crescent-silver.jpg"),
        new(8, "Unnamed Man","Weak Alcovich",2.05m, "Realistic",  "/images/unnamed-man.jpg"),
        new(9, "Van Gone","John Silverware",2.05m, "Generative",  "/images/van-gone.jpg"),
        new(10, "Individual Roman","Hoo Jim Kim",2.05m, "Realistic",  "/images/individual-roman.jpg"),
        new(11, "Double Dog","Kaye Eight",2.05m, "Realistic",  "/images/double-dog.jpg"),
        new(12, "Solar Express","Plus8",1.00m, "Generative",  "/images/solar-express.jpg"),
        new(13, "Spanish Fajita","Miguel Enrique",2.05m, "3D",  "/images/spanish-fajita.jpg"),
    ];

    public IReadOnlyList<Artwork> GetAll() => _art;

    public Artwork Featured => _art[0];

    public IEnumerable<string> Categories =>
        new[] { "All" }.Concat(_art.Select(a => a.Category).Distinct());
}
