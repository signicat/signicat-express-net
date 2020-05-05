﻿﻿﻿using System.Runtime.Serialization;

  namespace Idfy.Addons.Entities.Person
{
    /// <summary>
    /// Use comma separated list to pick what information you want to receive 
    /// </summary>
    public enum PersonExpand
    {
 
        /// <summary>
        /// Birthplace information
        /// </summary>
        [EnumMember(Value = "keyInformation.birthplace")]
        keyInformation_birthplace,
        /// <summary>
        /// Citizenship information
        /// </summary>
        [EnumMember(Value = "keyInformation.citizenship")]
        keyInformation_citizenship,
        /// <summary>
        /// List all historic names of person
        /// </summary>
        [EnumMember(Value = "keyInformation.historicNames")]
        keyInformation_historicNames,
        /// <summary>
        /// Registered postal address
        /// </summary>
        [EnumMember(Value = "address.postal")]
        address_postal,
        /// <summary>
        /// National registered address
        /// </summary>
        [EnumMember(Value = "address.national")]
        address_national,
        /// <summary>
        /// Historic addresses
        /// </summary>
        [EnumMember(Value = "address.historic")]
        address_historic,
        /// <summary>
        /// Number of residents at address, also returns type of house if available 
        /// </summary>
        [EnumMember(Value = "address.numberOfResidents")]
        address_numberOfResidents,
        /// <summary>
        /// AML information
        /// </summary>
        [EnumMember(Value = "aml")]
        aml,
 
        /// <summary>
        /// AML report
        /// </summary>
        [EnumMember(Value = "links.reports.aml")]
        links_reports_aml,

        // NOT INCLUDED IN V1 of the API
        
        
//        [EnumMember(Value = "economy.ownership")]
//        economy_ownership,
//        [EnumMember(Value = "economy.credit")]
//        economy_credit,     
//        [EnumMember(Value = "roles")]
//        roles,
//         /// <summary>
//        /// Family information
//        /// </summary>
//        [EnumMember(Value = "information.family")]
//        information_family,
//        /// <summary>
//        /// Contact information
//        /// </summary>
//        [EnumMember(Value = "contact")]
//        contact,
//        /// <summary>
//        /// Credit info, not yet implemented 
//        /// </summary>
//        [EnumMember(Value = "links.report.credit")]
//        links_report_credit,
    }
}