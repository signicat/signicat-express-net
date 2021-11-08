using System.Runtime.Serialization;

namespace Signicat.Express.Addons.Person
{
    public enum NationalAddressItemAddressStatus
    {
        [EnumMember(Value = "ORDINARY_RESIDENT")]
        ORDINARYRESIDENT,

        [EnumMember(Value = "ABROAD")] ABROAD,

        [EnumMember(Value = "MILITARY")] MILITARY,

        [EnumMember(Value = "SVALBARD")] SVALBARD,

        [EnumMember(Value = "CLIENT_ADDRESS")] CLIENTADDRESS,

        [EnumMember(Value = "NO_PERMANENT_RESIDENCE")]
        NOPERMANENTRESIDENCE,

        [EnumMember(Value = "RESTRICTED_STRICTLY_CONFIDENTIAL")]
        RESTRICTEDSTRICTLYCONFIDENTIAL,

        [EnumMember(Value = "RESTRICTED_CONFIDENTIAL")]
        RESTRICTEDCONFIDENTIAL,

        [EnumMember(Value = "COMMUTER")] COMMUTER,

        [EnumMember(Value = "UNKNOWN")] UNKNOWN
    }
}