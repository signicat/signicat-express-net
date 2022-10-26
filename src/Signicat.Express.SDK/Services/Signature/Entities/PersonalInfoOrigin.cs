using System.Runtime.Serialization;

namespace Signicat.Express.Signature
{
    public enum PersonalInfoOrigin
    {
        [EnumMember(Value = "unknown")]
        Unknown = 0,
        [EnumMember(Value = "eid")]
        Eid = 1,
        [EnumMember(Value = "userFormInput")]
        UserFormInput = 2
    }
}