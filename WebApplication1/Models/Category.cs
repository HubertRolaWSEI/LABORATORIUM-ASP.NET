using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public enum Category
{
    [Display(Name = "Rodzina")]
    Family = 1,
    [Display(Name = "Znajomy")]
    Friend = 2,
    [Display(Name = "Kontakt Zawodowy")]
    Business = 4
}