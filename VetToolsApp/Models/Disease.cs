using BinaryTreeStructures.Nodes;

namespace VetToolsApp.Models;

public class Disease
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string ClinicalSigns { get; set; }

    public string ContractedBy { get; set; }

    public string AdditionalInfo { get; set; }

    public string PreventionTips { get; set; }

    public List<QueryNode> QueryList { get; set; }

}