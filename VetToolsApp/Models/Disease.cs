namespace VetToolsApp.Models;

internal abstract class Disease
{
    public abstract string Name { get; }
    
    public abstract string Description { get; }

    public abstract string ClinicalSigns { get; }

    public abstract string ContractedText { get; }
}