using System.Collections.Generic;

namespace Idfy.Addons.Entities
{
    public class OrganizationOrganizationFinanicialCreditModel
    { 
        /// <summary>
        /// Current credit information
        /// </summary>
        public OrganizationOrganizationFinanicialCreditItemModel Current { get; set; }

        /// <summary>
        /// Historic credit information
        /// </summary>
        public List<OrganizationOrganizationFinanicialCreditHistoricItemModel> Historical { get; set; }

        /// <summary>
        /// The organization payment defaults
        /// </summary>
        public OrganizationPaymentDefaultModel PaymentDefaults { get; set; }

        /// <summary>
        /// Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationOrganizationMetaData Metadata { get; set; }
    }
}
