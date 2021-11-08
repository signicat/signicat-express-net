using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Organization
{
    public enum OrganizationRemarkCategory
    {
        [EnumMember(Value = "EXCEPTIONS_POSSIBLE")]
        EXCEPTIONSPOSSIBLE,

        [EnumMember(Value = "SUPPLEMENTED")] SUPPLEMENTED,

        [EnumMember(Value = "INCOMPLETE_DATA")]
        INCOMPLETEDATA
    }
}