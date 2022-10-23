using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetToolsApp.Viewmodels.Queries
{
    internal class CommonQuery
    {
        // commonDialogs:
        public string isYoungerThan6Months = "Is the animal less than 6 months old?";
        public string wcNearby = "Does the pet-parent have access to a Pet IQ wellness center nearby?";
        public string takeToWC = "Advise Pet-Parent: Please take the animal to your nearest wellness center to receive the recommended treatment.";
        public string ccNearby = "Does the pet-parent have access to a community clinic nearby?";
        public string takeToCC = "Advise Pet-Parent: Take your animal to a nearby community clinic for the recommended treatment.";
        public string isUrgent = "Does the animal need treatment immediately?";
        public string roundwormER = "Advise Pet-Parent: Take the animal to an animal hospital ER for immediate treatment. Note: treatment is available through PetIQ and usually consists of Pyrantel liquid @ 1mL per every 10 pounds or another OTC de-wormer.";
        public string roundwormTx = "Advise Pet-Parent: Treatment is available through PetIQ and usually consists of Pyrantel liquid @ 1mL per every 10 pounds. Note: veterinarians recommend treating worms in a timely manner. OTC de-wormer, including Pyrantel, may be available online or through other means.";
        public string reweigh = "Advise Pet-Parent: The veterinarian is required to reweigh your animal before prescribing medication due to the length of time since last visit.";
        public string seenIn3Months = "Has it been longer than 3 months since the pets last visit?";
        public string isLargeBreed = "Is the animal a large breed dog (examples: Great Dane, Bull Mastiff)?";
        public string fsvNearby = "Does the pet-parent have a relationship with a full service vet, where the animal can be seen in a reasonable amount of time?";
        public string isChronicLyme = "Is the infection chronic and/or recurring?";
        public string longerThan2Weeks = "Has it been longer than 2 weeks since the animal's last visit?";

    }
}
