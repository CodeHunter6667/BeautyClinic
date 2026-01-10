using BeautyClinic.Api.DTOs.ValueObjects;
using BeautyClinic.Core.Enums;

namespace BeautyClinic.Api.DTOs.Person;

public class IndividualDto
{
    public long Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public long AddressId { get; set; }
    public AddressDto Address { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    public DateTime? Birthdate { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public EGender Gender { get; set; }
}