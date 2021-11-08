using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Organization
{
    /// <summary>
    ///     Input for Organization queries
    /// </summary>
    public class OrganizationQueryModel
    {
        /// <summary>
        ///     Organization number
        /// </summary>
        public string OrganizationNumber { get; set; }

        /// <summary>
        ///     Nationality of the organization (two letters ISO 3166 )
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        ///     DUNS number
        /// </summary>
        public string DunsNumber { get; set; }


        /// <summary>
        ///     List of expands for the information requested
        /// </summary>
        public List<OrganizationExpands> Expands { get; set; }

        /// <summary>
        ///     Language of the report, currently supports NO/EN (two letters ISO 639-1)
        /// </summary>
        public string Language { get; set; }

        public string RequestUri { get; set; }
        public string RequestIp { get; set; }
        public Guid TransactionId { get; set; }

        /// <summary>
        ///     Name of organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Match mode
        /// </summary>
        public MatchMode MatchMode { get; set; }
    }

    public enum OrganizationExpands
    {
        [EnumMember(Value = "keyInformation.lei")]
        keyInformation_lei,
        [EnumMember(Value = "address")] address,

        //AML-347
        //        [EnumMember(Value = "address.numberOfUnits")]
        //        address_numberOfUnits,
        [EnumMember(Value = "sanction")] sanction,

        [EnumMember(Value = "ownership.beneficial")]
        ownership_beneficial,

        [EnumMember(Value = "ownership.shareholders")]
        ownership_shareholders,

        [EnumMember(Value = "ownership.subsidiaries")]
        ownership_subsidiaries,
        [EnumMember(Value = "officialRoles")] officialRoles,
        [EnumMember(Value = "authorizations")] authorizations,
        [EnumMember(Value = "authorities")] authorities,

        [EnumMember(Value = "financials.key_figures")]
        financials_key_figures,

        [EnumMember(Value = "financials.auditor")]
        financials_auditor,

        [EnumMember(Value = "financials.accounting.firm")]
        financials_accounting_firm,

        [EnumMember(Value = "financials.accounting")]
        financials_accounting,

        [EnumMember(Value = "financials.credit")]
        financials_credit_historic,

        [EnumMember(Value = "financials.credit.historic")]
        financials_credit,

        [EnumMember(Value = "links.reports.aml")]
        links_reports_aml,

        [EnumMember(Value = "links.reports.certificate_of_incorporation")]
        links_reports_certificate_of_incorporation,

        [EnumMember(Value = "links.reports.credit")]
        links_reports_credit
    }
}