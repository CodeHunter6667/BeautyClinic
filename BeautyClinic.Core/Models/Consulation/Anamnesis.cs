using BeautyClinic.Core.Models.Person;

namespace BeautyClinic.Core.Models.Consulation;

public class Anamnesis
{
    public Individual Client { get; set; } = new();
    public long ClientId { get; set; }    
}
