namespace VetToolsApp.Models;

internal class Roundworm : Disease
{
    public override string Name => "Roundworm (Toxocara)";

    public override string Description => "Long, round, white worms; often compared to spaghetti noodles. Note: Roundworm is the most common parasitic worm found inside dogs and cats.";

    public override string ClinicalSigns => "Pot Belly and/or belly pain\r\n\"Puppy Breath\"\r\nDiarrhea\r\nWorms in stool or vomit\r\nWeakness\r\nWeight loss\r\nDull Coat";

    public override string ContractedText => "Environment—Dogs and cats can contract Roundworm when they consume worm larvae or eggs from infected feces or ground-soil where infected feces previously laid. Raw or undercooked meats.\r\n\r\nMother—Puppies and kittens can become infected during embryonic development when larvae in the mother's tissues migrate through the uterus and placenta and into the baby. Larvae can also enter the mother's mammary tissues and cause infection through nursing. And contact with infected feces during the birthing process.";

    public static string AdditionalWarning => "Important: Roundworm is Zoonotic! Zoonotic parasites can be passed from a pet, to humans. It is Recommended that Pet-Parents thoroughly sanitize their hands after handling the pet and when picking up pet feces.";

    public static string PreventionTips => "Continue with annual fecal testing. Many heartworm preventative medications also offer protection against Roundworm.";
}

