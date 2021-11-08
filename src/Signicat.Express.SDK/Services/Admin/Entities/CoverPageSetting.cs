using System.Runtime.Serialization;

namespace Idfy.Admin
{
    public enum CoverPageSetting
    {
        [EnumMember(Value = "FIRSTPAGE")]
        FirstPage = 0,
        
        [EnumMember(Value = "LASTPAGE")]
        LastPage = 1,
        
        [EnumMember(Value = "HIDDEN")]
        Hidden = 2
    }
}