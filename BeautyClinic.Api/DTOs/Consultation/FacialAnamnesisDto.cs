using BeautyClinic.Core.Enums;

namespace BeautyClinic.Api.DTOs.Consultation;

public class FacialAnamnesisDto
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public string MainComplaints { get; set; } = string.Empty;
    public bool MelaninRelatedPigmentSpotsPresent { get; set; }
    public bool VascularAlterationSpotsPresent { get; set; }
    public bool SolidFormationsPresent { get; set; }
    public bool LiquidContentFormationsPresent { get; set; }
    public bool SkinLesionsPresent { get; set; }
    public bool SequelaeOrScarsPresent { get; set; }
    public bool FacialHairAlterationsPresent { get; set; }
    public bool KeratinizationAlterationsPresent { get; set; }
    public ESkinClassification SkinClassification { get; set; }
    public ESkinThicknessClassification SkinThicknessClassification { get; set; }
    public EOilinessClassification OilinessClassification { get; set; }
    public ESensitivityClassification SensitivityClassification { get; set; }
    public string Notes { get; set; } = string.Empty;
}
