using System.ComponentModel.DataAnnotations;

namespace QuanLyThuVien.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public int PublishedYear { get; set; }

    public int AuthorId { get; set; }

    public Author Author { get; set; } = null!;
}