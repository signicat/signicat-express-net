using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Person
{
    public enum NumberOfResidentsHouseType
    {
        [EnumMember(Value = "DetachedHouse")] DetachedHouse,

        [EnumMember(Value = "Duplex")] Duplex,

        [EnumMember(Value = "Terraced")] Terraced,

        [EnumMember(Value = "Unused")] Unused,

        [EnumMember(Value = "Apartment")] Apartment,

        [EnumMember(Value = "OfficePublicStudentHouseOrOthers")]
        OfficePublicStudentHouseOrOthers,

        [EnumMember(Value = "Other")] Other
    }
}