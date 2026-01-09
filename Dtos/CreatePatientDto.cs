using System.ComponentModel.DataAnnotations;

namespace HelloEnterpriseApi.Dtos;

public class CreatePatientDto
{
    [Required]
    [MinLength(3)]
    public string FullName { get; set; } = string.Empty;

    [Range(0, 120)]
    public int Age { get; set; }
}
