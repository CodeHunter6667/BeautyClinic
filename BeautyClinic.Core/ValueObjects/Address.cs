using BeautyClinic.Core.Base;
using BeautyClinic.Core.Models.Person;

namespace BeautyClinic.Core.ValueObjects;

public class Address : BaseEntity
{
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public List<Individual> Individuals { get; set; } = new();
    public List<Professional> Professionals { get; set; } = new();
}
