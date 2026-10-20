namespace Midterm.Models;

public record Artwork(
    int Id,
    string Title,
    string Creator,
    decimal Price,
    string Category,
    string Image);
