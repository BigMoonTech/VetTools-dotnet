using System.ComponentModel;
using System.Runtime.CompilerServices;
using VetToolsApp.Models;

namespace VetToolsApp.ViewModels;

public class DiseaseViewModel : INotifyPropertyChanged
{    
    IList<Disease> diseases;
    public IList<Disease> Diseases
    {
        get { return diseases; }
        set
        {
            if (diseases != value)
            {
                diseases = value;
                OnPropertyChanged();
            }
        }
    }

    Disease _selectedDisease;
    public Disease SelectedDisease
    {
        get { return _selectedDisease; }
        set
        {
            if (_selectedDisease != value)
            {
                _selectedDisease = value;
                OnPropertyChanged();
            }
        }
    }

    public DiseaseViewModel()
    {
        Diseases = new List<Disease>();

        #region All Diseases
        Diseases.Add(new Disease
        {
            Name = "Lyme Disease",
            Description = "Lorem ipsum dolor sit amet.",
            ClinicalSigns = "Lethargy. Weakness. A \"walking on eggshell\" appearance to their gait. Rotating lameness (limping on different legs at varrying times). Increased thirst. Increased urination.",
            ContractedBy = "Lyme Disease is contracted by lorem ipsum.",
            PreventionTips = "Stay out of tall grass."
        });

        Diseases.Add(new Disease
        {
            Name = "Roundworm (Toxocara)",
            Description = "Long, round, white worms; often compared to spaghetti noodles.",
            ClinicalSigns = "Pot Belly and/or belly pain. Breath smells like \"Puppy Breath\". Diarrhea. Worms in stool or vomit. Weakness. Weight loss. Dull Coat",
            ContractedBy = "Environment—Dogs and cats can contract Roundworm when they consume worm larvae or eggs from infected feces or ground-soil where infected feces previously laid. Raw or undercooked meats. Mother—Puppies and kittens can become infected during embryonic development when larvae in the mother's tissues migrate through the uterus and placenta and into the baby. Larvae can also enter the mother's mammary tissues and cause infection through nursing. And contact with infected feces during the birthing process.",
            AdditionalInfo = "WARNING: Roundworm is Zoonotic! Zoonotic parasites can be passed from animal to humans. It is Recommended that Pet-Parents thoroughly sanitize their hands after handling an infected animal, and when picking up animal feces. Note: Roundworm is the most common parasitic worm found inside dogs and cats.",
            PreventionTips = "Continue with annual fecal testing. Many heartworm preventative medications also offer protection against Roundworm."
        });

        Diseases.Add(new Disease
        {
            Name = "Hookworm (Ancylostoma)",
            Description = "Hookworm description",
            ClinicalSigns = "HW signs",
            ContractedBy = "Things make HW contractable",
            AdditionalInfo = "No additional notes",
            PreventionTips = "HW prevention tips."
        });
        #endregion
    }


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
