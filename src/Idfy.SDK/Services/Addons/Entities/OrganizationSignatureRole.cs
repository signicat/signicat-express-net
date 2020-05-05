using System.Runtime.Serialization;

namespace Idfy.Addons.Entities
{
    public enum OrganizationSignatureRole
	{
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
        
        [EnumMember(Value = "CHAIRMAN_OF_THE_BOARD")]
        CHAIRMANOFTHEBOARD,
        
        [EnumMember(Value = "DEPUTY_CHAIRMAN_OF_THE_BOARD")]
        DEPUTYCHAIRMANOFTHEBOARD,
        
        [EnumMember(Value = "BOARD_MEMBER")]
        BOARDMEMBER,
        
        [EnumMember(Value = "EMPLOYEES_REPRESENTATIVE")]
        EMPLOYEESREPRESENTATIVE,
        
        [EnumMember(Value = "DEPUTY_BOARD_MEMBER")]
        DEPUTYBOARDMEMBER,
        
        [EnumMember(Value = "OBSERVER")]
        OBSERVER,
        
        [EnumMember(Value = "REPRESENTATIVE_FOREIGN_ENTITY")]
        REPRESENTATIVEFOREIGNENTITY,
        
        [EnumMember(Value = "LIABLE_PARTNER")]
        LIABLEPARTNER,
        
        [EnumMember(Value = "CEO")]
        CEO,
        
        [EnumMember(Value = "COMPANY_SECRETARY")]
        COMPANYSECRETARY,
        
        [EnumMember(Value = "AUDITOR")]
        AUDITOR,
        
        [EnumMember(Value = "AUDIT_EXEMPTION")]
        AUDITEXEMPTION,
        
        [EnumMember(Value = "CERTIFIED_ACCOUNTANT")]
        CERTIFIEDACCOUNTANT,
        
        [EnumMember(Value = "CONTACT")]
        CONTACT,
    }
}
