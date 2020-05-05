using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum MatchMode
    {
        [EnumMember(Value = "exact")] EXACT,
        [EnumMember(Value = "fuzzy")] FUZZY,
    }
}