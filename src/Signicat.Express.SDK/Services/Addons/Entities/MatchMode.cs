using System.Runtime.Serialization;

namespace Signicat.Express.Addons
{
    public enum MatchMode
    {
        [EnumMember(Value = "exact")] EXACT,
        [EnumMember(Value = "fuzzy")] FUZZY,
    }
}