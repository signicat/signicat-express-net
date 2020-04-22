﻿﻿using System.Runtime.Serialization;

namespace Idfy.Addons
{
    public enum AmlListItem
    {
        UN_CONSOLIDATED,
        EU_GLOBAL,
        HMTREASURY,
        OFAC,
        PEP_AC,
        PEP_EDGE
    }

    public enum MatchMode
    {
        [EnumMember(Value = "exact")]
        EXACT,
        [EnumMember(Value = "fuzzy")]
        FUZZY,
    }
}