using System.ComponentModel.DataAnnotations;

namespace Zad6.DTOs;

public record AnimalUpdateDto(
    [MaxLength(200)] string Name,
    [Required] [MaxLength(200)] string Description,
    [MaxLength(200)] string Category,
    [MaxLength(200)] string Area) ;