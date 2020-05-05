using System.Collections.Generic;

namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationFinanicialCreditModel
    {
        /// <summary>
        ///     Current credit information
        /// </summary>
        public OrganizationFinanicialCreditItemModel Current { get; set; }

        /// <summary>
        ///     Historic credit information
        /// </summary>
        public List<OrganizationFinanicialCreditHistoricItemModel> Historical { get; set; }

        /// <summary>
        ///     The organization payment defaults
        /// </summary>
        public OrganizationPaymentDefaultModel PaymentDefaults { get; set; }

        /// <summary>
        ///     Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}