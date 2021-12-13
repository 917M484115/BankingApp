using System.ComponentModel;

namespace Abc.Aids.Enums {
    public enum ClassificatorType {
        Unspecified = 0,
        [Description("Order Identifier Type")] OrderIdentifierType = 1,
        [Description("Party Capability Type")] PartyCapabilityType = 2,
        [Description("Party Contact Usage Type")] PartyContactUsageType = 3,
        [Description("Person Name Prefix Type")] PersonNamePrefixType = 4,
        [Description("Registration Authority Type")] RegistrationAuthorityType = 5,
        [Description("Party Name Use Type")] PartyNameUseType = 6,
        [Description("Registered Identifier Type")] RegisteredIdentifierType = 7,
        [Description("Ethnicity")] Ethnicity = 8,
        [Description("Person Name Suffix Type")] PersonNameSuffixType = 9,
        [Description("Organization Type")] OrganizationType = 10,
        [Description("Preference Type")] PreferenceType = 11
    }
}
