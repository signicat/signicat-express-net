using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Organization
{
    public enum OrganizationSanctionsResultsStatus
    {
        [EnumMember(Value = "UNKNOWN")] UNKNOWN,

        [EnumMember(Value = "SANCTION")] SANCTION,

        [EnumMember(Value = "NONE")] NONE
    }
}