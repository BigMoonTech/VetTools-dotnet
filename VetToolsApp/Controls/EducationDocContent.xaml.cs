using VetToolsApp.Models;

namespace VetToolsApp.Controls;

public partial class EducationDocContent : ContentView
{
    public EducationDocContent()
	{
		InitializeComponent();
        this.BindingContext = this;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public string ClinicalSigns { get; private set; }
    public string ContractedBy { get; private set; }
    public string AdditionalInfo { get; private set; }
    public string PreventionTips { get; private set; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query["SelectedDisease"] is Disease diseaseObject)
        {
            Name = diseaseObject.Name;
            Description = diseaseObject.Description;
            ClinicalSigns = diseaseObject.ClinicalSigns;
            ContractedBy = diseaseObject.ContractedBy;
            AdditionalInfo = diseaseObject.AdditionalInfo;
            PreventionTips = diseaseObject.PreventionTips;
        }
    }
}